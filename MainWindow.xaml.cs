using System;
using System.Windows;

namespace PR7._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int currentImageIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tellButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (currentImageIndex)
                {
                    case 0:
                        firstImage.Visibility = Visibility.Hidden;
                        break;
                    case 1:
                        secondImage.Visibility = Visibility.Hidden;
                        break;
                    case 2:
                        thirdImage.Visibility = Visibility.Hidden;
                        break;
                }
                currentImageIndex = (currentImageIndex + 1) % 3;

                switch (currentImageIndex)
                {
                    case 0:
                        MessageBox.Show("Я всё расскажу, только не бейте!", "Информация", MessageBoxButton.OK, MessageBoxImage.Question);
                        firstImage.Visibility = Visibility.Visible;
                        break;
                    case 1:
                        MessageBox.Show("Ну, значит, так. Жил-был я...", "Информация", MessageBoxButton.OK, MessageBoxImage.Question);
                        secondImage.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        MessageBox.Show("Это конфиденциальная информация. Обращайтесь к моему адвокату!", "Информация", MessageBoxButton.OK, MessageBoxImage.Question);
                        thirdImage.Visibility = Visibility.Visible;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
