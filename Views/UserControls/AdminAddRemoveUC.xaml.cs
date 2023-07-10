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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ZIASystem.Views.UserControls
{
    /// <summary>
    /// Interaction logic for AdminAddRemoveUC.xaml
    /// </summary>
    public partial class AdminAddRemoveUC : UserControl
    {
        private Controllers.AdminController adminController;
        public AdminAddRemoveUC()
        {
            InitializeComponent();
        }

        private void update_view()
        {
            Controllers.AdminController adminController = new Controllers.AdminController();
            OracleDataAdapter adapter = adminController.getCompanies();
            DataTable dt = new DataTable();
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
            Models.Company company = new Models.Company(Convert.ToInt32(id_txt.Text), name_txt.Text, address_txt.Text);
            adminController.AddCompany(company);
            update_view();
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            adminController.RemoveCompany(Convert.ToInt32(id_txt.Text));
            update_view();
        }
    }
}
