using System.Windows; // Window — окно, RoutedEventArgs — сведения о нажатии кнопки.

namespace Sdi // Общее имя для классов нашего проекта.
{
    // partial означает, что часть окна описана здесь, а другая часть — в XAML.
    public partial class MainWindow : Window
    {
        // Конструктор выполняется при создании главного окна.
        public MainWindow()
        {
            InitializeComponent(); // Создаём элементы, описанные в MainWindow.xaml.

            // При запуске сразу показываем список персонажей внутри Frame.
            FrameArea.Content = new CharactersListPage();
        }

        // Этот метод вызывается кнопкой «Персонажи» через свойство Click в XAML.
        // sender — нажатая кнопка, e — сведения о событии. Здесь они нам не нужны.
        private void CharactersButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаём страницу со списком и помещаем её в рабочую область окна.
            FrameArea.Content = new CharactersListPage();
        }

        // Этот метод вызывается кнопкой «Магазин».
        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            // Меняем только содержимое Frame, не открывая новое окно.
            FrameArea.Content = new ShopPage();
        }
    }
}
