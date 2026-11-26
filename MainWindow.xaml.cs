using System;
using System.Windows;
using System.Windows.Controls;

namespace Sdi
{
    /// <summary>
    /// Главное окно SDI-приложения: слева — вертикальная полоска команд
    /// (кнопки-логотипы), справа — рабочая область (Frame) с контентом.
    /// </summary>
    public partial class MainWindow : Window
    {
        // Текущая выделенная кнопка-команда в левой панели
        private StackPanel _selectedEl;

        public MainWindow()
        {
            InitializeComponent();

            // Изначально выбрана команда «Список персонажей»
            _selectedEl = StackCharacters;
            FrameArea.Source = new Uri("CharactersListPage.xaml", UriKind.Relative);
        }

        // Переключение выделенной команды и загрузка соответствующей страницы
        private void SwithSelect(object sender, RoutedEventArgs e)
        {
            // Снимаем выделение с предыдущей кнопки
            _selectedEl.Style = (Style)FindResource("ElMenu");

            var button = (Button)sender;
            _selectedEl = (StackPanel)button.Parent;
            _selectedEl.Style = (Style)FindResource("SelectedButtonMenu");

            // Загружаем страницу, указанную в Tag кнопки
            var pageUri = button.Tag as string;
            if (!string.IsNullOrEmpty(pageUri))
            {
                FrameArea.Source = new Uri(pageUri, UriKind.Relative);
            }
        }
    }
}
