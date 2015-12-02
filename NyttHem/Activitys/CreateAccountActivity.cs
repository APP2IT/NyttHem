
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NyttHem
{
	[Activity (Label = "CreateAccountActivity", MainLauncher = false, Icon = "@mipmap/icon",Theme = "@style/MyCustomTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]			
	public class CreateAccountActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.CreateAccount);
			// Create your application here

			Button btnBack = FindViewById <Button> (Resource.Id.btnBack);
			btnBack.Click += delegate {
				base.OnBackPressed();
				//StartActivity(typeof(MainActivity));
			};
		}
	}
}

