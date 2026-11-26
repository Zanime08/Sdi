using System;
using System.Windows;
using System.Windows.Controls;

namespace Sdi
{
    public partial class MainWindow : Window
    {
        private StackPanel _selectedEl;

        public MainWindow()
        {
            InitializeComponent();
            _selectedEl = StackCharacters;
            FrameArea.Source = new Uri("CharactersListPage.xaml", UriKind.Relative);
        }

        private void SwithSelect(object sender, RoutedEventArgs e)
        {
            _selectedEl.Style = (Style)FindResource("ElMenu");

            var button = (Button)sender;
            _selectedEl = (StackPanel)button.Parent;
            _selectedEl.Style = (Style)FindResource("SelectedButtonMenu");

            var page = button.Tag as string;
            if (!string.IsNullOrEmpty(page))
                FrameArea.Source = new Uri(page, UriKind.Relative);
        }
    }
}
