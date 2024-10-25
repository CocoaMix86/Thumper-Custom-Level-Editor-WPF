using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Thumper_Custom_Level_Editor_WPF.Controls
{
    /// <summary>
    /// Interaction logic for Beeble.xaml
    /// </summary>
    public partial class Beeble : UserControl
    {
        List<string> beebleimages = new() { "beeblehappy", "beebleconfuse", "beeblecool", "beeblederp", "beeblelaugh", "beeblelove", "beeblestare", "beeblethink", "beebletiny" };
        Random beeblerng = new Random();
        DispatcherTimer beebletimer = new DispatcherTimer();

        public Beeble()
        {
            InitializeComponent();
            beebletimer.Tick += new EventHandler(BeebleReset);
            beebletimer.Interval = new TimeSpan(0, 0, 0, 0, 250);
        }

        private void Click_Beeble(object sender, MouseEventArgs e)
        {
            rectColorBG.Visibility = Visibility.Collapsed;
            int i = beeblerng.Next(0, 1001);
            if (i == 1000)
                imageBeeble.Source = new BitmapImage(new Uri(@$"/image assets/beeblegold.png", UriKind.Relative));
            else
                imageBeeble.Source = new BitmapImage(new Uri(@$"/image assets/{beebleimages[i % 9]}.png", UriKind.Relative));
            beebletimer.Start();

        }

        private void BeebleReset(object sender, EventArgs e)
        {
            imageBeeble.Source = new BitmapImage(new Uri(@$"/image assets/beeble.png", UriKind.Relative));
            beebletimer.Stop();
            rectColorBG.Fill = new SolidColorBrush(Color.FromRgb((byte)beeblerng.Next(0, 255), (byte)beeblerng.Next(0, 255), (byte)beeblerng.Next(0, 255)));
            rectColorBG.Visibility = Visibility.Visible;
        }


        private void OnResizeThumbDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (this.ActualWidth >= 10 || (this.ActualWidth < 10 && e.HorizontalChange > 0))
                this.Margin = new Thickness(this.Margin.Left, this.Margin.Top, this.Margin.Right - e.HorizontalChange, this.Margin.Bottom);
            if (this.ActualHeight >= 10 || (this.ActualHeight < 10 && e.VerticalChange > 0))
                this.Margin = new Thickness(this.Margin.Left, this.Margin.Top, this.Margin.Right, this.Margin.Bottom - e.VerticalChange);
        }
    }
}
