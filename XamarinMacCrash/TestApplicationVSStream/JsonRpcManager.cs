namespace TestApplicationVSStream
{
    using StreamJsonRpc;
    using System;
    using System.Collections.Concurrent;
    using System.Net.WebSockets;
    using System.Threading;
    using System.Threading.Tasks;

    internal class JsonRpcManager : Singleton<JsonRpcManager>
    {
        private bool isInitialized = false;
        private ConcurrentDictionary<WebSocket, JsonRpc> clients = new ConcurrentDictionary<WebSocket, JsonRpc>();

        public void Initialize()
        {
            this.isInitialized = true;
        }

        public async Task HandleClient(WebSocket webSocket, CancellationToken token)
        {
            this.ThrowIfNotInitialize();
            var jsonRpc = this.clients.GetOrAdd(webSocket, (key) => new JsonRpc(new WebSocketMessageHandler(webSocket)));
            jsonRpc.AddLocalRpcTarget(new JsonRpcServer());
            jsonRpc.StartListening();
            await jsonRpc.Completion;

            // When it is completed, either the client is disposed or connection is closed.
            this.clients.TryRemove(webSocket, out jsonRpc);
        }

        private void ThrowIfNotInitialize()
        {
            if (!this.isInitialized)
            {
                throw new InvalidOperationException("JsonRpcManager is not initialized");
            }
        }
    }
}
