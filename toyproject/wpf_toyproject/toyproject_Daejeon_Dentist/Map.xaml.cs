using MahApps.Metro.Controls;
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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;

namespace toyproject_Daejeon_Dentist
{
    /// <summary>
    /// Map.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Map : MetroWindow
    {
        PointLatLng start;
        PointLatLng end;

        GMapMarker marker;

        List<GMapMarker> Circles = new List<GMapMarker>();
       
        public Map()
        {
            InitializeComponent();

            GoogleMapProvider.Instance.ApiKey = "AIzaSyBrzkoaZ8RCTJdlNgy1gVY6P9EJH1pMsZc";

            gmpLocation.MapProvider = GMapProviders.OpenStreetMap;
            gmpLocation.Position = new PointLatLng(36.339293700187, 127.39093552665);
            gmpLocation.MinZoom = 2;
            gmpLocation.MaxZoom = 17;
            gmpLocation.Zoom = 13;
            gmpLocation.ShowCenter = false;
            gmpLocation.DragButton = MouseButton.Left;
            gmpLocation.Position = new PointLatLng(36.339293700187, 127.39093552665);
            gmpLocation.MouseLeftButtonDown += new MouseButtonEventHandler(gmpLocation_MouseLeftButtonDown);
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private async void serchMap()
        {
            
        }

        private void gmpLocation_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point clikpoint = e.GetPosition(gmpLocation);
            PointLatLng point = gmpLocation.FromLocalToLatLng((int)clikpoint.X, (int)clikpoint.Y);
            GMapMarker marker = new GMapMarker(point);
            marker.Shape = new Ellipse
            {
                Width = 10,
                Height = 10,
                Stroke = Brushes.Red,
                StrokeThickness = 2,
            };

            gmpLocation.Markers.Add(marker);
        }

        private void BtnMapScreen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("지도맵 버튼 클릭");
        }
    }
}
