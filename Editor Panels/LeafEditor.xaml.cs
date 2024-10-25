using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Thumper_Custom_Level_Editor_WPF.Editor_Panels
{
    /// <summary>
    /// Interaction logic for LeafEditor.xaml
    /// </summary>
    public partial class LeafEditor : UserControl
    {
        private Cursor _cursor;
        public LeafEditor()
        {
            InitializeComponent();
        }
        /*
        private void OnResizeThumbDragStarted(object sender, DragStartedEventArgs e)
        {
            _cursor = Cursor;
            Cursor = Cursors.SizeNWSE;
        }

        private void OnResizeThumbDragCompleted(object sender, DragCompletedEventArgs e)
        {
            Cursor = _cursor;
        }*/

        private void OnResizeThumbDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (this.ActualWidth >= 150 || (this.ActualWidth < 150 && e.HorizontalChange > 0))
                this.Margin = new Thickness(this.Margin.Left, this.Margin.Top, this.Margin.Right - e.HorizontalChange, this.Margin.Bottom);
            if (this.ActualHeight >= 150 || (this.ActualHeight < 150 && e.VerticalChange > 0))
                this.Margin = new Thickness(this.Margin.Left, this.Margin.Top, this.Margin.Right, this.Margin.Bottom - e.VerticalChange);
        }
    }
}
