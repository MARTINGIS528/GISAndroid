using Android.App;
using Android.Content.PM;
using Android.OS;

namespace GISAndroid
{
	[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
	public class MainActivity : MauiAppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Nastavenie farby status baru
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#38dc1e")); // Farba status baru
			}

			// Nastavenie farby spodnej navigačnej lišty (navigation bar)
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				Window.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#38dc1e")); // Farba navigation bar
			}
		}
	}
}
