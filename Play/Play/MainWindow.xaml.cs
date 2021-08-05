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
using System.Windows.Threading;

namespace Play
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool VolumeOFF = false;
        private int Volume_Arg = 0;
        private int Song_Arg = 0;
        private DispatcherTimer t = new DispatcherTimer();
        private int SongSize = 0;
        private int SongSizeMin = 0;
        private int SongSizeSec = 0;

        public MainWindow()
        {
            InitializeComponent();
            SongSize = 183;
            this.SongIndicator.Maximum = SongSize;
            SongSizeSec = 0;
            SongSizeMin = 0;
            Volume_Arg = 0;
            t.Interval = new TimeSpan(0, 0, 1);
            t.Tick += new EventHandler(t_Tick);
        }

        private void t_Tick(object sender, EventArgs e)
        {
            Song_Arg += 1;
            SongSizeSec += 1;
            if (SongSizeSec >= 60)
            {
                SongSizeMin = Song_Arg / 60;
                SongSizeSec = Song_Arg - SongSizeMin;
            }
            
            this.SongIndicator.Value = Song_Arg;
            this.Time.Content = SongSizeMin + ":" + SongSizeSec;
        }

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
            this.SongIndicator.Value = 0;
        }
        public void Play(object sender, MouseButtonEventArgs e)
        {
            t.Start();
        }
        public void Pause(object sender, MouseButtonEventArgs e)
        {
            t.Stop();
        }
        public void Stop(object sender, MouseButtonEventArgs e)
        {
            t.Stop();
            this.SongIndicator.Value = 0;
        }
        public void Next(object sender, MouseButtonEventArgs e)
        {
            this.SongIndicator.Value = 0;
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
        public void SongPositionUpM(object sender, MouseButtonEventArgs e)
        {
            t.Start();
        }
        public void SongPositionDownM(object sender, MouseButtonEventArgs e)
        {
            t.Stop();
        }
        public void SongPositionInst(object sender, MouseEventArgs e)
        {
            Song_Arg = (int)(this.SongIndicator.Value);
            SongSizeMin = Song_Arg / 60;
            SongSizeSec = Song_Arg - SongSizeMin;
        }
    }
}
