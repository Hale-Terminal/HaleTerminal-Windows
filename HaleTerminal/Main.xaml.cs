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
using System.Windows.Shapes;

namespace HaleTerminal
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            CommandTextbox.Focusable = false;
            //MainFrame.Navigate(new System.Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }

        private void FrameControl(string pathname)
        {
            MainFrame.Navigate(new System.Uri(pathname, UriKind.RelativeOrAbsolute));
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (CommandTextbox.Focus() & e.Key != Key.Enter)
            {
                return;
            }
            if (e.Key == Key.A || e.Key == Key.B || e.Key == Key.C || e.Key == Key.D || e.Key == Key.E || e.Key == Key.F || e.Key == Key.G || e.Key == Key.H || e.Key == Key.I || e.Key == Key.J || e.Key == Key.K || e.Key == Key.L || e.Key == Key.M || e.Key == Key.N || e.Key == Key.O || e.Key == Key.P || e.Key == Key.Q || e.Key == Key.R || e.Key == Key.S || e.Key == Key.T || e.Key == Key.U || e.Key == Key.V || e.Key == Key.W || e.Key == Key.X || e.Key == Key.Y || e.Key == Key.Z)
            {
                //Caret.Visibility = Visibility.Visible;
                //double loc = Canvas.GetLeft(Caret);
                //loc += 11.6;
                //Canvas.SetLeft(Caret, loc);
                CommandTextbox.Text += e.Key.ToString();
            }
            else
            {
                if (e.Key == Key.Enter)
                {
                    Caret.Visibility = Visibility.Collapsed;
                    parse(CommandTextbox.Text);
                    CommandTextbox.Text = "";

                }
            }
        }

        private void CommandParser(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                parse(CommandTextbox.Text);
            }
        }

        private void parse(string command)
        {
            if (command == null)
            {
                return;
            }
            else
            {
                if (command == "HOME")
                {
                    FrameControl("Pages/Home.xaml");
                }

                if (command == "AAPL")
                {
                    this.Title = "APPLE INC";
                }

                if (command == "ME")
                {
                    FrameControl("Pages/User.xaml");
                }

                else
                {
                    FrameControl("Pages/NoResult.xaml");
                }
            }
        }
    }
}
