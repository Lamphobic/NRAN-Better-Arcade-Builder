using System;
using System.IO;
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
using Microsoft.Win32;

namespace NRAN_Better_Arcade_Builder
{
    /// <summary>
    /// Interaction logic for MusicProfileBuilder.xaml
    /// </summary>
    public partial class MusicProfileBuilder : Window
    {
        public MusicProfileBuilder()
        {
            InitializeComponent();
        }

        private void backButtonMusic_Click(object sender, RoutedEventArgs e)
        {
            MainWindow winOpen = new MainWindow();
            winOpen.Show();
            this.Close();
        }

        private void MusicLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Roms");
            if (openFileDialog.ShowDialog() == true)
            {
                MusicLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void button1Music_Click(object sender, RoutedEventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Music Profiles (*.musicprofile)|*.musicprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (StreamReader readText = new StreamReader(myStream))
                        {
                            // Insert code to read the stream here.
                            MusicNameBox.Text = readText.ReadLine();
                            MusicLinkBox.Text = readText.ReadLine();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button2Music_Click(object sender, RoutedEventArgs e)
        {
            Stream myStream = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            saveFileDialog.Filter = "Music Profiles (*.musicprofile)|*.musicprofile";
            saveFileDialog.DefaultExt = "musicprofile";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    if ((myStream = saveFileDialog.OpenFile()) != null)
                    {
                        using (StreamWriter writeText = new StreamWriter(myStream))
                        {
                            // Insert code to write the stream here.
                            writeText.WriteLine(MusicNameBox.Text);
                            writeText.WriteLine(MusicLinkBox.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
