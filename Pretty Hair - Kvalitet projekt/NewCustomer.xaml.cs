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
using System.Windows.Shapes;

namespace Pretty_Hair___Kvalitet_projekt
{
	/// <summary>
	/// Interaction logic for NewCustomer.xaml
	/// </summary>
	public partial class NewCustomer : Window
	{
		public NewCustomer()
		{
			InitializeComponent();
		}

        private void NewCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            controller.InsertCustomer(NameTB.Text, AddressTB.Text, ZipTB.Text, TownTB.Text, PhoneTB.Text);
            MessageBox.Show("Kunde oprettet!");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
