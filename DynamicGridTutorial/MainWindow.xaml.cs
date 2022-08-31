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

            CreateFirstColumnHeader();
        }
        private void CreateFirstColumnHeader()
        {
            TextBlock txtBlock1 = new TextBlock();
            txtBlock1.Text = "Author Name";
            txtBlock1.FontSize = 14;
            txtBlock1.FontWeight = FontWeights.Bold;
            txtBlock1.Foreground = new SolidColorBrush(Colors.IndianRed);
            txtBlock1.VerticalAlignment = VerticalAlignment.Top;

            Grid.SetRow(txtBlock1, 0);
            Grid.SetColumn(txtBlock1, 1);

            DynamicGrid.Children.Add(txtBlock1);

            CreateSecondColumnHeader();
        }
        private void CreateSecondColumnHeader()
        {
            TextBlock txtBlock2 = new TextBlock();
            txtBlock2.Text = "Age";
            txtBlock2.FontSize = 14;
            txtBlock2.FontWeight = FontWeights.Bold;
            txtBlock2.Foreground = new SolidColorBrush(Colors.IndianRed);
            txtBlock2.VerticalAlignment = VerticalAlignment.Top;

            Grid.SetRow(txtBlock2, 0);
            Grid.SetColumn(txtBlock2 , 1);

            DynamicGrid.Children.Add(txtBlock2);

            CreateThirdColumnHeader();
        }
        private void CreateThirdColumnHeader()
        {
            TextBlock txtBlock3 = new TextBlock();
            txtBlock3.Text = "Book";
            txtBlock3.FontSize = 14;
            txtBlock3.FontWeight = FontWeights.Bold;
            txtBlock3.Foreground = new SolidColorBrush(Colors.IndianRed);
            txtBlock3 .VerticalAlignment = VerticalAlignment.Top;

            Grid.SetRow(txtBlock3, 0);
            Grid.SetColumn(txtBlock3, 2);

            DynamicGrid.Children.Add(txtBlock3);
        }
    }
}
