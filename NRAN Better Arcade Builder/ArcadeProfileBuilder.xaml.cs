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
using System.Windows.Shapes;

namespace NRAN_Better_Arcade_Builder
{
    /// <summary>
    /// Interaction logic for ArcadeProfileBuilder.xaml
    /// </summary>
    public partial class ArcadeProfileBuilder : Window
    {
        public ArcadeProfileBuilder()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)//Back
        {
            MainWindow winOpen = new MainWindow();
            winOpen.Show();
            this.Close();
        }
    }
}
