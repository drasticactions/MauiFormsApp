using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsNet6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

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
