using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace poliklinika
{
    public partial class AdminWindow : Window
    {
        private string connStr = "Server=stud-mssql.sttec.yar.ru,38325;Database=user84_db;User Id=user84_db;Password=user84;TrustServerCertificate=True;";

        public AdminWindow()
        {
            InitializeComponent();
            LoadDoctors();
            LoadRegistrars();
        }

        // --- ВРАЧИ ---

        private void LoadDoctors()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT Kod_vracha, Familiya, Imya, Otchestvo, Nomer_kabineta, Telefon FROM KP_Vrachi";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var doctors = new List<dynamic>();
                            while (reader.Read())
                            {
                                doctors.Add(new
                                {
                                    Kod_vracha = reader.GetInt32(0),
                                    Familiya = reader.GetString(1),
                                    Imya = reader.GetString(2),
                                    Otchestvo = reader.GetString(3),
                                    Nomer_kabineta = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                    Telefon = reader.IsDBNull(5) ? "" : reader.GetString(5)
                                });
                            }
                            DgDoctors.ItemsSource = doctors;
                            DgDoctors.SelectedValuePath = "Kod_vracha";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки врачей: " + ex.Message);
            }
        }

        private void BtnAddDoctor_Click(object sender, RoutedEventArgs e)
        {
            DoctorEditWindow editWin = new DoctorEditWindow();
            if (editWin.ShowDialog() == true)
            {
                LoadDoctors();
            }
        }

        private void BtnDeleteDoctor_Click(object sender, RoutedEventArgs e)
        {
            if (DgDoctors.SelectedValue == null)
            {
                MessageBox.Show("Выберите врача для удаления!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            int doctorId = (int)DgDoctors.SelectedValue;

            var result = MessageBox.Show("Вы уверены, что хотите удалить этого врача?", "Подтверждение",
                                         MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        // Получаем ID пользователя, чтобы удалить и его
                        int userId = 0;
                        string getUserIdSql = "SELECT Kod_polzovatelya FROM KP_Vrachi WHERE Kod_vracha = @id";
                        using (SqlCommand cmd = new SqlCommand(getUserIdSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", doctorId);
                            object res = cmd.ExecuteScalar();
                            if (res != null) userId = Convert.ToInt32(res);
                        }

                        // Удаляем врача
                        string deleteDoctorSql = "DELETE FROM KP_Vrachi WHERE Kod_vracha = @id";
                        using (SqlCommand cmd = new SqlCommand(deleteDoctorSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", doctorId);
                            cmd.ExecuteNonQuery();
                        }

                        // Удаляем пользователя
                        if (userId > 0)
                        {
                            string deleteUserSql = "DELETE FROM KP_Polzovateli WHERE Kod_polzovatelya = @userId";
                            using (SqlCommand cmd = new SqlCommand(deleteUserSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@userId", userId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    LoadDoctors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        // --- РЕГИСТРАТОРЫ ---

        private void LoadRegistrars()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"
                SELECT 
                    p.Kod_polzovatelya,
                    p.Login,
                    ISNULL(r.Familiya, '') AS Familiya,
                    ISNULL(r.Imya, '') AS Imya,
                    ISNULL(r.Otchestvo, '') AS Otchestvo,
                    ISNULL(r.Telefon, '') AS Telefon,
                    ISNULL(r.Adres, '') AS Adres
                FROM KP_Polzovateli p
                INNER JOIN KP_Registrator r ON p.Kod_polzovatelya = r.Kod_polzovatelya
                WHERE p.Kod_roli = 2";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var registrars = new List<dynamic>();
                            while (reader.Read())
                            {
                                registrars.Add(new
                                {
                                    Kod_polzovatelya = reader.GetInt32(0),
                                    Login = reader.GetString(1),
                                    Familiya = reader.GetString(2),
                                    Imya = reader.GetString(3),
                                    Otchestvo = reader.GetString(4),
                                    Telefon = reader.GetString(5),
                                    Adres = reader.GetString(6)
                                });
                            }
                            DgRegistrars.ItemsSource = registrars;
                            DgRegistrars.SelectedValuePath = "Kod_polzovatelya"; // Для удаления используем ID пользователя
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        private void BtnEditDoctor_Click(object sender, RoutedEventArgs e)
        {
            if (DgDoctors.SelectedValue == null)
            {
                MessageBox.Show("Выберите врача для редактирования!", "Ошибка");
                return;
            }

            int doctorId = (int)DgDoctors.SelectedValue;
            DoctorEditWindow editWin = new DoctorEditWindow(doctorId);
            if (editWin.ShowDialog() == true)
            {
                LoadDoctors();
            }
        }

        private void BtnEditRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (DgRegistrars.SelectedValue == null)
            {
                MessageBox.Show("Выберите регистратора для редактирования!", "Ошибка");
                return;
            }

            int userId = (int)DgRegistrars.SelectedValue; // В LoadRegistrars мы использовали SelectedValuePath = "Kod_polzovatelya"
            RegistrarEditWindow editWin = new RegistrarEditWindow(userId);
            if (editWin.ShowDialog() == true)
            {
                LoadRegistrars();
            }
        }

     

        private void BtnAddRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Открываем простое окно для ввода логина/пароля регистратора
            RegistrarEditWindow editWin = new RegistrarEditWindow();
            if (editWin.ShowDialog() == true)
            {
                LoadRegistrars();
            }
        }

        private void BtnDeleteRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (DgRegistrars.SelectedValue == null)
            {
                MessageBox.Show("Выберите регистратора для удаления!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Это ID пользователя (Kod_polzovatelya), так как в LoadRegistrars мы указали SelectedValuePath = "Kod_polzovatelya"
            int userId = (int)DgRegistrars.SelectedValue;

            var result = MessageBox.Show("Вы уверены, что хотите удалить этого регистратора?", "Подтверждение",
                                         MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();

                        // 1. Удаляем из KP_Registrator (если есть)
                        string deleteRegSql = "DELETE FROM KP_Registrator WHERE Kod_polzovatelya = @userId";
                        using (SqlCommand cmd = new SqlCommand(deleteRegSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Удаляем из KP_Polzovateli
                        string deleteUserSql = "DELETE FROM KP_Polzovateli WHERE Kod_polzovatelya = @userId";
                        using (SqlCommand cmd = new SqlCommand(deleteUserSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadRegistrars();
                    MessageBox.Show("Регистратор удален.", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Close();
        }
    }
}