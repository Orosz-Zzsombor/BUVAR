using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;
using System.Security.Cryptography.X509Certificates;

namespace Búvárrobot_bajnoksága
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Gyongy> Gyongyok = new List<Gyongy>();
        public MainWindow()
        {
            InitializeComponent();
            
            File.ReadAllLines("gyongyok.txt").Skip(1).ToList().ForEach(x=> Gyongyok.Add(new Gyongy(x)));
            foreach(var x in Gyongyok)
            {
                EllipsoidVisual3D gyongy3D = new EllipsoidVisual3D();
                gyongy3D.RadiusX = 1;
                gyongy3D.RadiusY = 1;
                gyongy3D.RadiusZ = 1;
                gyongy3D.Center = new Point3D(x.X, x.Y, x.Z);

                gyongy3D.Fill = new SolidColorBrush(Colors.Red);
                ter.Children.Add(gyongy3D);

            }
            
        }
        
        

       
        
    }
}