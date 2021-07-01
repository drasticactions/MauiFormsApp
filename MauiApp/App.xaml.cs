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
		}

        protected override IWindow CreateWindow(IActivationState activationState)
		{
			// VisualDiagnostics.VisualTreeChanged += VisualDiagnostics_VisualTreeChanged;

			this.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>()
				.SetImageDirectory("Assets");

			//var tabbedPage = new Microsoft.Maui.Controls.TabbedPage();
			//tabbedPage.Children.Add(new NavigationPage(new MainPage()));
			return new TestWindow(new NavigationPage(new MainPage()));
		}
	}

    public class TestWindow : Window
    {

        public TestWindow()
        {
        }

        public TestWindow(Microsoft.Maui.Controls.Page page) : base(page)
        {
			VisualDiagnostics.VisualTreeChanged += VisualDiagnostics_VisualTreeChanged;
		}

		private void VisualDiagnostics_VisualTreeChanged(object sender, VisualTreeChangeEventArgs e)
		{
            try
            {
				var parentSourInfo = VisualDiagnostics.GetXamlSourceInfo(e.Parent);
				var childSourInfo = VisualDiagnostics.GetXamlSourceInfo(e.Child);
				Debug.WriteLine($"VisualTreeChangeEventArgs {e.ChangeType}:" +
					$"{e.Parent}:{parentSourInfo?.SourceUri}:{parentSourInfo?.LineNumber}:{parentSourInfo?.LinePosition}-->" +
					$" {e.Child}:{childSourInfo?.SourceUri}:{childSourInfo?.LineNumber}:{childSourInfo?.LinePosition}");
			}
            catch (Exception ex)
            {
				Debug.WriteLine(ex);
			}
		}
	}
}
