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
using MahApps.Metro.Controls;

namespace TikTakToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        MenuView _menuView = new MenuView();
        GameView _gameView = new GameView();
        public MainWindow()
        {
            InitializeComponent();
            ScrollViewer.Content = _menuView;
            _menuView.PlayClicked += _menuView_PlayClicked;
        }

        void _menuView_PlayClicked()
        {
            ScrollViewer.Content = _gameView;
        }
    }
}
