using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Layout;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
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
using System.Xml.Linq;
using Thumper_Custom_Level_Editor_WPF.Editor_Panels;

namespace Thumper_Custom_Level_Editor_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void DockPanel(object sender, EventArgs e)
        {
            /*
            if (panelLeaf.Parent.GetType() == typeof(Canvas))
                (panelLeaf.Parent as Canvas).Children.Remove(panelLeaf);
            else
                (panelLeaf.Parent as Grid).Children.Remove(panelLeaf);
            Dock2.Children.Add(panelLeaf);
            Grid.SetRow(panelLeaf, 0);
            Grid.SetColumn(panelLeaf, 2);
            panelLeaf.Width = Double.NaN;
            panelLeaf.Height = Double.NaN;
            panelLeaf.RenderTransform = null;
            */
        }

        void AddPanel(object sender, EventArgs e)
        {
            LeafEditor leafy = new LeafEditor();
            Interaction.GetBehaviors(leafy).Add(new MouseDragElementBehavior() { ConstrainToParentBounds = true});
            UndockedPanels.Children.Add(leafy);
            leafy.Margin = new Thickness(600, 300, 600, 300);
        }
    }
}