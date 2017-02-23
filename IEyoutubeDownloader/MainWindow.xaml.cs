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

namespace IEyoutubeDownloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<youtubePreview> ytItemsList = new List<youtubePreview>();
            ytItemsList.Add(new youtubePreview());
            ytItemsList.Add(new youtubePreview());
            ytItemsList.Add(new youtubePreview());
            ytItemsList.Add(new youtubePreview());
            ytItemsList.Add(new youtubePreview());
            itemcontrolYT.ItemsSource = ytItemsList;

        }
    }
}
