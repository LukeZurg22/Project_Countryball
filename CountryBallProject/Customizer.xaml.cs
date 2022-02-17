using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace CountryBallProject
{
    /// <summary>
    /// Interaction logic for Customizer.xaml
    /// </summary>
    public partial class Customizer : UserControl
    {
        public MainWindow MainWindow = (MainWindow)Application.Current.MainWindow;

        public Customizer()
        {
            InitializeComponent();
            LoadExistingData();
        }

        public static DependencyProperty BallBackgroundProperty = DependencyProperty.Register("BallBackground", typeof(Brush), typeof(Customizer));
        public Brush BallBackground
        {
            get => (Brush)GetValue(BallBackgroundProperty);
            set => SetValue(BallBackgroundProperty, value);
        }

        public void LoadExistingData()
        {
            var assemblyPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var hatFiles = Directory.GetFileSystemEntries(assemblyPath + "\\Assets\\Hats\\");
            var eyeFiles = Directory.GetFileSystemEntries(assemblyPath + "\\Assets\\Eyes\\");
            var styleFiles = Directory.GetFileSystemEntries(assemblyPath + "\\Assets\\Styles\\"); //It rhymes!


            //var sr = new StreamReader(filename);
            foreach (var hatItem in hatFiles)
            {
                var hat = Path.GetFileName(hatItem);

                _ = HatSelector.Items.Add(hat);
            }

            foreach (var eyeItem in eyeFiles)
            {
                var eye = Path.GetFileName(eyeItem);

                _ = EyeSelector.Items.Add(eye);
            }

            foreach (var styleItem in styleFiles)
            {
                var style = Path.GetFileName(styleItem);

                _ = StyleSelector.Items.Add(style);
            }
        }

        private void HatSelector_Selected(object sender, RoutedEventArgs e)
        {
            if (MainWindow.Hat != null)
            {
                var assemblyPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var fileName = assemblyPath + "\\Assets\\Hats\\";

                MainWindow.Hat.Source = new BitmapImage(new Uri(fileName + HatSelector.SelectedItem.ToString()));
            }

        }
        private void EyeSelector_Selected(object sender, RoutedEventArgs e)
        {
            if (MainWindow.Eyes != null)
            {
                var assemblyPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var fileName = assemblyPath + "\\Assets\\Eyes\\";

                MainWindow.Eyes.Source = new BitmapImage(new Uri(fileName + EyeSelector.SelectedItem.ToString()));
            }
        }
        
        private void StyleSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainWindow.Style != null)
            {
                var assemblyPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var fileName = assemblyPath + "\\Assets\\Styles\\";
                MainWindow.Style.Source = new BitmapImage(new Uri(fileName + StyleSelector.SelectedItem.ToString()));
            }
        }

        private void BallBackgroundPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            SolidColorBrush brush = new SolidColorBrush(BallBackgroundPicker.SelectedColor.Value);
            BallBackground = brush;
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.BallBackground.Visibility = BackgroundBox.IsChecked == true ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
