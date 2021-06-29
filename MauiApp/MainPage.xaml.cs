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

		private void ButtonToBeClicked_Clicked(object sender, EventArgs e)
		{
			this.ButtonToBeClicked.Text = "Clicked!";
		}
	}
}
