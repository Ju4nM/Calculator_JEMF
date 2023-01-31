using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator_JEMF
{
    public partial class MainPage : ContentPage
    {
        
        public string Number { get; set; }

        public MainPage()
        {
            InitializeComponent();
            this.Number = "0";
        }

        public void AddNumber(string Number)
        {
            if (this.Number.ElementAt(0) == 0) return;

            this.Number += Number;
        }

        public void UpdateNumber ()
        {
            CurrentNumber.Text = this.Number;
        }
    }
}
