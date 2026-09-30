using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace parkereso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> meret = new List<string> {"2 x 2","4 x 4","6 x 6" };
        public MainWindow()
        {
            InitializeComponent();
            lbox_meret.ItemsSource = meret;
        }
    }
}