using System.Windows;
using DesignPatterns.GUI_WPF.Views;

namespace DesignPatterns.GUI_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        private AbstractFactoryUserControl _abstractFactoryUserControl;
        private AdapterUserControl _adapterUserControl;
        private DecoratorUserControl _decoratorUserControl;

        public MainWindow()
        {
            InitializeComponent();
            _abstractFactoryUserControl = new AbstractFactoryUserControl();
            _adapterUserControl = new AdapterUserControl();
            _decoratorUserControl = new DecoratorUserControl();
        }

        private void AbstractFactoryButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = _abstractFactoryUserControl;
        }

        private void AdapterButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = _adapterUserControl;
        }

        private void DecoratorButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = _decoratorUserControl;
        }
    }
}