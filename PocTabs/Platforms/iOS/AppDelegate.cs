using Foundation;
using UIKit;

namespace PocTabs;


[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() 
    {
        return MauiProgram.CreateMauiApp();
    }
}