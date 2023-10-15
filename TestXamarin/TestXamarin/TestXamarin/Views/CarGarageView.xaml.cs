using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{

        //}

        //private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{

        //}
    }
}