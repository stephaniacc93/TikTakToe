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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace TikTakToe
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : MetroContentControl
    {
        private string _difficulty;

        public MenuView()
        {
            InitializeComponent();
        }

        private void Difficulty_OnClick(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            ChangeColorButtons();
            button.Background = Brushes.DeepPink;
            _difficulty = button.Name;
        }

        private void ChangeColorButtons()
        {
            Easy.Background = Brushes.Purple;
            Med.Background = Brushes.Purple;
            Hard.Background = Brushes.Purple;
            Expert.Background = Brushes.Purple;
        }

        private void PlayButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_difficulty))
                OnPlayClientClicked(_difficulty);
            else
            {
                var metroWindow = (MetroWindow) System.Windows.Application.Current.MainWindow;
                metroWindow.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;

                metroWindow.ShowMessageAsync("Seleccione un nivel", "Nivel no seleccionado", MessageDialogStyle.Affirmative, metroWindow.MetroDialogOptions);
            }
        }

        public delegate void PlayClickedHandler(string level);
        public event PlayClickedHandler PlayClicked;
        public void OnPlayClientClicked(string level)
        {
            if (PlayClicked != null)
            {
                PlayClicked(level);
            }
        }
    }
}
