using System.Windows;
using System.Windows.Controls;

namespace Configurator.Addin.Windows.Common.Controls
{
    internal class HeadingWithButtons : Control
    {
        public static readonly DependencyProperty TextProperty = WindowHelpers.RegisterProperty<HeadingWithButtons, string>(nameof(Text));

        public string Text
        {
            get => (string) GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
    }
}
