using Ninja.WebSockets;
using StreamJsonRpc;
using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using AppKit;
using Foundation;

namespace Client
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        private WebSocket webSocket;
        private JsonRpc jsonRpc;
        private WebSocketClientFactory factory;
        public AppDelegate()
        {
        }

        public override async void DidFinishLaunching(NSNotification notification)
        {
            this.factory = new WebSocketClientFactory();
            var uri = new Uri("ws://127.0.0.1:8080");
            this.webSocket = await this.factory.ConnectAsync(uri);
            this.jsonRpc = new JsonRpc(new WebSocketMessageHandler(webSocket));
            this.jsonRpc.StartListening();
            var result = await jsonRpc.InvokeAsync<int>("Add", 5, 10);

            Console.WriteLine(result);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
