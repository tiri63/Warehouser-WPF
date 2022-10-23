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

namespace Warehouser_WPF
{
    /// <summary>
    /// Page_Main.xaml の相互作用ロジック
    /// </summary>
    public partial class Page_Main : Page
    {
        public Page_Main()
        {
            InitializeComponent();
            Main_Frame.Content = new Page_Items();
        }
    }
}
