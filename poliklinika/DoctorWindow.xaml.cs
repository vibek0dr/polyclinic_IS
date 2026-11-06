using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace poliklinika
{
    public partial class DoctorWindow : Window
    {
        private int _currentDoctorId = 1; // В реальности нужно брать ID авторизованного врача

        public DoctorWindow()
        {
            InitializeComponent();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            using (var context = new user84_dbEntities())
            {
                var appointments = context.KP_Zapisi_na_priem
                    .Where(z => z.KP_Raspisanie.Kod_vracha == _currentDoctorId)
                    .Select(z => new
                    {
                        z.Kod_zapisi,
                        Time = z.KP_Raspisanie.Vremya_nachala.ToString(),
                        PatientName = z.KP_Pacienty.Familiya + " " + z.KP_Pacienty.Imya
                    })
                    .ToList();

                DgAppointments.ItemsSource = appointments;
                DgAppointments.DisplayMemberPath = "PatientName";
                DgAppointments.SelectedValuePath = "Kod_zapisi";
            }
        }

        private void DgAppointments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgAppointments.SelectedValue == null) return;
            int recordId = (int)DgAppointments.SelectedValue;

            using (var context = new user84_dbEntities())
            {
                var result = context.KP_Rezultaty_priema.FirstOrDefault(r => r.Kod_zapisi == recordId);
                if (result != null)
                {
                    TbComplaints.Text = result.Zhaloby;
                    TbDiagnosis.Text = result.Diagnoz;
                    TbPrescriptions.Text = result.Naznacheniya;
                }
                else
                {
                    TbComplaints.Clear();
                    TbDiagnosis.Clear();
                    TbPrescriptions.Clear();
                }
            }
        }

        private void BtnSaveRecord_Click(object sender, RoutedEventArgs e)
        {
            if (DgAppointments.SelectedValue == null)
            {
                MessageBox.Show("Выберите пациента!", "Ошибка");
                return;
            }

            int recordId = (int)DgAppointments.SelectedValue;

            using (var context = new user84_dbEntities())
            {
                var result = context.KP_Rezultaty_priema.FirstOrDefault(r => r.Kod_zapisi == recordId);
                if (result == null)
                {
                    result = new KP_Rezultaty_priema { Kod_zapisi = recordId };
                    context.KP_Rezultaty_priema.Add(result);
                }

                result.Zhaloby = TbComplaints.Text;
                result.Diagnoz = TbDiagnosis.Text;
                result.Naznacheniya = TbPrescriptions.Text;
                result.Rekomendacii = ""; // Если нужно

                context.SaveChanges();
            }

            MessageBox.Show("Данные сохранены!", "Успех");
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Close();
        }
    }
}