using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TestXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarGarageView : ContentPage
    {
        public CarGarageView()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Item selected event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var car = ((ListView)sender).SelectedItem as Car;
            if (car == null)
                return;
            await DisplayAlert("Selected", "Selected car: " + car.CarName, "OK");
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var car = ((MenuItem)sender).BindingContext as Car;
            if (car.IsFavorited)
            {
                car.IsFavorited = false;
                await DisplayAlert("Favorited!", "This car has been deleted from your favorite cars :(!", "OK");
            }
            else
            {
                car.IsFavorited = true;
                await DisplayAlert("Favorited!", "This car has been added to your favorite cars!", "OK");
            }
            

        }
    }
}