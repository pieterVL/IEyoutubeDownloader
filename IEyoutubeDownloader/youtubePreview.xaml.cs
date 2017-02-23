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
    /// Interaction logic for youtubePreview.xaml
    /// </summary>
    public partial class youtubePreview : UserControl
    {
        public youtubePreview()
        {
            InitializeComponent();
            PreviewMouseLeftButtonUp += (sender, args) => onClick();
            this.txtTitel.Text = "lorem ist imput dat ich nicht ipsum dolor sit amet";
            this.txturl.Text = "azertyuiopqsdfghjklmwxcvbnazertyuiopqsdfghjnb";
            this.lblLength.Content = "3.14";    
        }

        public static readonly RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent(
"Click", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TabItem));

        public event RoutedEventHandler Click
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }                         
        }

        void onClick()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(youtubePreview.ClickEvent);
            RaiseEvent(newEventArgs);
            System.Windows.Forms.MessageBox.Show("Test");
        }

        private void url_block_mouse_enter(object sender, MouseEventArgs e)
        {
            ((TextBlock)sender).Foreground = new SolidColorBrush(Colors.MediumSlateBlue);
        }

        private void url_block_mouse_leave(object sender, MouseEventArgs e)
        {
            ((TextBlock)sender).Foreground = new SolidColorBrush(Colors.Transparent);
        }
    }
}
