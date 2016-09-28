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
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {

        }
    }
}
