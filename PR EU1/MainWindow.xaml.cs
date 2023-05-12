using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;

namespace PR_EU1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow() => InitializeComponent();

		public void ColorChoose(object sender, RoutedEventArgs e)
		{
			if (sender is Button button) sender = new MenuItem() { Name = button.Content.ToString() };
			mainwindow.Background = ((MenuItem)sender).Name switch
			{
				"red" => Brushes.Red,
				"green" => Brushes.Green,
				"blue" => Brushes.Blue,
				"white" => Brushes.White,
				"black" => Brushes.Black,
				_ => Brushes.Purple,
			};
		}
		private void AuthorClick(object sender, RoutedEventArgs e) => MessageBox.Show("top secret", "authors");
		private void ExitClick(object sender, RoutedEventArgs e) => this.Close();
		private void ShowStatus(object sender, MouseEventArgs e)
		{
			status.Text = sender.ToString();
		}
	}
}
