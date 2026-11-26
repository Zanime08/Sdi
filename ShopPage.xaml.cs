using System.Windows.Controls; // Подключаем класс Page — страницу WPF.

namespace Sdi // То же пространство имён, что и у главного окна.
{
    // Страница «магазин персонажей» показывается внутри Frame главного окна.
    // partial связывает этот класс с разметкой в ShopPage.xaml.
    public partial class ShopPage : Page
    {
        // Конструктор вызывается при создании страницы через new ShopPage().
        public ShopPage()
        {
            // Создаём карточки и текст, описанные в XAML этой страницы.
            InitializeComponent();
        }
    }
}
