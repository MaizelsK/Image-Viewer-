using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Image_Reproduction
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = System.IO.Path.GetFullPath("."),
                Title = "Выберите картинку",
            };

            if (dialog.ShowDialog() == true)
            {
                image.Source = new BitmapImage(new Uri(dialog.FileName));
            }

            imageName.Text = dialog.FileName.Substring(dialog.FileName.LastIndexOf("\\")).Remove(0, 1);
        }
    }
}
