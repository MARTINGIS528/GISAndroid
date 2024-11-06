using System.Data.SqlTypes;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Timers;

namespace GISAndroid
{
	public partial class MainPage : ContentPage
	{
		//deklarácia časovača
		private System.Timers.Timer _timer;

		public MainPage()
		{
			InitializeComponent();
			StartTimer();
		}
		#region Ovládacie prvky obrazovky

		private void OnLogoClicked(object sender, EventArgs e)
		{
			//akcia po kliknutí na logo aplikácie

		}
		private void OnMapButtonClicked(object sender, EventArgs e)
		{
			//akcia po kliknutí na ikonu mapy

		}

		private void OnLocationButtonClicked(object sender, EventArgs e)
		{
			//akcia po kliknutí na ikonu bodu

		}

		private void OnWayButtonClicked(object sender, EventArgs e)
		{
			//akcia po kliknutí na ikonu cesty

		}

		private void OnSettingsButtonClicked(object sender, EventArgs e)
		{
			//akcia po kliknutí na ikonu nastavenia

		}
		#endregion

		#region Časovač
		private void StartTimer()
		{
			// Nastavenie časovača:
			_timer = new System.Timers.Timer(1000); // Interval 1 sekunda
			_timer.Elapsed += OnTimedEvent;
			_timer.AutoReset = true;
			_timer.Enabled = true;
		}

		private void OnTimedEvent(object source, ElapsedEventArgs e)
		{
			// Naformátovanie dátumu a času:
			var slovakCulture = new CultureInfo("sk-SK");
			DateTime now = DateTime.Now;
			string dayOfWeek = now.ToString("dddd", slovakCulture);

			MainThread.BeginInvokeOnMainThread(() =>
			{
				DatetimeLabel.Text = $"{dayOfWeek}, {now:dd.MM.yyyy HH:mm:ss}";
			});
		}
		#endregion
	}

}