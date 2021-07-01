using System;
using Microsoft.Maui.Controls;

namespace MauiApp
{
	public partial class SecondPage : ContentPage
	{
		public SecondPage()
		{
			InitializeComponent();
		}

		private void ChangePageTitleButton_Clicked(object sender, EventArgs e)
		{
			this.Title = "New Title!";
		}
	}
}
