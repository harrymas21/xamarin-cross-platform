namespace izCarbo
{
    public class App : MultiPageRestorableApp
    {
        public App()
        {
            // Make call to method in MultiPageRestorableApp.
            Startup(typeof(MainPage));
        }

        protected override void OnSleep()
        {
            // Required call when deriving from MultiPageRestorableApp.
            base.OnSleep();
        }
    }
}
 