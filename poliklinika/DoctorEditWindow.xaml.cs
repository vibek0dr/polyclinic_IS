using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

namespace poliklinika
{
    public partial class DoctorEditWindow : Window
    {
        private string connStr = "Server=stud-mssql.sttec.yar.ru,38325;Database=user84_db;User Id=user84_db;Password=user84;TrustServerCertificate=True;";
        private int? _doctorId = null; // Если null - создаем нового, иначе редактируем

        // Конструктор для ДОБАВЛЕНИЯ
        public DoctorEditWindow()
        {
            InitializeComponent();
            LoadSpecializations();
        }

        // Конструктор для РЕДАКТИРОВАНИЯ
        public DoctorEditWindow(int doctorId)
        {
            InitializeComponent();
            _doctorId = doctorId;
            LoadSpecializations();
            LoadDoctorData();
        }

        private void LoadSpecializations()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT Kod_specializacii, Nazvanie_specializacii FROM KP_Specializacii";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        var specs = new System.Collections.Generic.List<dynamic>();
                        while (reader.Read())
                        {
                            specs.Add(new { Kod_specializacii = reader.GetInt32(0), Nazvanie_specializacii = reader.GetString(1) });
                        }
                        CbSpecialization.ItemsSource = specs;
                    }
                }
            }
        }

        private void LoadDoctorData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = @"
                    SELECT v.Familiya, v.Imya, v.Otchestvo, v.Kod_specializacii, v.Nomer_kabineta, v.Telefon, p.Login, p.Parol
                    FROM KP_Vrachi v
                    INNER JOIN KP_Polzovateli p ON v.Kod_polzovatelya = p.Kod_polzovatelya
                    WHERE v.Kod_vracha = @id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _doctorId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TbLastName.Text = reader.GetString(0);
                            TbFirstName.Text = reader.GetString(1);
                            TbMiddleName.Text = reader.GetString(2);
                            CbSpecialization.SelectedValue = reader.GetInt32(3);
                            TbRoom.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            TbPhone.Text = reader.IsDBNull(5) ? "" : reader.GetString(5);
                            TbLogin.Text = reader.GetString(6);
                            TbPassword.Text = reader.GetString(7);
                        }
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbLastName.Text) || CbSpecialization.SelectedValue == null ||
                string.IsNullOrWhiteSpace(TbLogin.Text) || string.IsNullOrWhiteSpace(TbPassword.Text))
            {
                MessageBox.Show("Заполните обязательные поля!", "Ошибка");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    if (_doctorId == null) // СОЗДАНИЕ
                    {
                        // 1. Создаем пользователя
                        string insertUserSql = @"
                            INSERT INTO KP_Polzovateli (Login, Parol, Kod_roli) 
                            VALUES (@login, @password, 3);
                            SELECT SCOPE_IDENTITY();";
                        int newUserId;
                        using (SqlCommand cmd = new SqlCommand(insertUserSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@login", TbLogin.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", TbPassword.Text.Trim());
                            newUserId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. Создаем врача
                        string insertDoctorSql = @"
                            INSERT INTO KP_Vrachi (Kod_polzovatelya, Familiya, Imya, Otchestvo, Kod_specializacii, Nomer_kabineta, Telefon) 
                            VALUES (@userId, @lastName, @firstName, @middleName, @specId, @room, @phone)";
                        using (SqlCommand cmd = new SqlCommand(insertDoctorSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", newUserId);
                            cmd.Parameters.AddWithValue("@lastName", TbLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@firstName", TbFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@middleName", TbMiddleName.Text.Trim());
                            cmd.Parameters.AddWithValue("@specId", CbSpecialization.SelectedValue);
                            cmd.Parameters.AddWithValue("@room", TbRoom.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", TbPhone.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else // РЕДАКТИРОВАНИЕ
                    {
                        // 1. Получаем ID пользователя
                        int userId;
                        string getUserIdSql = "SELECT Kod_polzovatelya FROM KP_Vrachi WHERE Kod_vracha = @id";
                        using (SqlCommand cmd = new SqlCommand(getUserIdSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", _doctorId);
                            userId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. Обновляем пользователя
                        string updateUserSql = "UPDATE KP_Polzovateli SET Login = @login, Parol = @password WHERE Kod_polzovatelya = @userId";
                        using (SqlCommand cmd = new SqlCommand(updateUserSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@login", TbLogin.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", TbPassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.ExecuteNonQuery();
                        }

                        // 3. Обновляем врача
                        string updateDoctorSql = @"
                            UPDATE KP_Vrachi SET 
                                Familiya = @lastName, Imya = @firstName, Otchestvo = @middleName, 
                                Kod_specializacii = @specId, Nomer_kabineta = @room, Telefon = @phone
                            WHERE Kod_vracha = @id";
                        using (SqlCommand cmd = new SqlCommand(updateDoctorSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@lastName", TbLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@firstName", TbFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@middleName", TbMiddleName.Text.Trim());
                            cmd.Parameters.AddWithValue("@specId", CbSpecialization.SelectedValue);
                            cmd.Parameters.AddWithValue("@room", TbRoom.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", TbPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", _doctorId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Данные сохранены!", "Успех");
                this.DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}