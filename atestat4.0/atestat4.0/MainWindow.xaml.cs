using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace atestat4._0;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
        return;
    }

    private void btnMinimise_Click(object sender, RoutedEventArgs e)
    {
        this.WindowState = WindowState.Minimized;
    }

    private bool windowMoving = false;
    private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        windowMoving = true;
        dockTitleBar.Background = Brushes.Aqua;
    }

    private void DockPanel_MouseMove(object sender, MouseEventArgs e)
    {
        if(windowMoving)
        {
            this.PointFromScreen(e.GetPosition(this));
        }
    }

    private void DockPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        windowMoving = false;
    }
}