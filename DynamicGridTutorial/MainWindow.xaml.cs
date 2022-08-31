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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DynamicGridTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Grid DynamicGrid;

        public MainWindow()
        {
            InitializeComponent();
            CreateGrid();
        }
        private void CreateGrid()
        {
            DynamicGrid = new Grid();
            DynamicGrid.Width = 400;
            DynamicGrid.HorizontalAlignment = HorizontalAlignment.Left;
            DynamicGrid.VerticalAlignment = VerticalAlignment.Top;
            DynamicGrid.ShowGridLines = true;
            DynamicGrid.Background = new SolidColorBrush(Colors.LightSeaGreen);
            
            CreateColumns();
        }
        private void CreateColumns()
        {
            ColumnDefinition gridCol1 = new ColumnDefinition();
            ColumnDefinition gridCol2 = new ColumnDefinition();
            ColumnDefinition gridCol3 = new ColumnDefinition();

            DynamicGrid.ColumnDefinitions.Add(gridCol1);
            DynamicGrid.ColumnDefinitions.Add(gridCol2);
            DynamicGrid.ColumnDefinitions.Add(gridCol3);

            CreateRows();
        }
        private void CreateRows()
        {
            RowDefinition gridRow1 = new RowDefinition();
            gridRow1.Height = new GridLength(45);

            RowDefinition gridRow2 = new RowDefinition();
            gridRow2.Height = new GridLength(45);

            RowDefinition gridRow3 = new RowDefinition();
            gridRow3.Height = new GridLength(45);

            DynamicGrid.RowDefinitions.Add(gridRow1);
            DynamicGrid.RowDefinitions.Add(gridRow2);
            DynamicGrid.RowDefinitions.Add(gridRow3);
        }
    }
}
