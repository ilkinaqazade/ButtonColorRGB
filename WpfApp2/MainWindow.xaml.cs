using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ChangeButtonBackgroundColor((Button)sender);
            MessageBox.Show("3", "3", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ChangeButtonBackgroundColor((Button)sender);
            MessageBox.Show("1", "1", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ChangeButtonBackgroundColor((Button)sender);
            MessageBox.Show("2", "2", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ChangeButtonBackgroundColor((Button)sender);
            MessageBox.Show("4", "4", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ChangeButtonBackgroundColor((Button)sender);
            MessageBox.Show("5", "5", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ChangeButtonBackgroundColor((Button)sender);
            MessageBox.Show("6", "6", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void ChangeButtonBackgroundColor(Button button)
        {
            byte[] colorBytes = new byte[3];
            random.NextBytes(colorBytes);

            Color randomColor = Color.FromRgb(colorBytes[0], colorBytes[1], colorBytes[2]);
            button.Background = new SolidColorBrush(randomColor);
        }

        private void DeleteButton(Button button)
        {
            StackPanel parentPanel = button.Parent as StackPanel;
            if (parentPanel != null)
            {
                int buttonNumber = int.Parse(button.Content.ToString());
                parentPanel.Children.Remove(button);
                this.Title = " " + buttonNumber;
            }
        }

        private void Button_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {
                DeleteButton(button);
            }
        }

        private void oneNumber(object sender, MouseButtonEventArgs e)
        {

        }

        private void oneMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {
                DeleteButton(button);
            }
        }

        private void twoMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {
                DeleteButton(button);
            }
        }

        private void sreeMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {
                DeleteButton(button);
            }
        }

        private void fooMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {
                DeleteButton(button);
            }
        }

        private void fiveMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {
                DeleteButton(button);
            }
        }

        private void sixsMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {
                DeleteButton(button);
            }
        }
    }
}
