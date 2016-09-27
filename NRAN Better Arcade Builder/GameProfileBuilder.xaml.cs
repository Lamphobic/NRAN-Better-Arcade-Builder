﻿using System;
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
            if (openFileDialog.ShowDialog() == true)
            {
                GameLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void EmulatorLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Emulators");
            if (openFileDialog.ShowDialog() == true)
            {
                EmulatorLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void CartidgeArtLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Cartridges");
            if (openFileDialog.ShowDialog() == true)
            {
                CartridgeArtLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void GameImageLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Roms");
            if (openFileDialog.ShowDialog() == true)
            {
                GameImageLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void VertCabArtFrontLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Arcades");
            if (openFileDialog.ShowDialog() == true)
            {
                VertCabArtFrontLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void VertCabArtSideLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Arcades");
            if (openFileDialog.ShowDialog() == true)
            {
                VertCabArtSideLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void SpecCabArtFrontLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Arcades");
            if (openFileDialog.ShowDialog() == true)
            {
                SpecCabArtFrontLinkBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void SpecCabArtSideLinkBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NewRetroArcade\\Content\\Arcades");
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
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (StreamReader readtext = new StreamReader(myStream))
                        {
                            // Insert code to read the stream here.
                            GameNameBox.Text = readtext.ReadLine();
                            GameLinkBox.Text = readtext.ReadLine();
                            EmulatorLinkBox.Text = readtext.ReadLine();
                            VolumeBox.Text = readtext.ReadLine();
                            CartridgeArtLinkBox.Text = readtext.ReadLine();
                            comboBox.SelectedItem = readtext.ReadLine();
                            GameImageLinkBox.Text = readtext.ReadLine();
                            VertCabArtFrontLinkBox.Text = readtext.ReadLine();
                            VertCabArtSideLinkBox.Text = readtext.ReadLine();
                            SpecCabArtFrontLinkBox.Text = readtext.ReadLine();
                            SpecCabArtSideLinkBox.Text = readtext.ReadLine();
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
            SaveFileDialog openFileDialog = new SaveFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (StreamReader readtext = new StreamReader(myStream))
                        {
                            // Insert code to read the stream here.
                            GameNameBox.Text = readtext.ReadLine();
                            GameLinkBox.Text = readtext.ReadLine();
                            EmulatorLinkBox.Text = readtext.ReadLine();
                            VolumeBox.Text = readtext.ReadLine();
                            CartridgeArtLinkBox.Text = readtext.ReadLine();
                            comboBox.SelectedItem = readtext.ReadLine();
                            GameImageLinkBox.Text = readtext.ReadLine();
                            VertCabArtFrontLinkBox.Text = readtext.ReadLine();
                            VertCabArtSideLinkBox.Text = readtext.ReadLine();
                            SpecCabArtFrontLinkBox.Text = readtext.ReadLine();
                            SpecCabArtSideLinkBox.Text = readtext.ReadLine();
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
}
