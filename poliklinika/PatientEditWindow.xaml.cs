using System;
using System.Linq;
using System.Windows;

namespace poliklinika
{
    public partial class PatientEditWindow : Window
    {
        private int? _patientId = null; // Если null — создаем нового, иначе редактируем

        // Конструктор для добавления нового пациента
        public PatientEditWindow()
        {
            InitializeComponent();
        }

        // Конструктор для редактирования существующего
        public PatientEditWindow(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            TbTitle.Text = "Редактирование пациента";
            LoadPatientData();
        }

        private void LoadPatientData()
        {
            using (var context = new user84_dbEntities())
            {
                var patient = context.KP_Pacienty.Find(_patientId);
                if (patient != null)
                {
                    TbLastName.Text = patient.Familiya;
                    TbFirstName.Text = patient.Imya;
                    TbMiddleName.Text = patient.Otchestvo;
                    DpBirthDate.SelectedDate = patient.Data_rozhdeniya;
                    CbGender.Text = patient.Pol;
                    TbPolicy.Text = patient.Nomer_polisa;
                    TbAddress.Text = patient.Adres;
                    TbPhone.Text = patient.Telefon;
                }
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            // Простая валидация
            if (string.IsNullOrWhiteSpace(TbLastName.Text) || string.IsNullOrWhiteSpace(TbFirstName.Text))
            {
                MessageBox.Show("Фамилия и Имя обязательны для заполнения!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            using (var context = new user84_dbEntities())
            {
                KP_Pacienty patient;

                if (_patientId == null) // Создание нового
                {
                    patient = new KP_Pacienty();
                    context.KP_Pacienty.Add(patient);
                }
                else // Редактирование существующего
                {
                    patient = context.KP_Pacienty.Find(_patientId);
                    if (patient == null) return;
                }

                // Заполняем данные
                patient.Familiya = TbLastName.Text.Trim();
                patient.Imya = TbFirstName.Text.Trim();
                patient.Otchestvo = TbMiddleName.Text.Trim();
                patient.Data_rozhdeniya = DpBirthDate.SelectedDate ?? DateTime.Today;
                patient.Pol = (CbGender.SelectedItem as System.Windows.Controls.ComboBoxItem)?.Content.ToString() ?? "М";
                patient.Nomer_polisa = TbPolicy.Text.Trim();
                patient.Adres = TbAddress.Text.Trim();
                patient.Telefon = TbPhone.Text.Trim();

                context.SaveChanges();
            }

            MessageBox.Show("Данные сохранены!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            this.DialogResult = true; // Сообщаем родительскому окну, что данные обновились
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}