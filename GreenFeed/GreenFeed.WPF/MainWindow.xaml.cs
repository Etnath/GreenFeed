﻿using Akka.Actor;
using GreenFeed.Actors;
using GreenFeed.WPF.ViewModel;
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

namespace GreenFeed.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IActorRef _rssCoordinator;

        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
        }
    }
}
