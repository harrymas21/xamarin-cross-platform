using Xamarin.Forms;

namespace izCarbo.Services
{
    public class DeviceHelper : IDeviceHelper
    {
        IDeviceHelper deviceHelper = DependencyService.Get<IDeviceHelper>();

        public void CloseApp()
        {
            deviceHelper.CloseApp();
        }

        public string GetIdentifier()
        {
            return deviceHelper.GetIdentifier();
        }
    }
}
