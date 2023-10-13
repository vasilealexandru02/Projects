using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestXamarin.ViewModels
{
    public class MyButtonPageViewModel : BaseViewModel
    {


        /// <summary>
        /// Method that increases button number of clicked times
        /// </summary>
        public Command IncreaseCount { get; private set; }

        private string buttonText;

        /// <summary>
        /// Example method that calls a server
        /// </summary>
        public ICommand ExampleCallServer { get; private set; }


        public MyButtonPageViewModel()
        {
            IncreaseCount = new Command(increaseCount);
            //ExampleCallServer = new Command(async ()=>await CallServer());
            ExampleCallServer = new AsyncCommand(CallServer);
            ButtonText = "Count: 0";
        }

        public string ButtonText
        {
            get => buttonText;
            set => SetProperty(ref buttonText, value);

            // With mvvm helper library this code is not needed
            //set
            //{
            //    if (buttonText == value)
            //    {
            //        return;
            //    }
            //    buttonText = value;
            //    OnPropertyChanged(nameof(ButtonText));
            //}
        }

        private int buttonCounter { get; set; }

        private void increaseCount()
        {
            buttonCounter++;
            ButtonText = "Count: " + buttonCounter.ToString();
        }

        private Task CallServer()
        {
            return null;
        }
    }
}
