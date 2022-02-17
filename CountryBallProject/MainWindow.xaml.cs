using Microsoft.Win32;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Windows.Documents;
using System.Windows.Controls;
using Size = System.Windows.Size;
using System.Windows.Threading;

namespace CountryBallProject
{
    //https://stackoverflow.com/questions/65288683/how-to-display-webp-format-image-in-wpf?noredirect=1&lq=1
    ///For alternate, .webp file extensions as flags
    //https://www.codeproject.com/Questions/487114/OpenplusaplusfileplusfromplusResourceplusFolderplu
    ///For getting resource files
    //https://github.com/SixLabors/ImageSharp/tree/main/src
    ///
    //https://stackoverflow.com/questions/1536547/how-to-merge-layers-and-save-as-an-image-in-wpf
    ///Possible merging of final image export
    //https://stackoverflow.com/questions/11624298/how-to-use-openfiledialog-to-select-a-folder
    ///Getting Folder select for the ExportHandler.cs to then export all frames
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


        }
        private void FlagUploadButton_Click(object sender, RoutedEventArgs e)
        {
            var fileExplorer = new OpenFileDialog();
            fileExplorer.Filter = "Image files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png;|All files (*.*)|*.*";
            fileExplorer.RestoreDirectory = false;
            fileExplorer.ShowDialog();
            if (!string.IsNullOrWhiteSpace(fileExplorer.FileName))
            {
                var p = fileExplorer.FileName;
                BallFlag.Source = new BitmapImage(new Uri(p));
            }
        }

        private void ExportFrameButton_Click(object sender, RoutedEventArgs e)
        {
            var exportHandler = new ExportHandler();
            exportHandler.ExportFrameToImage(BallGrid);
        }

        private void ExportAllFrames_Click(object sender, RoutedEventArgs e)
        {
            var exportHandler = new ExportHandler();
            exportHandler.ExportAllFramesToImage(BallGrid);

        }



    }
}
