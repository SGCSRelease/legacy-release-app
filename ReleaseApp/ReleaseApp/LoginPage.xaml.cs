using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReleaseApp.Effects;
using Xamarin.Forms;

namespace ReleaseApp
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();

            var tapRecognizer = new TapGestureRecognizer();
            tapRecognizer.Tapped += (S, E) =>
            {
                this.find_idpw.SetValue(Label.TextProperty, "Tapped!");
                this.find_idpw.Effects.Add(Effect.Resolve("UnderlineLabelEffect"));
            };
            this.find_idpw.GestureRecognizers.Add(tapRecognizer);
        }
        public void LoginAttempt(object sender, EventArgs e)
        {
            this.login_btn.SetValue(Button.TextProperty, "Clicked Wow");
        }
	}
}