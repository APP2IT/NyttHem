using Android.App;
using Android.Widget;
using Android.OS;

namespace NyttHem
{
	[Activity (Label = "NyttHem", MainLauncher = true, Icon = "@mipmap/icon",Theme = "@android:style/Theme.Material.Light.NoActionBar", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.btnLogin);
			Button btnCreateAccount = FindViewById<Button> (Resource.Id.btnCreateAccount);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};

			btnCreateAccount.Click += delegate {
				StartActivity(typeof(CreateAccountActivity));
			
			};
		}
	}
}


