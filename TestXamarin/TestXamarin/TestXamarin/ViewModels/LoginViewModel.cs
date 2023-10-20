using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Threading.Tasks;
using TestXamarin.Views;
using Xamarin.Forms;

namespace TestXamarin.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public AsyncCommand LoginCommand { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new AsyncCommand(login);
        }


        private async Task login()
        {
            if (checkCredentials())
            {
                clearFields();
                await Shell.Current.GoToAsync($"//CarDatabaseView", true);
            }
            else
            {
                clearFields();
                await Application.Current.MainPage.DisplayAlert("Credentials", "Credentials are not valid!", "OK");
            }

        }

        private bool checkCredentials()
        {
            return Username == "alex" && Password == "123";
        }

        private void clearFields()
        {
            Username = "";
            Password = "";
        }
    }
}
