namespace TestApplicationVSStream
{
    // JsonRpc calls exposed to JsonRpc client.
    internal class JsonRpcServer
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
