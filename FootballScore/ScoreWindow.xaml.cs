using FootballStatics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace FootballScoreWPF
{
    /// <summary>
    /// Interaction logic for ScoreWindow.xaml
    /// </summary>
    public partial class ScoreWindow : Window
    {
        public ScoreWindow()
        {
            InitializeComponent();            
        }
        FootballScoreStatics footballStats = new FootballScoreStatics();

        private void TextBox_TextChanged_HomeTeam(object sender, TextChangedEventArgs e)
        {
            footballStats.HomeTeamName = HomeName.Text;
        }
        private void TextBox_TextChanged_Score(object sender, TextChangedEventArgs e)
        {
            footballStats.Score = Score.Text;
        }
        private void TextBox_TextChanged_AwayTeam(object sender, TextChangedEventArgs e)
        {
            footballStats.AwayTeamName = AwayName.Text;
        }
        private void TextBox_TextChanged_StadiumName(object sender, TextChangedEventArgs e)
        {
            footballStats.StadiumName = StadiumName.Text;
        }

        private void HomeTeamName(object sender, ContextMenuEventArgs e)
        {
            
        }

        private void ScorePublish(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Projects\MQTTapp\SecondApp\MQTTPublisher\MQTTPublisher\bin\Debug\net6.0\MQTTPublisher.exe");
        }
    }
}
