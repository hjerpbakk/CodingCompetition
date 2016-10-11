using System.Windows;

namespace Sidebar
{
    /// <summary>
    /// Interaction logic for DrawWinnerWindow.xaml
    /// </summary>
    public partial class DrawWinnerWindow
    {
        public DrawWinnerWindow()
        {
            InitializeComponent();
        }

        private void DrawWinnerWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            passwordBox.Focus();
        }
    }
}
