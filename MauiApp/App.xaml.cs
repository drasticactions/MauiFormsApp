using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Microsoft.Maui.Controls.Xaml.Diagnostics;
using System;
using System.Diagnostics;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			//VisualDiagnostics.VisualTreeChanged += VisualDiagnostics_VisualTreeChanged;
		}

        private void VisualDiagnostics_VisualTreeChanged(object sender, VisualTreeChangeEventArgs e)
        {
			var parentSourInfo = VisualDiagnostics.GetXamlSourceInfo(e.Parent);
			var childSourInfo = VisualDiagnostics.GetXamlSourceInfo(e.Child);
			Debug.WriteLine($"VisualTreeChangeEventArgs {e.ChangeType}:" +
				$"{e.Parent}:{parentSourInfo?.SourceUri}:{parentSourInfo?.LineNumber}:{parentSourInfo?.LinePosition}-->" +
				$" {e.Child}:{childSourInfo?.SourceUri}:{childSourInfo?.LineNumber}:{childSourInfo?.LinePosition}");
		}

        protected override IWindow CreateWindow(IActivationState activationState)
		{
			this.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>()
				.SetImageDirectory("Assets");

			return new Microsoft.Maui.Controls.Window(new NavigationPage(new MainPage()));
		}
	}
}
