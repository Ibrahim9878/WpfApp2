

using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        int R = Random.Shared.Next(0, 255);
        int G = Random.Shared.Next(0, 255);
        int B = Random.Shared.Next(0, 255);
        Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
        Button1.Background = new SolidColorBrush(color);
        MessageBox.Show(Button1.Background.ToString());
    }       
        private void Button2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        int R = Random.Shared.Next(0, 255);
        int G = Random.Shared.Next(0, 255);
        int B = Random.Shared.Next(0, 255);
        Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
        Button2.Background = new SolidColorBrush(color);
        MessageBox.Show(Button2.Background.ToString());
    }
    private void Button3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        int R = Random.Shared.Next(0, 255);
        int G = Random.Shared.Next(0, 255);
        int B = Random.Shared.Next(0, 255);
        Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
        Button3.Background = new SolidColorBrush(color);
        MessageBox.Show(Button3.Background.ToString());
    }

    private void Button4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        int R = Random.Shared.Next(0, 255);
        int G = Random.Shared.Next(0, 255);
        int B = Random.Shared.Next(0, 255);
        Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
        Button4.Background = new SolidColorBrush(color);
        MessageBox.Show(Button4.Background.ToString());
    }

    private void Button5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        int R = Random.Shared.Next(0, 255);
        int G = Random.Shared.Next(0, 255);
        int B = Random.Shared.Next(0, 255);
        Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
        Button3.Background = new SolidColorBrush(color);
        MessageBox.Show(Button5.Background.ToString());
    }

    private void Button6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        int R = Random.Shared.Next(0, 255);
        int G = Random.Shared.Next(0, 255);
        int B = Random.Shared.Next(0, 255);
        Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
        Button6.Background = new SolidColorBrush(color);
        MessageBox.Show(Button6.Background.ToString());
    }

    private void Button1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
        Button1.Visibility = Visibility.Hidden;
        this.Title = Button1.Content.ToString();
    }

    private void Button2_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
        Button2.Visibility = Visibility.Hidden;
        this.Title = Button2.Content.ToString();
    }

    private void Button3_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
        Button3.Visibility = Visibility.Hidden;
        this.Title = Button3.Content.ToString();
    }

    private void Button4_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
        Button4.Visibility = Visibility.Hidden;
        this.Title = Button4.Content.ToString();
    }

    private void Button5_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
        Button5.Visibility = Visibility.Hidden;
        this.Title = Button5.Content.ToString();
    }

    private void Button6_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
        Button6.Visibility = Visibility.Hidden;
        this.Title = Button6.Content.ToString();
    }
}