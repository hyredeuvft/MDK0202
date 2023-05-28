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
using static AddEmployee.ClassHelper;

namespace AddEmployee
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //    Разработать окно добавления нового сотрудника работником отдела кадров.
        //    При добавлении учитывать валидацию всех полей.

        public MainWindow()
        {
            InitializeComponent();
            cmbGender.ItemsSource = new List<string>() { "Мужской", "Женский" };
            cmbGender.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Проверки на пустоты
                if (String.IsNullOrEmpty(tbName.Text))
                {
                    MessageBox.Show("Поле имя Пустое");
                    return; //Возвращает обратно
                }
                if (String.IsNullOrEmpty(tbSurename.Text))
                {
                    MessageBox.Show("Поле фамилия Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(tbPatron.Text))
                {
                    MessageBox.Show("Поле отчество Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(tbPhone.Text))
                {
                    MessageBox.Show("Поле телефон Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(dpDate.Text))
                {
                    MessageBox.Show("Поле дата рождения Пустое");
                    return;
                }

                //Проверки на спец.символы
                if (!tbName.Text.All(Char.IsLetter)) //Запрос LINQ, является ли текст буквами (Внимание на восклицательный знак)
                {
                    MessageBox.Show("Поле имя содержит недопустимые символы");
                    return;
                }
                if (!tbSurename.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Поле фамилия содержит недопустимые символы");
                    return;
                }
                if (!tbPatron.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Поле имя содержит недопустимые символы");
                    return;
                }
                if (!tbPhone.Text.All(Char.IsDigit)) //Запрос LINQ, является ли текст цифрами (Внимание на восклицательный знак)
                {
                    MessageBox.Show("Поле имя содержит недопустимые символы");
                    return;
                }

                //Проверки на длинну
                if (tbPhone.Text.Length != 11)
                {
                    MessageBox.Show("Телефон неверный");
                    return;
                }


                //Проверка даты (Делать только если он докапается)
                DateTime dateTime = Convert.ToDateTime(dpDate.Text); //Создаём дату из текста datepicker'a
                if (dateTime > DateTime.Now || DateTime.Now.Year - dateTime.Year < 18) //Проверка на то, чтоб дата была до сегодня и человеку было 18
                {
                    MessageBox.Show("Некорректная дата");
                    return;
                }

                EmployeeClass employee = new EmployeeClass();
                employee.FirstName = tbName.Text;
                employee.LastName = tbSurename.Text;
                employee.Patronymic = tbPatron.Text;
                employee.Phone = Convert.ToInt64(tbPhone.Text);
                employee.Birthday = Convert.ToDateTime(dpDate.Text);
                employee.Gender = cmbGender.Text;
                employees.Add(employee);                
                MessageBox.Show("Пользоваьтель добавлен"); //Имитация добавления
                tbName.Text = null;
                tbSurename.Text = null;
                tbPatron.Text = null;
                tbPhone.Text = null;
                dpDate.Text = null;
                cmbGender.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
