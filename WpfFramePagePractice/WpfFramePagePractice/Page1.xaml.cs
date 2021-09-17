namespace WpfFramePagePractice
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Navigation;

    /// <summary>
    /// Page1.xaml の相互作用ロジック
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // ページ２を表示します
            var page2 = new Page2();
            // `NavigationService` を使うと、このページが含まれている Frame要素のNavigate機能を使う？
            NavigationService.Navigate(page2);
        }
    }
}
