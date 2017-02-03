using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ReleaseApp
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
        public void FindMyIdPw(object sender, EventArgs e)
        {
            var tapRecognizer = new TapGestureRecognizer();
            tapRecognizer.Tapped += (S, E) =>
            {
                

            };
            this.Forgot.GestureRecognizers.Add(tapRecognizer);
        }
	}
}
