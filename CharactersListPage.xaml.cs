using System.Windows.Controls; // Подключаем класс Page — страницу WPF.

namespace Sdi // То же пространство имён, что и у главного окна.
{
    // Страница «список персонажей» показывается внутри Frame главного окна.
    // partial связывает этот класс с разметкой в CharactersListPage.xaml.
    public partial class CharactersListPage : Page
    {
        // Конструктор вызывается при создании страницы через new CharactersListPage().
        public CharactersListPage()
        {
            // Создаём карточки и текст, описанные в XAML этой страницы.
            InitializeComponent();
        }
    }
}
