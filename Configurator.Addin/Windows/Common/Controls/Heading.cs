using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Configurator.Addin.Windows.Common.Controls
{
    internal class Heading : Control
    {
        static Heading()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Heading),
                new FrameworkPropertyMetadata(typeof(Heading)));
        }

        private const double DefaultImageWidth = 20;

        public static readonly DependencyProperty Button1CommandProperty = WindowHelpers.RegisterProperty<Heading, ICommand>(nameof(Button1Command));
        public static readonly DependencyProperty Button2CommandProperty = WindowHelpers.RegisterProperty<Heading, ICommand>(nameof(Button2Command));
        public static readonly DependencyProperty Button3CommandProperty = WindowHelpers.RegisterProperty<Heading, ICommand>(nameof(Button3Command));
        public static readonly DependencyProperty Button4CommandProperty = WindowHelpers.RegisterProperty<Heading, ICommand>(nameof(Button4Command));
        public static readonly DependencyProperty Button5CommandProperty = WindowHelpers.RegisterProperty<Heading, ICommand>(nameof(Button5Command));
        public static readonly DependencyProperty Button6CommandProperty = WindowHelpers.RegisterProperty<Heading, ICommand>(nameof(Button6Command));

        public static readonly DependencyProperty Button1ImageSourceProperty = WindowHelpers.RegisterProperty<Heading, ImageSource>(nameof(Button1ImageSource));
        public static readonly DependencyProperty Button2ImageSourceProperty = WindowHelpers.RegisterProperty<Heading, ImageSource>(nameof(Button2ImageSource));
        public static readonly DependencyProperty Button3ImageSourceProperty = WindowHelpers.RegisterProperty<Heading, ImageSource>(nameof(Button3ImageSource));
        public static readonly DependencyProperty Button4ImageSourceProperty = WindowHelpers.RegisterProperty<Heading, ImageSource>(nameof(Button4ImageSource));
        public static readonly DependencyProperty Button5ImageSourceProperty = WindowHelpers.RegisterProperty<Heading, ImageSource>(nameof(Button5ImageSource));
        public static readonly DependencyProperty Button6ImageSourceProperty = WindowHelpers.RegisterProperty<Heading, ImageSource>(nameof(Button6ImageSource));
        
        public static readonly DependencyProperty Button1ImageWidthProperty = WindowHelpers.RegisterProperty<Heading, double>(nameof(Button1ImageWidth),DefaultImageWidth);
        public static readonly DependencyProperty Button2ImageWidthProperty = WindowHelpers.RegisterProperty<Heading, double>(nameof(Button2ImageWidth), DefaultImageWidth);
        public static readonly DependencyProperty Button3ImageWidthProperty = WindowHelpers.RegisterProperty<Heading, double>(nameof(Button3ImageWidth), DefaultImageWidth);
        public static readonly DependencyProperty Button4ImageWidthProperty = WindowHelpers.RegisterProperty<Heading, double>(nameof(Button4ImageWidth), DefaultImageWidth);
        public static readonly DependencyProperty Button5ImageWidthProperty = WindowHelpers.RegisterProperty<Heading, double>(nameof(Button5ImageWidth), DefaultImageWidth);
        public static readonly DependencyProperty Button6ImageWidthProperty = WindowHelpers.RegisterProperty<Heading, double>(nameof(Button6ImageWidth), DefaultImageWidth);
        
        public static readonly DependencyProperty Button1TooltipProperty = WindowHelpers.RegisterProperty<Heading, string>(nameof(Button1Tooltip));
        public static readonly DependencyProperty Button2TooltipProperty = WindowHelpers.RegisterProperty<Heading, string>(nameof(Button2Tooltip));
        public static readonly DependencyProperty Button3TooltipProperty = WindowHelpers.RegisterProperty<Heading, string>(nameof(Button3Tooltip)); 
        public static readonly DependencyProperty Button4TooltipProperty = WindowHelpers.RegisterProperty<Heading, string>(nameof(Button4Tooltip));
        public static readonly DependencyProperty Button5TooltipProperty = WindowHelpers.RegisterProperty<Heading, string>(nameof(Button5Tooltip));
        public static readonly DependencyProperty Button6TooltipProperty = WindowHelpers.RegisterProperty<Heading, string>(nameof(Button6Tooltip));
        
        public static readonly DependencyProperty IsCenteredProperty = WindowHelpers.RegisterProperty<Heading, bool>(nameof(IsCentered));
        public static readonly DependencyProperty ShowButton1Property = WindowHelpers.RegisterProperty<Heading, bool>(nameof(ShowButton1));
        public static readonly DependencyProperty ShowButton2Property = WindowHelpers.RegisterProperty<Heading, bool>(nameof(ShowButton2));
        public static readonly DependencyProperty ShowButton3Property = WindowHelpers.RegisterProperty<Heading, bool>(nameof(ShowButton3));
        public static readonly DependencyProperty ShowButton4Property = WindowHelpers.RegisterProperty<Heading, bool>(nameof(ShowButton4));
        public static readonly DependencyProperty ShowButton5Property = WindowHelpers.RegisterProperty<Heading, bool>(nameof(ShowButton5));
        public static readonly DependencyProperty ShowButton6Property = WindowHelpers.RegisterProperty<Heading, bool>(nameof(ShowButton6));
        public static readonly DependencyProperty ShowCompressedProperty = WindowHelpers.RegisterProperty<Heading, bool>(nameof(ShowCompressed));
        public static readonly DependencyProperty ShowLineProperty = WindowHelpers.RegisterProperty<Heading, bool>(nameof(ShowLine), true);
        public static readonly DependencyProperty TextProperty = WindowHelpers.RegisterProperty<Heading, string>(nameof(Text), "Heading");

        public ICommand Button1Command
        {
            get => (ICommand) GetValue(Button1CommandProperty);
            set => SetValue(Button1CommandProperty, value);
        }

        public ImageSource Button1ImageSource
        {
            get => (ImageSource) GetValue(Button1ImageSourceProperty);
            set => SetValue(Button1ImageSourceProperty, value);
        }

        public double Button1ImageWidth
        {
            get => (double) GetValue(Button1ImageWidthProperty);
            set => SetValue(Button1ImageWidthProperty, value);
        }

        public string Button1Tooltip
        {
            get => (string)GetValue(Button1TooltipProperty);
            set => SetValue(Button1TooltipProperty, value);
        }

        public ICommand Button2Command
        {
            get => (ICommand) GetValue(Button2CommandProperty);
            set => SetValue(Button2CommandProperty, value);
        }

        public ImageSource Button2ImageSource
        {
            get => (ImageSource) GetValue(Button2ImageSourceProperty);
            set => SetValue(Button2ImageSourceProperty, value);
        }

        public double Button2ImageWidth
        {
            get => (double) GetValue(Button2ImageWidthProperty);
            set => SetValue(Button2ImageWidthProperty, value);
        }

        public string Button2Tooltip
        {
            get => (string)GetValue(Button2TooltipProperty);
            set => SetValue(Button2TooltipProperty, value);
        }

        public ICommand Button3Command
        {
            get => (ICommand) GetValue(Button3CommandProperty);
            set => SetValue(Button3CommandProperty, value);
        }

        public ImageSource Button3ImageSource
        {
            get => (ImageSource) GetValue(Button3ImageSourceProperty);
            set => SetValue(Button3ImageSourceProperty, value);
        }

        public double Button3ImageWidth
        {
            get => (double) GetValue(Button3ImageWidthProperty);
            set => SetValue(Button3ImageWidthProperty, value);
        }

        public string Button3Tooltip
        {
            get => (string)GetValue(Button3TooltipProperty);
            set => SetValue(Button3TooltipProperty, value);
        }

        public ICommand Button4Command
        {
            get => (ICommand) GetValue(Button4CommandProperty);
            set => SetValue(Button4CommandProperty, value);
        }

        public ImageSource Button4ImageSource
        {
            get => (ImageSource) GetValue(Button4ImageSourceProperty);
            set => SetValue(Button4ImageSourceProperty, value);
        }

        public double Button4ImageWidth
        {
            get => (double) GetValue(Button4ImageWidthProperty);
            set => SetValue(Button4ImageWidthProperty, value);
        }

        public string Button4Tooltip
        {
            get => (string)GetValue(Button4TooltipProperty);
            set => SetValue(Button4TooltipProperty, value);
        }

        public ICommand Button5Command
        {
            get => (ICommand) GetValue(Button5CommandProperty);
            set => SetValue(Button5CommandProperty, value);
        }

        public ImageSource Button5ImageSource
        {
            get => (ImageSource) GetValue(Button5ImageSourceProperty);
            set => SetValue(Button5ImageSourceProperty, value);
        }

        public double Button5ImageWidth
        {
            get => (double) GetValue(Button5ImageWidthProperty);
            set => SetValue(Button5ImageWidthProperty, value);
        }

        public string Button5Tooltip
        {
            get => (string)GetValue(Button5TooltipProperty);
            set => SetValue(Button5TooltipProperty, value);
        }

        public ICommand Button6Command
        {
            get => (ICommand) GetValue(Button6CommandProperty);
            set => SetValue(Button6CommandProperty, value);
        }

        public ImageSource Button6ImageSource
        {
            get => (ImageSource) GetValue(Button6ImageSourceProperty);
            set => SetValue(Button6ImageSourceProperty, value);
        }

        public double Button6ImageWidth
        {
            get => (double) GetValue(Button6ImageWidthProperty);
            set => SetValue(Button6ImageWidthProperty, value);
        }

        public string Button6Tooltip
        {
            get => (string)GetValue(Button6TooltipProperty);
            set => SetValue(Button6TooltipProperty, value);
        }

        public bool IsCentered
        {
            get => (bool) GetValue(IsCenteredProperty);
            set => SetValue(IsCenteredProperty, value);
        }

        public bool ShowButton1
        {
            get => (bool) GetValue(ShowButton1Property);
            set => SetValue(ShowButton1Property, value);
        }

        public bool ShowButton2
        {
            get => (bool) GetValue(ShowButton2Property);
            set => SetValue(ShowButton2Property, value);
        }

        public bool ShowButton3
        {
            get => (bool) GetValue(ShowButton3Property);
            set => SetValue(ShowButton3Property, value);
        }

        public bool ShowButton4
        {
            get => (bool) GetValue(ShowButton4Property);
            set => SetValue(ShowButton4Property, value);
        }

        public bool ShowButton5
        {
            get => (bool) GetValue(ShowButton5Property);
            set => SetValue(ShowButton5Property, value);
        }

        public bool ShowButton6
        {
            get => (bool) GetValue(ShowButton6Property);
            set => SetValue(ShowButton6Property, value);
        }

        public bool ShowCompressed
        {
            get => (bool) GetValue(ShowCompressedProperty);
            set => SetValue(ShowCompressedProperty, value);
        }

        public bool ShowLine
        {
            get => (bool) GetValue(ShowLineProperty);
            set => SetValue(ShowLineProperty, value);
        }

        public string Text
        {
            get => (string) GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
    }
}
