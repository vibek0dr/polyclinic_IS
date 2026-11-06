using System;
using System.Data.SqlClient;
using System.Windows;

namespace poliklinika
{
    public partial class RegistrarEditWindow : Window
    {
        private string connStr = "Server=stud-mssql.sttec.yar.ru,38325;Database=user84_db;User Id=user84_db;Password=user84;TrustServerCertificate=True;";
        private int? _userId = null; // Если null - создаем, иначе редактируем

        public RegistrarEditWindow()
        {
            InitializeComponent();
        }

        public RegistrarEditWindow(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadRegistrarData();
        }

        private void LoadRegistrarData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = @"
                    SELECT p.Login, p.Parol, r.Familiya, r.Imya, r.Otchestvo, r.Telefon, r.Adres
                    FROM KP_Polzovateli p
                    LEFT JOIN KP_Registrator r ON p.Kod_polzovatelya = r.Kod_polzovatelya
                    WHERE p.Kod_polzovatelya = @id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TbLogin.Text = reader.GetString(0);
                            TbPassword.Text = reader.GetString(1);
                            TbLastName.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                            TbFirstName.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            TbMiddleName.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            TbPhone.Text = reader.IsDBNull(5) ? "" : reader.GetString(5);
                            TbAddress.Text = reader.IsDBNull(6) ? "" : reader.GetString(6);
                        }
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbLogin.Text) || string.IsNullOrWhiteSpace(TbPassword.Text))
            {
                MessageBox.Show("Заполните логин и пароль!", "Ошибка");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    if (_userId == null) // СОЗДАНИЕ
                    {
                        // 1. Создаем пользователя
                        string insertUserSql = @"
                            INSERT INTO KP_Polzovateli (Login, Parol, Kod_roli) 
                            VALUES (@login, @password, 2);
                            SELECT SCOPE_IDENTITY();";
                        int newUserId;
                        using (SqlCommand cmd = new SqlCommand(insertUserSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@login", TbLogin.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", TbPassword.Text.Trim());
                            newUserId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. Создаем запись в KP_Registrator
                        string insertRegSql = @"
                            INSERT INTO KP_Registrator (Kod_polzovatelya, Familiya, Imya, Otchestvo, Adres, Telefon) 
                            VALUES (@userId, @lastName, @firstName, @middleName, @address, @phone)";
                        using (SqlCommand cmd = new SqlCommand(insertRegSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", newUserId);
                            cmd.Parameters.AddWithValue("@lastName", TbLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@firstName", TbFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@middleName", TbMiddleName.Text.Trim());
                            cmd.Parameters.AddWithValue("@address", TbAddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", TbPhone.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else // РЕДАКТИРОВАНИЕ
                    {
                        // 1. Обновляем пользователя
                        string updateUserSql = "UPDATE KP_Polzovateli SET Login = @login, Parol = @password WHERE Kod_polzovatelya = @userId";
                        using (SqlCommand cmd = new SqlCommand(updateUserSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@login", TbLogin.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", TbPassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@userId", _userId);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Проверяем, есть ли запись в KP_Registrator
                        string checkSql = "SELECT COUNT(*) FROM KP_Registrator WHERE Kod_polzovatelya = @userId";
                        int count;
                        using (SqlCommand cmd = new SqlCommand(checkSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", _userId);
                            count = (int)cmd.ExecuteScalar();
                        }

                        if (count > 0)
                        {
                            // Обновляем
                            string updateRegSql = @"
                                UPDATE KP_Registrator SET 
                                    Familiya = @lastName, Imya = @firstName, Otchestvo = @middleName, 
                                    Adres = @address, Telefon = @phone
                                WHERE Kod_polzovatelya = @userId";
                            using (SqlCommand cmd = new SqlCommand(updateRegSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@lastName", TbLastName.Text.Trim());
                                cmd.Parameters.AddWithValue("@firstName", TbFirstName.Text.Trim());
                                cmd.Parameters.AddWithValue("@middleName", TbMiddleName.Text.Trim());
                                cmd.Parameters.AddWithValue("@address", TbAddress.Text.Trim());
                                cmd.Parameters.AddWithValue("@phone", TbPhone.Text.Trim());
                                cmd.Parameters.AddWithValue("@userId", _userId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Если записи нет (например, старый юзер), создаем её
                            string insertRegSql = @"
                                INSERT INTO KP_Registrator (Kod_polzovatelya, Familiya, Imya, Otchestvo, Adres, Telefon) 
                                VALUES (@userId, @lastName, @firstName, @middleName, @address, @phone)";
                            using (SqlCommand cmd = new SqlCommand(insertRegSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@userId", _userId);
                                cmd.Parameters.AddWithValue("@lastName", TbLastName.Text.Trim());
                                cmd.Parameters.AddWithValue("@firstName", TbFirstName.Text.Trim());
                                cmd.Parameters.AddWithValue("@middleName", TbMiddleName.Text.Trim());
                                cmd.Parameters.AddWithValue("@address", TbAddress.Text.Trim());
                                cmd.Parameters.AddWithValue("@phone", TbPhone.Text.Trim());
                                cmd.ExecuteNonQuery();
                            }
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