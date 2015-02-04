using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace Porter
{
	public partial class RegisterUser : ContentPage
	{
		public RegisterUser ()
		{
			this.LoadFromXaml(typeof(RegisterUser));
		}

		public void SaveName(object sender, EventArgs e)
		{
			var labelSaved = this.FindByName<Label> ("Saved");
			var entryBox = this.FindByName<Entry> ("NameEntry");

			labelSaved.Text = "Du er nå lagret som " + entryBox.Text;


		}
	}
}

