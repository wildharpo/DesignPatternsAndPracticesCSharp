using DesignPatterns.Library.Patterns.Structural.Decorator;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DesignPatterns.GUI_WPF.Views
{
    /// <summary>
    /// Interaction logic for DecoratorUserControl.xaml
    /// </summary>
    public partial class DecoratorUserControl : UserControl
    {
        public DecoratorUserControl()
        {
            InitializeComponent();
        }

        private void TextViewButton_Click(object sender, RoutedEventArgs e)
        {
            var components = new List<VisualComponent>();
            var textView = new TextView();
            components.Add(textView);

            Draw(components);
        }

        private void TextViewWithScrollbarButton_Click(object sender, RoutedEventArgs e)
        {
            var components = new List<VisualComponent>();
            var textView = new TextView();
            var scrollDecorator = new ScrollDecorator(textView);
            components.Add(scrollDecorator);

            Draw(components);
        }

        private void TextViewWithBorderButton_Click(object sender, RoutedEventArgs e)
        {
            var components = new List<VisualComponent>();
            var textView = new TextView();
            var borderDecorator = new BorderDecorator(textView);
            components.Add(borderDecorator);

            Draw(components);
        }

        private void TextViewWithBothButton_Click(object sender, RoutedEventArgs e)
        {
            var components = new List<VisualComponent>();
            var textView = new TextView();
            var scrollDecorator = new ScrollDecorator(textView);
            var borderDecorator = new BorderDecorator(textView);
            // in reality, this would be new BorderDecorator(scrollDecorator), but because our class library isn't actually
            // doing the drawing logic, we are mocking up an example here.
            components.Add(scrollDecorator);
            components.Add(borderDecorator);

            Draw(components);
        }

        private void Draw(List<VisualComponent> visualComponents)
        {
            var textBox = new TextBox();
            textBox.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden; // default to hidden
            textBox.Width = 150;
            textBox.Height = 75;
            textBox.Text = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.\r\n\r\nWhere can I get some?\r\nThere are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\r\n\r\n5\r\n\tparagraphs\r\n\twords\r\n\tbytes\r\n\tlists\r\n\tStart with 'Lorem\r\nipsum dolor sit amet...'\r\n";

            foreach(var visualComponent in visualComponents)
            {
                if (visualComponent.GetType() == typeof(BorderDecorator))
                {
                    textBox.BorderBrush = GetColorFromHexValue("#000000");
                    textBox.BorderThickness = new Thickness(4);
                }

                if (visualComponent.GetType() == typeof(ScrollDecorator))
                    textBox.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            }

            this.CanvasContent.Children.Add(textBox);
        }

        private SolidColorBrush GetColorFromHexValue(string hexValue)
        {
            hexValue = hexValue.Replace("#", "");
            byte r = (byte)(Convert.ToUInt32(hexValue.Substring(0, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hexValue.Substring(2, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hexValue.Substring(4, 2), 16));
            SolidColorBrush myBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
            return myBrush;
        }
    }
}
