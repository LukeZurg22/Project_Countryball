using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Diagnostics;
using System.Reflection;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace CountryBallProject
{
    public class ExportHandler
    {
        public void ExportFrameToImage(Grid grid)
        {
            var h = grid.ActualHeight;
            var w = grid.ActualWidth;
            var windowMain = (MainWindow)Application.Current.MainWindow;

            var dlg = new SaveFileDialog();
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            dlg.DefaultExt = "png";
            dlg.FilterIndex = 2;
            dlg.FileName = ("BALL_" + windowMain.MainCustomizer.HatSelector.Text + "_" + windowMain.MainCustomizer.EyeSelector.Text + "_" + windowMain.MainCustomizer.StyleSelector.Text).Replace(".png", "");
            dlg.RestoreDirectory = true;

            // Display OpenFileDialog by calling ShowDialog method 
            bool? result = dlg.ShowDialog();
            string path = dlg.FileName;
            int selectedFilterIndex = dlg.FilterIndex;

            if (result == true)
            {
                try
                {
                    var renderBitmap = new RenderTargetBitmap((int)grid.ActualWidth, (int)grid.ActualHeight, 96d, 96d, PixelFormats.Pbgra32);
                    // needed otherwise the image output is black
                    //grid.Measure(new Size((int)grid.ActualWidth, (int)grid.ActualHeight));
                    grid.Arrange(new Rect(new Size((int)grid.ActualWidth, (int)grid.ActualHeight)));
                    renderBitmap.Render(grid);
                    BitmapEncoder imageEncoder = new PngBitmapEncoder();
                    if (selectedFilterIndex == 0)
                    {

                    }
                    else if (selectedFilterIndex == 1)
                    {
                        imageEncoder = new JpegBitmapEncoder();
                    }
                    else if (selectedFilterIndex == 2)
                    {
                        imageEncoder = new PngBitmapEncoder();
                    }
                    else if (selectedFilterIndex == 3)
                    {
                        imageEncoder = new JpegBitmapEncoder();
                    }
                    else if (selectedFilterIndex == 4)
                    {
                        imageEncoder = new GifBitmapEncoder();
                    }
                    imageEncoder.Frames.Add(BitmapFrame.Create(renderBitmap));
                    using (var file = File.Create(path))
                    {
                        imageEncoder.Save(file);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        public void ExportAllFramesToImage(Grid grid)
        {
            var windowMain = (MainWindow)Application.Current.MainWindow;
            var assemblyPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var eyesSource = assemblyPath + "\\Assets\\Eyes\\";


            var dlg = new CommonOpenFileDialog
            {
                Title = "Select Output Folder for Countryball Frames",
                IsFolderPicker = true,

                AddToMostRecentlyUsedList = false,
                AllowNonFileSystemItems = false,
                EnsureFileExists = true,
                EnsurePathExists = true,
                EnsureReadOnly = false,
                EnsureValidNames = true,
                Multiselect = false,
                ShowPlacesList = true
            };

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                try
                {
                    var firstSelectedEyes = "NEUTRAL.png";
                    foreach (var item in windowMain.MainCustomizer.EyeSelector.Items)
                    {
                        windowMain.MainCustomizer.EyeSelector.SelectedItem = item;
                        windowMain.Eyes.Source = new BitmapImage(new Uri(eyesSource + item.ToString()));

                        if (windowMain.Eyes != null)
                        {
                            var fileName = eyesSource;

                            windowMain.Eyes.Source = new BitmapImage(new Uri(fileName + item.ToString()));
                        }
                        windowMain.BallGrid.UpdateLayout();


                        var renderBitmap = new RenderTargetBitmap((int)grid.ActualWidth, (int)grid.ActualHeight, 96d, 96d, PixelFormats.Pbgra32);
                        // needed otherwise the image output is black
                        //grid.Measure(new Size((int)grid.ActualWidth, (int)grid.ActualHeight));
                        grid.Arrange(new Rect(new Size((int)grid.ActualWidth, (int)grid.ActualHeight)));
                        renderBitmap.Render(grid);
                        BitmapEncoder imageEncoder = new PngBitmapEncoder();


                        var exportedFile = dlg.FileName + "\\" +
                            ("BALL_" + windowMain.MainCustomizer.HatSelector.Text +
                            "_" + windowMain.MainCustomizer.EyeSelector.Text + "_" +
                            windowMain.MainCustomizer.StyleSelector.Text).Replace(".png", "") + ".png";
                        imageEncoder = new PngBitmapEncoder();
                        imageEncoder.Frames.Add(BitmapFrame.Create(renderBitmap));
                        using (var file = File.Create(exportedFile))
                        {
                            imageEncoder.Save(file);
                        }

                    }

                    windowMain.MainCustomizer.EyeSelector.SelectedItem = firstSelectedEyes;
                    windowMain.Eyes.Source = new BitmapImage(new Uri(eyesSource + firstSelectedEyes.ToString()));

                    if (windowMain.Eyes != null)
                    {
                        var fileName = eyesSource;

                        windowMain.Eyes.Source = new BitmapImage(new Uri(fileName + firstSelectedEyes.ToString()));
                    }
                    windowMain.BallGrid.UpdateLayout();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }

        }

    }
}

