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
    public sealed partial class artists_page : Page
    {
        int next_music = 1;
        public artists_page()
        {
            this.InitializeComponent();
            indicator.Margin = new Thickness(315, 629, 0, 0);
        }

        private void video_player_page_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(video_player));
        }

        private void fredie_mercury_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indicator.Margin = new Thickness(315, 629, 0, 0);
            biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Freddie_Mercury"));
        }

        private void george_micheal_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indicator.Margin = new Thickness(438, 629, 0, 0);
            biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/George_Michael"));
        }

        private void janet_jackson_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indicator.Margin = new Thickness(560, 630, 0, 0);
            biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Janet_Jackson"));
        }

        private void micheal_jackson_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indicator.Margin = new Thickness(676, 630, 0, 0);
            biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Micheal_Jackson"));
        }

        private void madonna_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indicator.Margin = new Thickness(792, 630, 0, 0);
            biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Madonna"));
        }

        private void cc_factory_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indicator.Margin = new Thickness(912, 630, 0, 0);
            biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/C%2BC_Music_Factory"));
        }

        private void go_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            next_music++;
            if(next_music == 1)
            {
                indicator.Margin = new Thickness(315, 629, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Freddie_Mercury"));
            }
            else if (next_music == 2)
            {
                indicator.Margin = new Thickness(438, 629, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/George_Michael"));
            }
            else if (next_music == 3)
            {
                indicator.Margin = new Thickness(560, 630, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Janet_Jackson"));
            }
            else if (next_music == 4)
            {
                indicator.Margin = new Thickness(676, 630, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Micheal_Jackson"));
            }
            else if (next_music == 5)
            {
                indicator.Margin = new Thickness(792, 630, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Madonna"));
            }
            else if (next_music == 6)
            {
                indicator.Margin = new Thickness(912, 630, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/C%2BC_Music_Factory"));
                
            }
            else if (next_music == 7)
            {
                next_music--;
            }

        }

        private void back_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            next_music--;
            if(next_music == 0)
            {
                next_music++;
            }
            else if (next_music == 1)
            {
          
                indicator.Margin = new Thickness(315, 629, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Freddie_Mercury"));
            }
            else if (next_music == 2)
            {
                indicator.Margin = new Thickness(438, 629, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/George_Michael"));
            }
            else if (next_music == 3)
            {
                indicator.Margin = new Thickness(560, 630, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Janet_Jackson"));
            }
            else if (next_music == 4)
            {
                indicator.Margin = new Thickness(676, 630, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Micheal_Jackson"));
            }
            else if (next_music == 5)
            {
                indicator.Margin = new Thickness(792, 630, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/Madonna"));
            }
            else if (next_music == 6)
            {
                indicator.Margin = new Thickness(912, 630, 0, 0);
                biography_search.Navigate(new Uri("https://en.wikipedia.org/wiki/C%2BC_Music_Factory"));
            }
        }

        private void about_us_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(about_us));
        }
    }
}
