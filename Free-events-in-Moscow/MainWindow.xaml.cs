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

namespace Free_events_in_Moscow
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List <Event> _events = new List<Event>();

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            var newevent = new Event(textBoxTitle.Text, textBoxType.Text, textBoxDate.Text, textBoxTime.Text, textBoxLocation.Text, textBoxDescription.Text);

            _events.Add(newevent);

            textBoxTitle.Text = " ";
            textBoxType.Text = " ";
            textBoxLocation.Text = " ";
            textBoxDescription.Text = " ";
        }
    }
}
