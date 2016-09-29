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

        private void button1_Click(object sender, RoutedEventArgs e) //Read
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Arcade Profiles (*.arcadeprofile)|*.arcadeprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "arcadeprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (StreamReader readText = new StreamReader(myStream))
                        {
                            // Insert code to read the stream here.
                            // Do this after figuring out just how many things there are.
                            // Read into each box from the file.
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
            saveFileDialog.Filter = "Arcade Profiles (*.arcadeprofile)|*.arcadeprofile";
            saveFileDialog.DefaultExt = "arcadeprofile";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    if ((myStream = saveFileDialog.OpenFile()) != null)
                    {
                        using (StreamWriter writeText = new StreamWriter(myStream))
                        {
                            // Insert code to write the stream here.
                            // Do this after figuring out just how many things there are.
                            // Write into file from each box.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n0MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n1MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n2MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n3MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n4MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n5MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n6MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n7MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n8MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n9MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n10MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n11MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n12MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n13MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n14MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n15MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n16MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n17MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n18MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n19MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n20MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n21MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n22MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                n23MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                s1MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                s2MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                s3MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                s4MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                f1MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                f2MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                f3MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                f4MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_32(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                f5MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_33(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                f6MachineBox.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_34(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c1Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_35(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c2Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_36(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c3Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_37(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c4Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_38(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c5Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_39(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c6Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_40(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c7Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_41(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c8Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_42(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c9Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_43(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c10Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_44(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c11Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_45(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c12Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_46(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c13Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_47(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c14Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_48(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c15Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_49(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c16Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_50(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                c17Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_51(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                g1Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_52(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                g2Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_53(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                g3Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_54(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                g4Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_55(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                g5Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_56(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                g6Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_57(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                g7Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_58(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                g8Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_59(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Game Profiles (*.gameprofile)|*.gameprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "gameprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                g9Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_60(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Poster Profiles (*.posterprofile)|*.arprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "posterprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                p2Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_61(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Poster Profiles (*.posterprofile)|*.arprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "posterprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                p2Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_62(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Poster Profiles (*.posterprofile)|*.arprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "posterprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                p2Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_63(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Poster Profiles (*.posterprofile)|*.arprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "posterprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                p2Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_64(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Poster Profiles (*.posterprofile)|*.arprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "posterprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                p2Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_65(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Poster Profiles (*.posterprofile)|*.arprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "posterprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                p2Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_66(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Poster Profiles (*.posterprofile)|*.arprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "posterprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                p2Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_67(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Poster Profiles (*.posterprofile)|*.arprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "posterprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                p2Box.Name = openFileDialog.SafeFileName;
            }
        }

        private void Button_Click_68(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            openFileDialog.Filter = "Poster Profiles (*.posterprofile)|*.arprofile|Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "posterprofile";
            if (openFileDialog.ShowDialog() == true)
            {
                p2Box.Name = openFileDialog.SafeFileName;
            }
        }
    }
}
