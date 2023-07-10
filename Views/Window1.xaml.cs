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
using System.Windows.Shapes;

namespace ZIASystem.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        CrystalReport1 Cr;

        public Window1()
        {
            InitializeComponent();
        }

        private void View_btn_Click(object sender, RoutedEventArgs e)
        {
            viewer.ViewerCore.ReportSource = Cr;
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Cr = new CrystalReport1();
        }
    }
}
