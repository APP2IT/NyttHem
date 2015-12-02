using Android.App;
using Android.Widget;
using Android.OS;

namespace NyttHem
{
	[Activity (Label = "NyttHem", MainLauncher = true, Icon = "@mipmap/icon",Theme = "@style/MyCustomTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
	public class MainActivity : Activity
	{
		

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnLogin = FindViewById<Button> (Resource.Id.btnLogin);
			Button btnCreateAccount = FindViewById<Button> (Resource.Id.btnCreateAccount);
			
			btnLogin.Click += delegate {
				StartActivity(typeof(LoginActivity));
			};

			btnCreateAccount.Click += delegate {
				StartActivity(typeof(CreateAccountActivity));
			
			};
		}
	}
}


