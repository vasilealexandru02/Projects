﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarDatabaseView : ContentPage
	{
		public CarDatabaseView ()
		{
			InitializeComponent ();
		}
	}
}