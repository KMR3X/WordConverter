using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace WPFapp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// <c>Метод для обработки нажатия кнопки "Разделить..."</c>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splitterButton_Click(object sender, RoutedEventArgs e)
        {
            //Проверка наличия текста в TextBox
            if (splitterBox.Text == String.Empty)
            {
                SystemSounds.Exclamation.Play();        //Звук

                MessageBox.Show(                        //Окно предупреждения
                    "В поле не введен текст!", 
                    this.Title, 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Information
                    );
            }
            else
            {
                listboxSplit.Items.Clear();             //Очистка поля ListBox

                string initialText = splitterBox.Text;
                string[] splitResult = initialText.Split(' ');
                foreach (string word in splitResult)
                {
                    listboxSplit.Items.Add(word);
                }
            }
        }


        /// <summary>
        /// <c>Метод для обработки нажатия кнопки "Перевернуть..."</c>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void revertButton_Click(object sender, RoutedEventArgs e)
        {
            //Проверка наличия текста в TextBox
            if (revertBox.Text == String.Empty)
            {
                SystemSounds.Exclamation.Play();        //Звук

                MessageBox.Show(                        //Окно предупреждения
                    "В поле не введен текст!",
                    this.Title,
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                    );
            }
            else
            {
                labelRevert.ClearValue(DefaultStyleKeyProperty);        //Очистка поля Label

                string initialText = revertBox.Text;
                string[] revertSplitResult = initialText.Split(' ');
                Array.Reverse(revertSplitResult, 0, revertSplitResult.Length);
                string revertResult = string.Join(' ', revertSplitResult);
                labelRevert.Content = $"{revertResult}";
            }
        }
    }
}
