using DesignPatterns.Library.Patterns.Structural.Adapter;
using DesignPatterns.Library.Patterns.Structural.Adapter.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesignPatterns.GUI_WPF.Views
{
    /// <summary>
    /// Interaction logic for AdapterUserControl.xaml
    /// </summary>
    public partial class AdapterUserControl : UserControl
    {
        public AdapterUserControl()
        {
            InitializeComponent();
        }

        private void LineButton_Click(object sender, RoutedEventArgs e)
        {
            var lineShape = new LineShape();
            var lineCoordinates = lineShape.BoundingBox();
            var line = CreateLineSegmentFromCoordinatePair(lineCoordinates.First(), lineCoordinates.Last());
            this.CanvasContent.Children.Add(line);
        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            var circleShape = new CircleShape();
            var circleCoordinates = circleShape.BoundingBox().ToList();
            for (var i = 0; i < circleCoordinates.Count() - 1; ++i)
            {
                var line = CreateLineSegmentFromCoordinatePair(circleCoordinates[i], circleCoordinates[i + 1]);
                this.CanvasContent.Children.Add(line);
            }
            // draw the last line to close the circle
            var closingLine = CreateLineSegmentFromCoordinatePair(circleCoordinates.Last(), circleCoordinates.First());
            this.CanvasContent.Children.Add(closingLine);
        }

        private void TextBoxButton_Click(object sender, RoutedEventArgs e)
        {
            var textShape = new TextShape();
            var textBoxCoordinates = textShape.BoundingBox();
            var width = Math.Abs(textBoxCoordinates.ElementAt(0).X - textBoxCoordinates.ElementAt(1).X);
            var height = Math.Abs(textBoxCoordinates.ElementAt(1).Y - textBoxCoordinates.ElementAt(2).Y);
            var textBox = new TextBox();
            textBox.Height = height;
            textBox.Width = width;
            textBox.IsEnabled = true;
            textBox.Text = "Hello, world!";
            this.CanvasContent.Children.Add(textBox);
        }

        private Line CreateLineSegmentFromCoordinatePair(CoordinatePair start, CoordinatePair end)
        {
            var line = new Line();
            line.Visibility = Visibility.Visible;
            line.StrokeThickness = 3;
            line.Stroke = Brushes.Black;
            line.X1 = start.X;
            line.X2 = end.X;
            line.Y1 = start.Y;
            line.Y2 = end.Y;
            return line;
        }

        private void ClearItemsButton_Click(object sender, RoutedEventArgs e)
        {
            this.CanvasContent.Children.Clear();
        }
    }
}
