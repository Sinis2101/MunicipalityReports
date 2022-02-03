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
using LiveCharts;
using LiveCharts.Wpf;
using MunicipalityReports.model;

namespace MunicipalityReports
{
    /// <summary>
    /// Interaction logic for ChartWindow.xaml
    /// </summary>
    public partial class ChartWindow : Window
    {
        private MR mr;
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<int, string> Formatter { get; set; }

        public ChartWindow(MR mr)
        {
            InitializeComponent();

            this.mr = mr;
            mr.getAmountPerType();

            SeriesCollection = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Municipalities",
                    Values = new ChartValues<int> {mr.isla, mr.noMun, mr.municipio }
                }
            };

            Labels = new string[]{"Isla", "Área no municipalizada", "Municipio"};

            Formatter = value => value.ToString("N");

            DataContext = this;
        }
    }
}
