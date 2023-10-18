using Xamarin.Forms;

namespace TestXamarin.Views
{

    public partial class CarDatabaseView : ContentPage
    {
        public CarDatabaseView()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (sender != null)
            {
                var list = ((ListView)sender).SelectedItem = null;
            }
        }
    }
}