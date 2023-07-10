using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace ZIASystem.Views.UserControls
{
    /// <summary>
    /// Interaction logic for EmployerReserveClinicUC.xaml
    /// </summary>
    public partial class EmployerReserveClinicUC : UserControl
    {
        Controllers.EmployerConroller employerConroller;
        public EmployerReserveClinicUC()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            employerConroller = new Controllers.EmployerConroller();
            OracleDataAdapter adapter = employerConroller.GetClinics();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DGrid.ItemsSource = dt.DefaultView;
        }

        private void reserve_btn_Click(object sender, RoutedEventArgs e)
        {
            employerConroller.reserveClinic(Convert.ToInt32(clinic_txt.Text), 2);
        }

    }
}