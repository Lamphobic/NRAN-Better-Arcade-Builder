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

namespace NRAN_Better_Arcade_Builder
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

        private void button_Click(object sender, RoutedEventArgs e)//Build Game
        {
            ArcadeProfileBuilder winOpen = new ArcadeProfileBuilder();
            winOpen.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)//Build Arcade
        {
            GameProfileBuilder winOpen = new GameProfileBuilder();
            winOpen.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)//Build Music
        {
            MusicProfileBuilder winOpen = new MusicProfileBuilder();
            winOpen.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)//Build Video
        {
            VideoProfileBuilder winOpen = new VideoProfileBuilder();
            winOpen.Show();
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)//Select and Use Profile
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
