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

namespace WpfEventsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(sender is Border brd)
            {
                MessageBox.Show($"Preview {brd.Name}");
            }
        }

        private void Green_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Border brd)
            {
                MessageBox.Show($"Bubble {brd.Name}");
            }
        }

        private void Aqua_MouseMove(object sender, MouseEventArgs e)
        {
            //txtTablo.Text = e.GetPosition(this).ToString();
        }

        private void txtSource_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(txtSource, txtSource.Text, DragDropEffects.Move);
        }

        private void Button_Drop(object sender, DragEventArgs e)
        {
            btnDest.Content = e.Data.GetData(DataFormats.Text);
            txtSource.Text = "";
        }
    }
}