﻿using System;
using BorderTaskMobileStuff.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BorderTaskMobileStuff
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainView();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
