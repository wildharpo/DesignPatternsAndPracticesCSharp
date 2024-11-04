using DesignPatterns.Library.Patterns.Creational.AbstractFactory;

namespace DesignPatterns.GUI
{
    public partial class Form1 : Form
    {
        private readonly WidgetFactory _motifWidgetFactory;
        private readonly WidgetFactory _pmWidgeFactory;

        public Form1()
        {
            InitializeComponent();
            _motifWidgetFactory = new MotifWidgetFactory();
            _pmWidgeFactory = new PMWidgetFactory();
        }

        private void CreateMotifScrollbarButton_Click(object sender, EventArgs e)
        {
            VerticalScrollBar
        }

        private void CreatePmScrollbarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
