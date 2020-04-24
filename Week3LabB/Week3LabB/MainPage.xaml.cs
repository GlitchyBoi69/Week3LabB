using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week3LabB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Calculate();
        }

        void Calculate()
        {
            var today = DateTime.Now;
            var bday = DatePicker.Date;
            var age = (today - bday).TotalDays / 365;

            if (age >= 21)
            {
                Label.Text = "You are able to have alcohol!";
            }

            else
            {
                Label.Text = "You cannot have alcohol...";
            }
        }
    }
}