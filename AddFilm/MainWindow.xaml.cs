using Microsoft.Win32;
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
using System.Xml.Linq;
using static AddFilm.ClassHelper;

namespace AddFilm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string pathPhoto; 
        public MainWindow()
        {
            InitializeComponent();
            cmbGenre.ItemsSource = new List<string>() { "Хоррор", "Боевик" };
            cmbGenre.SelectedIndex = 0;
            cmbAge.ItemsSource = new List<string>() { "6+", "12+" };
            cmbAge.SelectedIndex = 0;
        }

        private void btnAddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                try //Валидация на формат
                {
                    ImImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    pathPhoto = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Изображение имеет неверный формат");
                }

            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Проверки на пустоты
                if (String.IsNullOrEmpty(tbTitle.Text))
                {
                    MessageBox.Show("Поле название Пустое");
                    return; //Возвращает обратно
                }
                if (String.IsNullOrEmpty(tbCost.Text))
                {
                    MessageBox.Show("Поле цена Пустое");
                    return;
                }
               
               
                //Проверки на спец.символы
                if (!tbTitle.Text.All(Char.IsLetter)) //Запрос LINQ, является ли текст буквами (Внимание на восклицательный знак)
                {
                    MessageBox.Show("Поле название содержит недопустимые символы");
                    return;
                }
                if (!tbCost.Text.All(Char.IsDigit))
                {
                    MessageBox.Show("Поле цена содержит недопустимые символы");
                    return;
                }
                if (Convert.ToDouble(tbCost.Text) < 0)
                {
                    MessageBox.Show("Поле цена неправильно заполнено");
                    return;
                }

                FilmClass film = new FilmClass();
                film.ImagePath = pathPhoto;
                film.Title = tbTitle.Text;
                film.Cost = Convert.ToDouble(tbCost.Text);
                film.Genre = cmbGenre.Text;
                film.Age = cmbAge.Text;
                films.Add(film);
                MessageBox.Show("Фильм добавлен"); //Имитация добавления
                tbTitle.Text = null;
                tbCost.Text = null;
                cmbAge.SelectedIndex = 0;
                cmbGenre.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
