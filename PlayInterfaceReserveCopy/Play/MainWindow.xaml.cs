using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Play
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private bool VolumeOFF = false;

        public void Close_Window(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        public void Small_Window(object sender, MouseButtonEventArgs e)
        {

        }
        public void Down_Window(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }
        public void Drag_Window(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        public void Prev(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Prev!");
        }
        public void Play(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Play!");
        }
        public void Pause(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Pause!");
        }
        public void Stop(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Stop!");
        }
        public void Next(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Next!");
        }
        public void Volume_Push_Reaction(object sender, MouseButtonEventArgs e)
        {
            VolumeOFF = !VolumeOFF;
            if (VolumeOFF)
            {
                Volume_Push_OFF.Opacity = 1;
                Volume_Push_ON.Opacity = 0;
            }
            else
            {
                Volume_Push_OFF.Opacity = 0;
                Volume_Push_ON.Opacity = 1;
            }
        }        
    }
}
