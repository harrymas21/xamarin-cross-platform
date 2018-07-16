using izCarbo.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace izCarbo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigateCommand = new Command<string>(async (string param) =>
            {
                if (!string.IsNullOrWhiteSpace(param) && Enum.IsDefined(typeof(Operation), param))
                {
                    var operation = (Operation)Enum.Parse(typeof(Operation), param);

                    switch (operation)
                    {
                        case Operation.CustomerRegistration:
                            await Navigation.PushAsync(new CustomerRegistrationPage());
                            break;
                        case Operation.CustomerEdit:
                            await Navigation.PushAsync(new CustomerEditPage());
                            break;
                        case Operation.CustomersList:
                            await Navigation.PushAsync(new CustomersListPage());
                            break;
                        case Operation.Settings:
                            await Navigation.PushAsync(new SettingsPage());
                            break;
                        default:
                            break;
                    }
                }
            });

            BindingContext = this;
        }

        public ICommand NavigateCommand { private set; get; }

        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await DisplayAlert("Sure to exit?", "Please note that any unsaved changes will be lost...", "Accept", "Cancel");

                if (result)
                {
                    DependencyService.Get<IDeviceHelper>().CloseApp();
                }
            });

            return true;
        }
    }
}
