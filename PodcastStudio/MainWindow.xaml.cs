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

namespace PodcastStudio
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

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            ChangeSingalStatus(Signal1, e, Key.D1, Key.NumPad1);
            ChangeSingalStatus(Signal2, e, Key.D2, Key.NumPad2);
            ChangeSingalStatus(Signal3, e, Key.D3, Key.NumPad3);
            ChangeSingalStatus(Signal4, e, Key.D4, Key.NumPad4);
        }

        private void ChangeSingalStatus(Ellipse signal, KeyEventArgs e, Key requesteKey, Key alternativeKey)
        {
            if (e.Key == requesteKey || e.Key == alternativeKey)
            {
                signal.Visibility = signal.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }
        }
    }
}
