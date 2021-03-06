﻿using Akka.Actor;
using GreenFeed.WPF.ViewModel;
using System.Windows;

namespace GreenFeed.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            RssFeedList.DataContext = this.DataContext;
            FeedItemsList.DataContext = this.DataContext;
            RssPage.DataContext = this.DataContext;
        }
    }
}
