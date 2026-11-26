using System.Reflection; // Атрибуты с названием и версией программы.
using System.Windows; // Настройка ресурсов оформления WPF (ThemeInfo).

// Сведения о программе, которые Windows может показать в свойствах файла.
[assembly: AssemblyTitle("Sdi")]
[assembly: AssemblyDescription("SDI · Редактор персонажей")]
[assembly: AssemblyProduct("Sdi")]

// Версия программы. На переключение страниц не влияет.
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Стандартная настройка WPF: отдельных ресурсов для тем Windows нет,
// общие ресурсы оформления следует искать в сборке самой программы.
[assembly: ThemeInfo(
    ResourceDictionaryLocation.None,
    ResourceDictionaryLocation.SourceAssembly
)]
