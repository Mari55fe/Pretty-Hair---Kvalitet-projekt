using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pretty_Hair___Kvalitet_projekt
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void NewOrder_Click(object sender, RoutedEventArgs e)
		{
			NewOrder newOrder = new NewOrder();
			newOrder.Show();
			this.Close();
		
		}

		private void NewCustomer_Click(object sender, RoutedEventArgs e)
		{
			NewCustomer newCustomer = new NewCustomer();
			newCustomer.Show();
			this.Close();
		}

		private void FindCustomer_Click(object sender, RoutedEventArgs e)
		{
			FindCustomer findCustomer = new FindCustomer();
			findCustomer.Show();
			this.Close();
		}
	}
}
