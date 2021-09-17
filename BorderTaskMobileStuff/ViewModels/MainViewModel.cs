using System;
namespace BorderTaskMobileStuff.ViewModels
{
	public class MainViewModel : FreshMvvm.FreshBasePageModel
	{
		public string HelloWorld { get; set; } = "Welcome To BorderTaskMobileStuff";
		public string DeviceInfoButton { get; set; } = "Read Device Information";
		public string VHVEButton { get; set; } = "Choose a citizen";
	}
}
