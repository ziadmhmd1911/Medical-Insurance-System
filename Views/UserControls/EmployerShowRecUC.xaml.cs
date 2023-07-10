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
    /// Interaction logic for EmployerShowRecUC.xaml
    /// </summary>
    public partial class EmployerShowRecUC : UserControl
    {
        Controllers.EmployerConroller employerConroller;
        public EmployerShowRecUC()
        {
            InitializeComponent();
        }

        private void update_view()
        {
            employerConroller = new Controllers.EmployerConroller();
            OracleDataAdapter adapter = employerConroller.GetMedicalRecords(Controllers.EmployerConroller.employerId);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DGrid.ItemsSource = dt.DefaultView;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            update_view();
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            employerConroller.CancelReservation(Convert.ToInt32(id_txt.Text));
            update_view();
        }

    }
}
