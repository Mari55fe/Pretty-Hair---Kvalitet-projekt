﻿using System;
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
	/// Interaction logic for FindCustomer.xaml
	/// </summary>
	public partial class FindCustomer : Window
	{
		public FindCustomer()
		{
			InitializeComponent();
		}

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Controller controller = new Controller();
            controller.ShowCustomer();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
