using System.Threading.Tasks;
using AppKit;
using Foundation;

namespace TestApplicationVSStream
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        private WebServer webServer;

        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            this.webServer = new WebServer();

            JsonRpcManager.Instance.Initialize();

            Task.Run(() => this.webServer.Listen(8080));
            // Insert code here to initialize your application
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
