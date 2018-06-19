using Avalonia;
using Avalonia.Markup.Xaml;

namespace MaterialDesignsThemes.Avalonia
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
