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
    /// Interaction logic for EmployerWindow.xaml
    /// </summary>
    public partial class EmployerWindow : Window
    {
        public EmployerWindow()
        {
            InitializeComponent();
        }

        private void showRecBtn_Click(object sender, RoutedEventArgs e)
        {
            view_grid.Children.Clear();
            view_grid.Children.Add(new UserControls.EmployerShowRecUC());
        }

        private void reserve_btn_Click(object sender, RoutedEventArgs e)
        {
            view_grid.Children.Clear();
            view_grid.Children.Add(new UserControls.EmployerReserveClinicUC());
        }

        private void viewReport_btn_Click(object sender, RoutedEventArgs e)
        {
            CrystalRep1 CrystalRep1 = new CrystalRep1();
            CrystalRep1.ShowDialog();
        }
    }
}
