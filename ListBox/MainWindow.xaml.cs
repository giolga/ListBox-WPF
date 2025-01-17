﻿using System;
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

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 65 });
            matches.Add(new Match() { Team1 = "Goris Dila", Team2 = "Dinamo Tbilisi", Score1 = 1, Score2 = 6, Completion = 42 });
            matches.Add(new Match() { Team1 = "Brazil", Team2 = "Spain", Score1 = 1, Score2 = 1, Completion = 47 });
            matches.Add(new Match() { Team1 = "Man United", Team2 = "La Galaxy", Score1 = 1, Score2 = 1, Completion = 34 });

            LBMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(LBMatches.SelectedItem != null)
            {
                MessageBox.Show($"Selected match {(LBMatches.SelectedItem as Match).Team1} {(LBMatches.SelectedItem as Match).Score1} {(LBMatches.SelectedItem as Match).Score2} {(LBMatches.SelectedItem as Match).Team2}");
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }
    }
}
