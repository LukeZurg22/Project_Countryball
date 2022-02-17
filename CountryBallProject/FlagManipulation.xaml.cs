using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace CountryBallProject
{
    public partial class FlagManipulation : UserControl
    {
        public MainWindow MainWindow = (MainWindow)Application.Current.MainWindow;
        public Thickness BallFlagDefaultMargins { get; set; }
        public double TransformationDegree = 0.1;
        public FlagManipulation()
        {

            InitializeComponent();

            if (MainWindow.BallFlag != null)
            {
                BallFlagDefaultMargins = new Thickness(bottom: MainWindow.BallFlag.Margin.Bottom, left: MainWindow.BallFlag.Margin.Left, top: MainWindow.BallFlag.Margin.Top, right: MainWindow.BallFlag.Margin.Right);
                (MainWindow.BallFlag.RenderTransform as ScaleTransform).ScaleX = 1;
                (MainWindow.BallFlag.RenderTransform as ScaleTransform).ScaleY = 1;
            }
        }



        private void FlagMoverLeft_Click(object sender, RoutedEventArgs e)
        {
            var left = MainWindow.BallFlag.Margin.Left;
            var top = MainWindow.BallFlag.Margin.Top;
            var bottom = MainWindow.BallFlag.Margin.Bottom;
            var right = MainWindow.BallFlag.Margin.Right;

            if (Keyboard.IsKeyDown(Key.LeftShift))
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left - 20, Top = top, Bottom = bottom, Right = right };
            }
            else if (Keyboard.IsKeyDown(Key.LeftAlt))
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left - 10, Top = top, Bottom = bottom, Right = right };
            }
            else
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left - 1, Top = top, Bottom = bottom, Right = right };
            }
        }

        private void FlagMoverRight_Click(object sender, RoutedEventArgs e)
        {
            var left = MainWindow.BallFlag.Margin.Left;
            var top = MainWindow.BallFlag.Margin.Top;
            var bottom = MainWindow.BallFlag.Margin.Bottom;
            var right = MainWindow.BallFlag.Margin.Right;

            if (Keyboard.IsKeyDown(Key.LeftShift))
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left + 20, Top = top, Bottom = bottom, Right = right };
            }
            else if (Keyboard.IsKeyDown(Key.LeftAlt))
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left + 10, Top = top, Bottom = bottom, Right = right };
            }
            else
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left + 1, Top = top, Bottom = bottom, Right = right };
            }
        }

        private void FlagMoverUp_Click(object sender, RoutedEventArgs e)
        {
            var left = MainWindow.BallFlag.Margin.Left;
            var top = MainWindow.BallFlag.Margin.Top;
            var bottom = MainWindow.BallFlag.Margin.Bottom;
            var right = MainWindow.BallFlag.Margin.Right;

            if (Keyboard.IsKeyDown(Key.LeftShift))
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left, Top = top - 20, Bottom = bottom, Right = right };
            }
            else if (Keyboard.IsKeyDown(Key.LeftAlt))
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left, Top = top - 10, Bottom = bottom, Right = right };
            }
            else
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left, Top = top - 1, Bottom = bottom, Right = right };
            }
        }

        private void FlagMoverDown_Click(object sender, RoutedEventArgs e)
        {
            var left = MainWindow.BallFlag.Margin.Left;
            var top = MainWindow.BallFlag.Margin.Top;
            var bottom = MainWindow.BallFlag.Margin.Bottom;
            var right = MainWindow.BallFlag.Margin.Right;

            if (Keyboard.IsKeyDown(Key.LeftShift))
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left, Top = top + 20, Bottom = bottom, Right = right };
            }
            else if (Keyboard.IsKeyDown(Key.LeftAlt))
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left, Top = top + 10, Bottom = bottom, Right = right };
            }
            else
            {
                MainWindow.BallFlag.Margin = new Thickness
                { Left = left, Top = top + 1, Bottom = bottom, Right = right };
            }
        }

        private void FlagReset_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.BallFlag.Margin = BallFlagDefaultMargins;
        }

        private void FlagExpandSize_Click(object sender, RoutedEventArgs e)
        {

            var FlagScale = (ScaleTransform)((TransformGroup)MainWindow.BallFlag.RenderTransform).Children[0];
            FlagScale.ScaleX = FlagScale.ScaleX + TransformationDegree;
            FlagScale.ScaleY = FlagScale.ScaleY + TransformationDegree;
        }

        private void FlagCompressSize_Click(object sender, RoutedEventArgs e)
        {
            var FlagScale = (ScaleTransform)((TransformGroup)MainWindow.BallFlag.RenderTransform).Children[0];
            FlagScale.ScaleX = FlagScale.ScaleX - TransformationDegree;
            FlagScale.ScaleY = FlagScale.ScaleY - TransformationDegree;

        }

        private void FlagIncreaseHeight_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.BallFlag.Height += 5;
        }

        private void FlagDecreaseHeight_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.BallFlag.Height -= 5;

        }

        private void FlagIncreaseWidth_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.BallFlag.Width += 5;
        }

        private void FlagDecreaseWidth_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.BallFlag.Width -= 5;
        }
    }
}
