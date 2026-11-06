using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace poliklinika
{
    public partial class AppointmentCreateWindow : Window
    {
        public AppointmentCreateWindow()
        {
            InitializeComponent();
            LoadPatients();
            LoadServices();
            LoadFreeDoctors();
        }

        public AppointmentCreateWindow(int slotId)
        {
            InitializeComponent();
            LoadPatients();
            LoadServices();
            LoadFreeDoctors();

            using (var context = new user84_dbEntities())
            {
                var slot = context.KP_Raspisanie.Find(slotId);
                if (slot != null)
                {
                    CbDoctors.SelectedValue = slot.Kod_vracha;
                    CbTimeSlots.SelectedValue = slot.Kod_slota;
                    CbDoctors.IsEnabled = false;
                    CbTimeSlots.IsEnabled = false;
                }
            }
        }

        private void LoadPatients()
        {
            using (var context = new user84_dbEntities())
            {
                CbPatients.ItemsSource = context.KP_Pacienty
                    .Select(p => new { p.Kod_pacienta, Fio = p.Familiya + " " + p.Imya + " " + p.Otchestvo })
                    .ToList();
                CbPatients.DisplayMemberPath = "Fio";
                CbPatients.SelectedValuePath = "Kod_pacienta";
            }
        }

        private void LoadServices()
        {
            using (var context = new user84_dbEntities())
            {
                CbServices.ItemsSource = context.KP_Uslugi
                    .Select(s => new { s.Kod_uslugi, s.Nazvanie })
                    .ToList();
                CbServices.DisplayMemberPath = "Nazvanie";
                CbServices.SelectedValuePath = "Kod_uslugi";
            }
        }

        private void LoadFreeDoctors()
        {
            using (var context = new user84_dbEntities())
            {
                // Ищем врачей, у которых есть слоты со статусом "Свободно" (ID=1)
                var freeDoctors = context.KP_Raspisanie
                    .Where(r => r.Status == 1)
                    .Select(r => r.KP_Vrachi)
                    .Distinct()
                    .Select(v => new { v.Kod_vracha, Fio = v.Familiya + " " + v.Imya + " " + v.Otchestvo })
                    .ToList();

                CbDoctors.ItemsSource = freeDoctors;
                CbDoctors.DisplayMemberPath = "Fio";
                CbDoctors.SelectedValuePath = "Kod_vracha";
            }
        }

        private void CbDoctors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CbDoctors.SelectedValue == null) return;
            int doctorId = (int)CbDoctors.SelectedValue;

            using (var context = new user84_dbEntities())
            {
                var freeSlots = context.KP_Raspisanie
                    .Where(r => r.Kod_vracha == doctorId && r.Status == 1)
                    .Select(r => new { r.Kod_slota, Time = r.Vremya_nachala.ToString() })
                    .ToList();

                CbTimeSlots.ItemsSource = freeSlots;
                CbTimeSlots.DisplayMemberPath = "Time";
                CbTimeSlots.SelectedValuePath = "Kod_slota";
            }
        }

        private void BtnBook_Click(object sender, RoutedEventArgs e)
        {
            if (CbPatients.SelectedValue == null || CbServices.SelectedValue == null ||
                CbTimeSlots.SelectedValue == null)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            int patientId = (int)CbPatients.SelectedValue;
            int serviceId = (int)CbServices.SelectedValue;
            int slotId = (int)CbTimeSlots.SelectedValue;

            using (var context = new user84_dbEntities())
            {
                var slot = context.KP_Raspisanie.Find(slotId);
                if (slot.Status != 1)
                {
                    MessageBox.Show("Этот слот уже занят!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // 1. Создаем запись (Kod_Status = 1 — Запланирована)
                var newRecord = new KP_Zapisi_na_priem
                {
                    Kod_pacienta = patientId,
                    Kod_slota = slotId,
                    Data_sozdaniya = DateTime.Now,
                    Status_zapisi = 1
                };
                context.KP_Zapisi_na_priem.Add(newRecord);
                context.SaveChanges();

                // 2. Привязываем услугу
                var newUslugaLink = new KP_Uslugi_Zapisi
                {
                    Kod_Zapisi = newRecord.Kod_zapisi,
                    Kod_Uslugi = serviceId
                };
                context.KP_Uslugi_Zapisi.Add(newUslugaLink);
                context.SaveChanges();

                // 3. Меняем статус слота на "Занят" (ID=2)
                slot.Status = 2;
                context.SaveChanges();
            }

            MessageBox.Show("Пациент успешно записан!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            this.DialogResult = true;
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}