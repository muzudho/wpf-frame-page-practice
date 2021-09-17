namespace WpfFramePagePractice
{
    using System;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // フレームに Page1 を表示します
            Uri uri = new Uri("/Page1.xaml", UriKind.Relative);
            frame.Source = uri;
        }
    }
}
