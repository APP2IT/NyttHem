
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
	[Activity (Label = "LoginActivity", MainLauncher = false, Icon = "@mipmap/icon",Theme = "@android:style/Theme.Material.Light.NoActionBar", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]			
	public class LoginActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Login);

			// Create your application here
		}
	}
}

