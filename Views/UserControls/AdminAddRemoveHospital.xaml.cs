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
    /// Interaction logic for AdminAddRemoveHospital.xaml
    /// </summary>
    public partial class AdminAddRemoveHospital : UserControl
    {
        private Controllers.AdminController adminController;
        OracleDataAdapter adapter ;
        DataTable dt ;
        public AdminAddRemoveHospital()
        {
            InitializeComponent();
        }

        private void update_view()
        {
            Controllers.AdminController adminController = new Controllers.AdminController();
            adapter = adminController.getHospitals();
            dt = new DataTable();
            adapter.Fill(dt);
            DGrid.ItemsSource = dt.DefaultView;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            adminController = new Controllers.AdminController();
            update_view();
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            Models.Hospital hospital = new Models.Hospital(Convert.ToInt32(id_txt.Text), name_txt.Text, address_txt.Text, phone_txt.Text);
            adminController.AddHospital(hospital);
            update_view();
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            adminController.RemoveHospital(Convert.ToInt32(id_txt.Text));
            update_view();
        }

        private void save_btn_Click(object sender, RoutedEventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(dt);
            update_view();
        }
    }
}
