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

namespace TorG.Assets.User_Controls
{
    /// <summary>
    /// Interaction logic for GameBoxControl.xaml
    /// </summary>
    public partial class GameBoxControl : UserControl
    {
        public event EventHandler<EventArgs> Click;

        public string GameName
        {
            get { return (string)GetValue(GameNameProperty); }
            set { SetValue(GameNameProperty, value); }
        }

        public static readonly DependencyProperty GameNameProperty =
            DependencyProperty.Register("GameName", typeof(string), typeof(GameBoxControl));

        public string MainPhoto
        {
            get { return (string)GetValue(MainPhotoProperty); }
            set { SetValue(MainPhotoProperty, value); }
        }

        public static readonly DependencyProperty MainPhotoProperty =
            DependencyProperty.Register("MainPhoto", typeof(string), typeof(GameBoxControl));

        public string SmallDescription
        {
            get { return (string)GetValue(SmallDescriptionProperty); }
            set { SetValue(SmallDescriptionProperty, value); }
        }

        public static readonly DependencyProperty SmallDescriptionProperty =
            DependencyProperty.Register("SmallDescription", typeof(string), typeof(GameBoxControl));


        public GameBoxControl()
        {
            InitializeComponent();
        }

        private void BuyNow_Click(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(this, EventArgs.Empty);
        }


    }
}
