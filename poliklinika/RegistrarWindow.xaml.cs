using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace poliklinika
{
    public partial class RegistrarWindow : Window
    {
        private string connStr = "Server=stud-mssql.sttec.yar.ru,38325;Database=user84_db;User Id=user84_db;Password=user84;TrustServerCertificate=True;";

        public RegistrarWindow()
        {
            InitializeComponent();
            DpDate.SelectedDate = DateTime.Today;
            LoadDoctors();
            LoadSchedule();
        }

        private void LoadDoctors()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT Kod_vracha, Familiya + ' ' + Imya + ' ' + Otchestvo AS Fio FROM KP_Vrachi";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var doctors = new List<dynamic>();
                            while (reader.Read())
                            {
                                doctors.Add(new { Kod_vracha = reader.GetInt32(0), Fio = reader.GetString(1) });
                            }
                            CbDoctors.ItemsSource = doctors;
                            CbDoctors.DisplayMemberPath = "Fio";
                            CbDoctors.SelectedValuePath = "Kod_vracha";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки врачей: " + ex.Message);
            }
        }

        private void LoadSchedule()
        {
            try
            {
                DateTime selectedDate = DpDate.SelectedDate ?? DateTime.Today;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // Базовый запрос
                    string sql = @"
                        SELECT 
                            r.Kod_slota, 
                            CONVERT(VARCHAR(5), r.Vremya_nachala, 108) AS Time,
                            v.Familiya + ' ' + v.Imya + ' ' + v.Otchestvo AS DoctorName,
                            v.Nomer_kabineta AS Room,
                            CASE WHEN r.Status = 1 THEN 'Свободно' ELSE 'Занято' END AS Status,
                            ISNULL(p.Familiya + ' ' + p.Imya, '—') AS PatientName,
                            ISNULL(u.Nazvanie, '—') AS ServiceName,
                            ISNULL(u.image, '') AS ServiceImage
                        FROM KP_Raspisanie r
                        INNER JOIN KP_Vrachi v ON r.Kod_vracha = v.Kod_vracha
                        LEFT JOIN KP_Zapisi_na_priem z ON r.Kod_slota = z.Kod_slota
                        LEFT JOIN KP_Pacienty p ON z.Kod_pacienta = p.Kod_pacienta
                        LEFT JOIN KP_Uslugi_Zapisi uz ON z.Kod_zapisi = uz.Kod_Zapisi
                        LEFT JOIN KP_Uslugi u ON uz.Kod_Uslugi = u.Kod_uslugi
                        WHERE r.Data_priema = @date";

                    // Добавляем фильтр по врачу, если он выбран
                    if (CbDoctors.SelectedValue != null)
                    {
                        sql += " AND r.Kod_vracha = @doctorId";
                    }

                    // Добавляем фильтр по пациенту, если введен текст
                    if (!string.IsNullOrWhiteSpace(TbSearch.Text))
                    {
                        sql += " AND (p.Familiya LIKE @search OR p.Imya LIKE @search OR p.Otchestvo LIKE @search)";
                    }

                    sql += " ORDER BY r.Vremya_nachala";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", selectedDate);

                        if (CbDoctors.SelectedValue != null)
                        {
                            cmd.Parameters.AddWithValue("@doctorId", CbDoctors.SelectedValue);
                        }

                        if (!string.IsNullOrWhiteSpace(TbSearch.Text))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + TbSearch.Text + "%");
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            var schedule = new List<ScheduleItem>();
                            while (reader.Read())
                            {
                                schedule.Add(new ScheduleItem
                                {
                                    KodSlota = reader.GetInt32(0),
                                    Time = reader.GetString(1),
                                    DoctorName = reader.GetString(2),
                                    Room = reader.GetString(3),
                                    Status = reader.GetString(4),
                                    PatientName = reader.GetString(5),
                                    ServiceName = reader.GetString(6),
                                    ImagePath = reader.GetString(7)
                                });
                            }
                            DgSchedule.ItemsSource = schedule;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки расписания: " + ex.Message);
            }
        }

        private void DgSchedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgSchedule.SelectedItem is ScheduleItem item)
            {
                TbServiceName.Text = item.ServiceName;

                if (!string.IsNullOrEmpty(item.ImagePath))
                {
                    try
                    {
                        ImgService.Source = new BitmapImage(new Uri($"pack://application:,,,/Images/{item.ImagePath}"));
                    }
                    catch
                    {
                        ImgService.Source = null;
                    }
                }
                else
                {
                    ImgService.Source = null;
                }
            }
        }

        private void DpDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadSchedule();
        }

        private void CbDoctors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadSchedule();
        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadSchedule();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            LoadSchedule();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppointmentCreateWindow createWin = new AppointmentCreateWindow();
            if (createWin.ShowDialog() == true)
            {
                LoadSchedule();
            }
        }

        // Обработчик кнопки отмены записи
        private void BtnCancelAppointment_Click(object sender, RoutedEventArgs e)
        {
            if (DgSchedule.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для отмены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var item = (ScheduleItem)DgSchedule.SelectedItem;

            if (item.Status == "Свободно")
            {
                MessageBox.Show("Нельзя отменить свободный слот!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var result = MessageBox.Show($"Вы уверены, что хотите отменить запись пациента {item.PatientName}?",
                                         "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();

                        // 1. Находим ID записи на прием для этого слота
                        int zapisId = 0;
                        string findSql = "SELECT Kod_zapisi FROM KP_Zapisi_na_priem WHERE Kod_slota = @slotId";
                        using (SqlCommand cmd = new SqlCommand(findSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@slotId", item.KodSlota);
                            object res = cmd.ExecuteScalar();
                            if (res != null) zapisId = Convert.ToInt32(res);
                        }

                        if (zapisId > 0)
                        {
                            // 2. Удаляем результаты приема (если есть)
                            string deleteResultSql = "DELETE FROM KP_Rezultaty_priema WHERE Kod_zapisi = @zapisId";
                            using (SqlCommand cmd = new SqlCommand(deleteResultSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@zapisId", zapisId);
                                cmd.ExecuteNonQuery();
                            }

                            // 3. Удаляем связь с услугами
                            string deleteUslugaSql = "DELETE FROM KP_Uslugi_Zapisi WHERE Kod_Zapisi = @zapisId";
                            using (SqlCommand cmd = new SqlCommand(deleteUslugaSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@zapisId", zapisId);
                                cmd.ExecuteNonQuery();
                            }

                            // 4. Удаляем саму запись на прием
                            string deleteSql = "DELETE FROM KP_Zapisi_na_priem WHERE Kod_zapisi = @zapisId";
                            using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@zapisId", zapisId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // 5. Обновляем статус слота на "Свободно" (1)
                        string updateSql = "UPDATE KP_Raspisanie SET Status = 1 WHERE Kod_slota = @slotId";
                        using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@slotId", item.KodSlota);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Запись успешно отменена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoadSchedule();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при отмене записи: " + ex.Message);
                }
            }
        }

        private void DgSchedule_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (DgSchedule.SelectedItem is ScheduleItem item)
            {
                if (item.Status != "Свободно")
                {
                    MessageBox.Show("Этот слот уже занят. Выберите свободное время.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                AppointmentCreateWindow createWin = new AppointmentCreateWindow(item.KodSlota);
                if (createWin.ShowDialog() == true)
                {
                    LoadSchedule();
                }
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Close();
        }

        private void BtnAddTime_Click(object sender, RoutedEventArgs e)
        {
            AddTimeWindow addWin = new AddTimeWindow();
            if (addWin.ShowDialog() == true)
            {
                LoadSchedule(); 
            }
        }

        private void BtnAddPatient_Click(object sender, RoutedEventArgs e)
        {
            PatientEditWindow editWin = new PatientEditWindow();

            // ShowDialog() блокирует главное окно, пока пользователь не закроет форму
            if (editWin.ShowDialog() == true)
            {
                // Если пациент успешно добавлен, окно вернет true.
                // Можно обновить список, если нужно, или просто сообщить пользователю.
                MessageBox.Show("Пациент успешно добавлен! Теперь его можно выбрать при записи.",
                                "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }

    public class ScheduleItem
    {
        public int KodSlota { get; set; }
        public string Time { get; set; }
        public string DoctorName { get; set; }
        public string Room { get; set; }
        public string PatientName { get; set; }
        public string Status { get; set; }
        public string ServiceName { get; set; }
        public string ImagePath { get; set; }
    }
}