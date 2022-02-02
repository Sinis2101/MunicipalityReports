using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MunicipalityReports.model;

namespace MunicipalityReports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MR mr;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFileDialog(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog() == true)
            {
                String[] lines = File.ReadAllLines(fileDialog.FileName);
                addMunicipalities(lines);
            }
        }

        private void addMunicipalities(String[] lines)
        {
            foreach (String line in lines)
            {
                mr.addMunicipality(line);
            }
        }
    }
}
