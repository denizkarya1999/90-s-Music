using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace video_player
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class video_player : Page
    {
        public video_player()
        {
            this.InitializeComponent();
            indicator.Margin = new Thickness(1075, 112, 0, 0);
            player_indicator.Text = "Show Must Go On by Queen (1991)";
        }

        private void Innuendo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            media_player.Source = new Uri("ms-appx:///Assets/show_must_go_on.mp4");
            indicator.Margin = new Thickness(1075, 112, 0, 0);
            player_indicator.Text = "Show Must Go On by Queen (1991)";
        }

        private void freedom_90_Tapped(object sender, TappedRoutedEventArgs e)
        {
            media_player.Source = new Uri("ms-appx:///Assets/freedom_90.mp4");
            indicator.Margin = new Thickness(1075, 216, 0, 0);
            player_indicator.Text = "Freedom 90 by George Micheal (1990)";
        }

        private void rhythm_nation_Tapped(object sender, TappedRoutedEventArgs e)
        {
            media_player.Source = new Uri("ms-appx:///Assets/rhythm_nation.mp4");
            indicator.Margin = new Thickness(1075, 320, 0, 0);
            player_indicator.Text = "Rhythm Nation On by Janet Jackson (1990)";
        }
        private void dangerous_Tapped(object sender, TappedRoutedEventArgs e)
        {
            media_player.Source = new Uri("ms-appx:///Assets/in_the_closet.mp4");
            indicator.Margin = new Thickness(1075, 424, 0, 0);
            player_indicator.Text = "In the Closet by Micheal Jackson (1992)";
        }

        private void vogue_Tapped(object sender, TappedRoutedEventArgs e)
        {
            media_player.Source = new Uri("ms-appx:///Assets/vogue.mp4");
            indicator.Margin = new Thickness(1075, 526, 0, 0);
            player_indicator.Text = "Vogue by Madonna (1990)";
        }

        private void gonna_make_you_sweat_Tapped(object sender, TappedRoutedEventArgs e)
        {
            media_player.Source = new Uri("ms-appx:///Assets/gonna_make_you_sweat.mp4");
            indicator.Margin = new Thickness(1075, 630, 0, 0);
            player_indicator.Text = "Gonna Make You Sweat by CC Factory (1991)";
        }

        private void about_artists_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(artists_page));
        }

        private void about_us_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(about_us));
        }
    }
}
