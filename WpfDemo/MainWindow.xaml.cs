using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using System.Windows;
using WpfDemo.Services;

namespace WpfDemo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly ISampleService _sampleService;
		private readonly AppSettings _settings;

		public MainWindow(ISampleService sampleService,
			IOptions<AppSettings> settings)
		{
			InitializeComponent();

			_sampleService = sampleService;
			_settings = settings.Value;
		}

		private async void Button_Click(object sender, RoutedEventArgs e)
		{
			var serviceData = await _sampleService.GetCurrentDate();
			var settingData = _settings;
			
			MessageBox.Text = $"serviceData:{serviceData}{Environment.NewLine}settingsData:{settingData.AppName}";
		}
	}
}
