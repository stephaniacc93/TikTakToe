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

namespace TikTakToe.Controls
{
    /// <summary>
    /// Interaction logic for SpaceControl.xaml
    /// </summary>
    public partial class SpaceControl : UserControl
    {
        public bool IsUsed { get; set; }
        public string Owner { get; set; }

        public SpaceControl(bool isUsed, string owner)
        {
            InitializeComponent();
            IsUsed = isUsed;
            Owner = owner;
        }

        public SpaceControl()
        {
            InitializeComponent();
        }

        private void SpaceButton_OnClick(object sender, RoutedEventArgs e)
        {
            OnSpaceClientClicked(this);
        }

        public void SetDecisionPlayer()
        {
            IsUsed = true;
            Owner = "Player";

            string imageUrl = "../../Images/X.png";
            ImageSourceConverter converter = new ImageSourceConverter();
            this.SpaceImage.Source = (ImageSource)converter.ConvertFromString(imageUrl);
        }

        public void SetDecisionComputer()
        {
            IsUsed = true;
            Owner = "PC";

            string imageUrl = "../../Images/O.png";
            ImageSourceConverter converter = new ImageSourceConverter();
            this.SpaceImage.Source = (ImageSource)converter.ConvertFromString(imageUrl);
        }

        public delegate void SpaceClickedHandler(object o);
        public event SpaceClickedHandler SpaceClicked;
        public void OnSpaceClientClicked(object o)
        {
            if (SpaceClicked != null)
            {
                SpaceClicked(o);
            }
        }
    }
}
