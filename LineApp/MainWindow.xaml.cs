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

namespace LineApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDrawLine_Click(object sender, RoutedEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            myLine.X1 = 1;
            myLine.X2 = 250;
            myLine.Y1 = 1;
            myLine.Y2 = 150;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 8;
            mainGrid.Children.Add(myLine);
        }

        private void btnDrawRectangle_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rec = new Rectangle();
            rec.Fill = System.Windows.Media.Brushes.DarkCyan;
            rec.Stroke = System.Windows.Media.Brushes.LightGreen;
            rec.Height = 200;
            rec.Width = 300;
            rec.StrokeThickness = 8;
            mainGrid.Children.Add(rec);
        }

        private void btnDrawEllipse_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Height = 300;
            ellipse.Width = 100;
            ellipse.Fill = Brushes.DarkKhaki;
            ellipse.Stroke = Brushes.DarkOrange;
            ellipse.StrokeThickness = 8;
            mainGrid.Children.Add(ellipse);
        }

        private void btnDrawSquare_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = 300;
            rectangle.Width = 300;
            rectangle.Fill = Brushes.Gold;
            rectangle.Stroke = Brushes.DarkViolet;
            rectangle.StrokeThickness = 8;
            mainGrid.Children.Add(rectangle);
        }
        
        private void btnDrawPolygon(object sender, RoutedEventArgs e)
        {
            SolidColorBrush YellowBrush = new SolidColorBrush();
            YellowBrush.Color = Colors.Yellow;
            SolidColorBrush BlackBrush = new SolidColorBrush();
            BlackBrush.Color = Colors.Black;

            Polygon YellowPolygon = new Polygon();
            YellowPolygon.Fill = YellowBrush;
            YellowPolygon.Stroke = BlackBrush;
            YellowPolygon.StrokeThickness = 8;

            System.Windows.Point point1 = new System.Windows.Point(80, 150);
            System.Windows.Point point2 = new System.Windows.Point(250, 150);
            System.Windows.Point point3 = new System.Windows.Point(280, 220);
            System.Windows.Point point4 = new System.Windows.Point(360, 60);
            PointCollection polygonPoints = new PointCollection();
            polygonPoints.Add(point1);
            polygonPoints.Add(point2);
            polygonPoints.Add(point3);
            polygonPoints.Add(point4);

            YellowPolygon.Points = polygonPoints;

            mainGrid.Children.Add(YellowPolygon);
        }

        private void btnDrawCircle_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Height = 500;
            ellipse.Width = 500;
            ellipse.Fill = Brushes.DarkGoldenrod;
            ellipse.Stroke = Brushes.DarkBlue;
            ellipse.StrokeThickness = 8;
            mainGrid.Children.Add(ellipse);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Children.Clear();
        }

        private void btnImageShow_Click(object sender, RoutedEventArgs e)
        {
            Image Myimage = new Image();
            Myimage.Source = new BitmapImage(new Uri(@"\Image\Monika.jpg", UriKind.Relative));
            
        }
    }
}
