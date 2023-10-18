using Xamarin.Forms;

using TestXamarin.Views;
namespace TestXamarin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CarGarageView), typeof(CarGarageView));
            Routing.RegisterRoute(nameof(CarDatabaseView), typeof(CarDatabaseView));
            Routing.RegisterRoute(nameof(CarDetailsView), typeof(CarDetailsView));
        }

    }
}
