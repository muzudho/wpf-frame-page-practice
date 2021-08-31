using System;
using System.Windows;

namespace WpfFramePagePractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Uri uri = new Uri("/Page1.xaml", UriKind.Relative);
            frame.Source = uri;
        }
    }
}
