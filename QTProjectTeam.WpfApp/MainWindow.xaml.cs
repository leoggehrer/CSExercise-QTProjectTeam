﻿using System.Windows;

namespace QTProjectTeam.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel.Window = this;
        }
    }
}
