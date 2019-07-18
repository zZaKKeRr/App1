using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage: ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Click_Button1(object senser, EventArgs e)
        {
            if (entry1.Text == "pass")
            entry1.Text = "Seccessful";
            else
            {
                entry1.Text = "Fail";
            }
        }
        private void Click_Button2(object sender, EventArgs e) => entry1.Text = "";
    }
}
