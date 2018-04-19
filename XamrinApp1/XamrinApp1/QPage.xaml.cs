using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamrinApp1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QPage : ContentPage
	{
        int pos = 0;
        List<string> Qoutes = new List<string>()
        {
            "Make hay while sunshines",
            "Qoute 2","Qoute 3"
        };
        public QPage ()
		{
			InitializeComponent ();
            LableQoutes.Text = Qoutes[pos];
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

            pos++;
            if (pos >= Qoutes.Count) pos = 0;

            LableQoutes.Text = Qoutes[pos];

           

        }
    }
}