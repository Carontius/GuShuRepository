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

namespace Calculadora001
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n;
      
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

       

        

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // n = int.Parse( Button.ContentProperty.ToString());
            
            TextCalcu.Text = Button.ContentStringFormatProperty.ToString();
            MessageBox.Show(Button.ContentStringFormatProperty.ToString());
         
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Content = "111";
        }
    }
}
