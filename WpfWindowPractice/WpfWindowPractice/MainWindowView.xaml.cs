namespace WpfWindowPractice
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            var win = new Window1View();
            win.Show();
        }
    }
}
