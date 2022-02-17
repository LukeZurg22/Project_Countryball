using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace CountryBallProject
{
    public partial class HatManipulation : UserControl
    {
        public MainWindow MainWindow = (MainWindow)Application.Current.MainWindow;
        public Thickness BallFlagDefaultMargins { get; set; }
        public double TransformationDegree = 0.1;
        public HatManipulation()
        {

            InitializeComponent();

            if (MainWindow.BallFlag != null)
            {
                BallFlagDefaultMargins = new Thickness(bottom: MainWindow.BallFlag.Margin.Bottom, left: MainWindow.BallFlag.Margin.Left, top: MainWindow.BallFlag.Margin.Top, right: MainWindow.BallFlag.Margin.Right);
                (MainWindow.BallFlag.RenderTransform as ScaleTransform).ScaleX = 1;
                (MainWindow.BallFlag.RenderTransform as ScaleTransform).ScaleY = 1;
            }
        }



    }
}
