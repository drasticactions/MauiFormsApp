using System;
using Microsoft.Maui.Controls;

namespace MauiApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		int count = 0;

		private void Button_Clicked(object sender, EventArgs e)
		{
			this.InitialStack.Children.Add(new Label() { Text = "New Label" });
		}

		private void Button2_Clicked(object sender, EventArgs e)
		{
			this.DevelopText.Text = "New Text";
		}

		private void NewWindow_Clicked(object sender, EventArgs e)
		{
			// Parent is Nav page.
			if (this.Parent.Parent is TestWindow window)
            {
				window.Page = new SecondPage();
            }
		}

		private void ButtonToBeClicked_Clicked(object sender, EventArgs e)
		{
			this.ButtonToBeClicked.Text = "Clicked!";
		}
		private void NavigationPageButton_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushAsync(new MainPage());
		}

		private void SecondPageButton_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushAsync(new SecondPage());
		}
	}
}
