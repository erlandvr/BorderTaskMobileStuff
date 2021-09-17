using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorderTaskMobileStuff.ViewModels;
using Xamarin.Forms;

namespace BorderTaskMobileStuff.Views
{
	public partial class MainView : ContentPage
	{
		public MainView()
		{
			InitializeComponent();

			BindingContext = new MainViewModel();
		}
	}
}
