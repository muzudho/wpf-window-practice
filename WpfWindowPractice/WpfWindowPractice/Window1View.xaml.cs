using System.Windows;

namespace WpfWindowPractice
{
    /// <summary>
    /// Window1View.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1View : Window
    {
        public Window1View()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
