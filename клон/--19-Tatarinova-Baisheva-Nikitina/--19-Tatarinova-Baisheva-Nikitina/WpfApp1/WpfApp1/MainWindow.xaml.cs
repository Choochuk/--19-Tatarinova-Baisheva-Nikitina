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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 32;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for(int j=0; j<10; j++)
            {
                for(int l=0; l<10; l++)
                {
                    Choochuk.Text += Convert.ToString(i + " - " + (char)i + " ");
                    i++;
                    if (i == 128)
                        break;
                }
                Choochuk.Text += "\n";
            }
        }
    }
}
