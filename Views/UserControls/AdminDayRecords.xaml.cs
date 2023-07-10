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
    /// Interaction logic for AdminDayRecords.xaml
    /// </summary>
    public partial class AdminDayRecords : UserControl
    {
        Controllers.AdminController AdminController;
        public AdminDayRecords()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            AdminController = new Controllers.AdminController();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = (DateTime)DatePick.SelectedDate;
            Oracle.DataAccess.Client.OracleDataAdapter adapter = AdminController.getDayMedicalRecods(date);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DGrid.ItemsSource = dt.DefaultView;
        }
    }
}
