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

namespace Thumper_Custom_Level_Editor_WPF.Controls
{
    /// <summary>
    /// Interaction logic for TitleBar.xaml
    /// </summary>
    public partial class TitleBar : UserControl
    {
        public event EventHandler UserControlClicked;

        public TitleBar()
        {
            InitializeComponent();
        }

        public void AddPanel(object sender, EventArgs e)
        {
            if (UserControlClicked != null) {
                UserControlClicked(this, EventArgs.Empty);
            }
        }
    }
}
