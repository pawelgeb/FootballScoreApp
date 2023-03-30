using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
using FootballStatics;

namespace FootballScoreWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FootballScoreStatics score = new FootballScoreStatics();     
        }

        private void OpenNewWindow(object sender, RoutedEventArgs e)
        {
            ScoreWindow scoreWindow = new ScoreWindow();
            scoreWindow.Show();
        }
    }
}
