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
    /// Interaction logic for GameProfileBuilder.xaml
    /// </summary>
    public partial class GameProfileBuilder : Window
    {
        public GameProfileBuilder()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)//Back
        {
            MainWindow winOpen = new MainWindow();
            winOpen.Show();
            this.Close();
        }

        private void GameLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Roms");
            openFileDialog.Filter = "Rom Files (*.gb, *.gbc, *.gba, *.nes, *.sfc, *.zip)|*.gb; *.gbc; *.gba; *.nes; *.sfc; *.zip|Gameboy Roms (*.gb, *.gbc)|*.gb; *.gbc|Gameboy Advanced Roms (*.gba)|*.gba | NES Roms (*.nes)|*.nes|SNES Roms (*.sfc)|*.sfc|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                GameLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void EmulatorLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Emulators");
            openFileDialog.Filter = "dll Files (*.dll)|*.dll|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                EmulatorLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void CartidgeArtLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Cartridges");
            openFileDialog.Filter = "Image Files (*.JPEG, *.PNG, *.BMP, *.DDS)|*.JPEG; *.PNG; *.BMP; *.DDS";
            if (openFileDialog.ShowDialog() == true)
            {
                CartridgeArtLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void GameImageLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Roms");
            openFileDialog.Filter = "Image Files (*.JPEG, *.PNG, *.BMP, *.DDS)|*.JPEG; *.PNG; *.BMP; *.DDS";
            if (openFileDialog.ShowDialog() == true)
            {
                GameImageLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void VertCabArtFrontLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Arcades");
            openFileDialog.Filter = "Image Files (*.JPEG, *.PNG, *.BMP, *.DDS)|*.JPEG; *.PNG; *.BMP; *.DDS";
            if (openFileDialog.ShowDialog() == true)
            {
                VertCabArtFrontLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void VertCabArtSideLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Arcades");
            openFileDialog.Filter = "Image Files (*.JPEG, *.PNG, *.BMP, *.DDS)|*.JPEG; *.PNG; *.BMP; *.DDS";
            if (openFileDialog.ShowDialog() == true)
            {
                VertCabArtSideLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void SpecCabArtFrontLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Arcades");
            openFileDialog.Filter = "Image Files (*.JPEG, *.PNG, *.BMP, *.DDS)|*.JPEG; *.PNG; *.BMP; *.DDS";
            if (openFileDialog.ShowDialog() == true)
            {
                SpecCabArtFrontLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void SpecCabArtSideLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Arcades");
            openFileDialog.Filter = "Image Files (*.JPEG, *.PNG, *.BMP, *.DDS)|*.JPEG; *.PNG; *.BMP; *.DDS";
            if (openFileDialog.ShowDialog() == true)
            {
                SpecCabArtSideLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e) //Load
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
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
                            GameNameBox.Text            = readText.ReadLine();
                            GameLinkBox.Text            = readText.ReadLine();
                            EmulatorLinkBox.Text        = readText.ReadLine();
                            VolumeBox.Text              = readText.ReadLine();
                            CartridgeArtLinkBox.Text    = readText.ReadLine();
                            comboBox.SelectedItem       = readText.ReadLine();
                            GameImageLinkBox.Text       = readText.ReadLine();
                            VertCabArtFrontLinkBox.Text = readText.ReadLine();
                            VertCabArtSideLinkBox.Text  = readText.ReadLine();
                            SpecCabArtFrontLinkBox.Text = readText.ReadLine();
                            SpecCabArtSideLinkBox.Text  = readText.ReadLine();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            
        }

        private void button2_Click(object sender, RoutedEventArgs e) //Save
        {
            Stream myStream = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            saveFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile";
            saveFileDialog.DefaultExt = "gameprofile";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    if ((myStream = saveFileDialog.OpenFile()) != null)
                    {
                        using (StreamWriter writeText = new StreamWriter(myStream))
                        {
                            // Insert code to write the stream here.
                            writeText.WriteLine(GameNameBox.Text);
                            writeText.WriteLine(GameLinkBox.Text);
                            writeText.WriteLine(EmulatorLinkBox.Text);
                            writeText.WriteLine(VolumeBox.Text);
                            writeText.WriteLine(CartridgeArtLinkBox.Text);
                            writeText.WriteLine(comboBox.SelectedItem);
                            writeText.WriteLine(GameImageLinkBox.Text);
                            writeText.WriteLine(VertCabArtFrontLinkBox.Text);
                            writeText.WriteLine(VertCabArtSideLinkBox.Text);
                            writeText.WriteLine(SpecCabArtFrontLinkBox.Text);
                            writeText.WriteLine(SpecCabArtSideLinkBox.Text);
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
