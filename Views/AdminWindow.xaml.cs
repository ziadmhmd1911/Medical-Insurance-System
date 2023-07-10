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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
namespace ZIASystem.Views
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void companies_btn_Click(object sender, RoutedEventArgs e)
        {
            view_grid.Children.Clear();
            view_grid.Children.Add(new UserControls.AdminAddRemoveUC());
        }

        private void hospitals_btn_Click(object sender, RoutedEventArgs e)
        {
            view_grid.Children.Clear();
            view_grid.Children.Add(new UserControls.AdminAddRemoveHospital());
        }

        private void dayRecords_btn_Click(object sender, RoutedEventArgs e)
        {
            view_grid.Children.Clear();
            view_grid.Children.Add(new UserControls.AdminDayRecords());
        }

        private void viewReport_btn_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cmbobx.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Controllers.DBConnection.getConnection();
            cmd.CommandText = "getClinicsnameFromhid";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", Txtbx.Text);
            cmd.Parameters.Add("title", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cmbobx.Items.Add(dr[0]);
            }
            dr.Close();
        }
    }
}
