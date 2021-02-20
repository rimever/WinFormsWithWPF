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

namespace WindowsFormsAppWithWpf
{
    /// <summary>
    /// WpfWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class WpfWindow : Window
    {
        public WpfWindow()
        {
            InitializeComponent();
        }

        private void ButtonShowWinFormsOnClick(object sender, RoutedEventArgs e)
        {
            var form = new Form1();
            form.ShowDialog();
        }
    }
}
