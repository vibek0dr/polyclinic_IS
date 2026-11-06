using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace poliklinika
{
    public partial class AddTimeWindow : Window
    {
        private string connStr = "Server=stud-mssql.sttec.yar.ru,38325;Database=user84_db;User Id=user84_db;Password=user84;TrustServerCertificate=True;";

        public AddTimeWindow()
        {
            InitializeComponent();
            DpDate.SelectedDate = DateTime.Today;
            LoadDoctors();
        }

        private void LoadDoctors()
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
                        CbDoctor.ItemsSource = doctors;
                        CbDoctor.DisplayMemberPath = "Fio";
                        CbDoctor.SelectedValuePath = "Kod_vracha";
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (CbDoctor.SelectedValue == null || DpDate.SelectedDate == null ||
                string.IsNullOrWhiteSpace(TbTimeStart.Text) || string.IsNullOrWhiteSpace(TbTimeEnd.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"INSERT INTO KP_Raspisanie (Kod_vracha, Data_priema, Vremya_nachala, Vremya_okonchaniya, Status) 
                                   VALUES (@vrach, @date, @start, @end, 1)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@vrach", CbDoctor.SelectedValue);
                        cmd.Parameters.AddWithValue("@date", DpDate.SelectedDate);
                        cmd.Parameters.AddWithValue("@start", TimeSpan.Parse(TbTimeStart.Text));
                        cmd.Parameters.AddWithValue("@end", TimeSpan.Parse(TbTimeEnd.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Время успешно добавлено!", "Успех");
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