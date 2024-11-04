using DesignPatterns.Library.Patterns.Creational.AbstractFactory;
using DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.Window;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DesignPatterns.GUI_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        private readonly WidgetFactory _motifWidgetFactory;
        private readonly WidgetFactory _pmWidgetFactory;

        public MainWindow()
        {
            InitializeComponent();
            _motifWidgetFactory = new MotifWidgetFactory();
            _pmWidgetFactory = new PMWidgetFactory();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var lookAndFeelProperties = _pmWidgetFactory.CreateScrollBar();
            SetScrollBarProperties(lookAndFeelProperties);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var lookAndFeelProperties = _motifWidgetFactory.CreateScrollBar();
            SetScrollBarProperties(lookAndFeelProperties);
        }

        private void SetScrollBarProperties(Library.Patterns.Creational.AbstractFactory.Controls.ScrollBar.ScrollBar lookAndFeelProperties)
        {
            var backgroundColor = GetColorFromHexValue(lookAndFeelProperties.BackColor);
            var foregroundColor = GetColorFromHexValue(lookAndFeelProperties.ForeColor);

            CustomScrollbar.Track.Thumb.Width = lookAndFeelProperties.TrackWidth;

            var cursorConverter = new CursorConverter();
            var cursor = (Cursor)cursorConverter.ConvertFromString(lookAndFeelProperties.Cursor);
            CustomScrollbar.Track.Thumb.Cursor = cursor;

            var motifStyle = new Style(typeof(System.Windows.Controls.Primitives.ScrollBar));
            var backgroundSetter = new Setter(System.Windows.Controls.Primitives.ScrollBar.BackgroundProperty, backgroundColor);
            motifStyle.Setters.Add(backgroundSetter);

            // var foregroundSetter = new Setter(System.Windows.Controls.Primitives.ScrollBar.ForegroundProperty, foregroundColor);
            // motifStyle.Setters.Add(foregroundSetter);

            var thumbStyle = new Style(typeof(Thumb));
            var thumbTemplate = new ControlTemplate(typeof(Thumb));
            var rectangle = new FrameworkElementFactory(typeof(Rectangle));
            rectangle.SetValue(Rectangle.FillProperty, foregroundColor);
            thumbTemplate.VisualTree = rectangle;
            var thumbTemplateSetter = new Setter(Thumb.TemplateProperty, thumbTemplate);

            if (lookAndFeelProperties.RoundedCorners)
            {
                var borderStyle = new Style(typeof(Border));
                var roundedCornerSetter = new Setter(Border.CornerRadiusProperty, new CornerRadius(5));
                borderStyle.Setters.Add(roundedCornerSetter);
                var resourceDictionary = new ResourceDictionary();
                resourceDictionary.Add("RadiusRounder", borderStyle);
                motifStyle.Resources = resourceDictionary;
            }

            CustomScrollbar.Style = motifStyle;
        }

        private SolidColorBrush GetColorFromHexValue(string hexValue)
        {
            hexValue = hexValue.Replace("#", "");
            byte r = (byte)(Convert.ToUInt32(hexValue.Substring(0, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hexValue.Substring(2, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hexValue.Substring(4, 2), 16));
            SolidColorBrush myBrush = new SolidColorBrush(Color.FromRgb(r,g,b));
            return myBrush;
        }
    }
}