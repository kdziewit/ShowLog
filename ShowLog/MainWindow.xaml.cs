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

namespace ShowLog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = viewModel;

            object obj = new object();
            BindingOperations.EnableCollectionSynchronization(viewModel.LogMessages, obj);


            object obj2 = new object();
            BindingOperations.EnableCollectionSynchronization(StaticTarget.StaticLogMessages, obj2);
        }

        private async void AddLog_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    viewModel.LogMessages.Add(viewModel.LogMessage);
                    StaticTarget.StaticLogMessages.Add(viewModel.LogMessage);
                    viewModel.LogMessage = null;
                }
                catch (Exception ex)
                {

                }
            });
        }
    }
}
