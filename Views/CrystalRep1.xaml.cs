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
using CrystalDecisions.Shared;

namespace ZIASystem.Views
{
    /// <summary>
    /// Interaction logic for CrystalRep1.xaml
    /// </summary>
    public partial class CrystalRep1 : Window
    {
        FORM1 CR;
        public CrystalRep1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CR.SetParameterValue(0, Cmbbox.Text);
            Crys.ViewerCore.ReportSource = CR;
        }

        private void CrystalReportsViewer_Loaded(object sender, RoutedEventArgs e)
        {
            CR = new FORM1();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                Cmbbox.Items.Add(v.Value);
        }
    }
}
