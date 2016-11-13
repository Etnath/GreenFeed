using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GreenFeed.WPF.Dependencies
{
    public class BrowserBindableProperties
    {
        public static readonly DependencyProperty UrlLinkProperty = DependencyProperty.RegisterAttached(
            "UrlLink", 
            typeof(string), 
            typeof(BrowserBindableProperties), 
            new FrameworkPropertyMetadata(null, OnUrlChanged));

        [AttachedPropertyBrowsableForType(typeof(WebBrowser))]
        public static string GetUrlLink(DependencyObject obj)
        {
            return (string)obj.GetValue(UrlLinkProperty);
        }

        public static void SetUrlLink(DependencyObject obj, string value)
        {
            obj.SetValue(UrlLinkProperty, value);
        }

        public static void OnUrlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            string url = e.NewValue as string;
            if (webBrowser != null)
            {
                webBrowser.Source = !String.IsNullOrEmpty(url) ? new Uri(url) : null;
            }
        }
    }
}
