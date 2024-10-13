using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fotoalbom
{
    public partial class Form_albom : Form
    {
        private string connectionString;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public Form_albom()
        {
            InitializeComponent();
            connectionString = "Data Source=MICKUCHAAN;Initial Catalog=Photoalbum;Integrated Security=True";
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter(@"
            SELECT Albums.id_albom, Albums.title, Albums.date_create, Users.username
            FROM Albums
            JOIN Users ON Albums.users_id = Users.id_user", connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView_albom.DataSource = dataTable;

                dataGridView_albom.Columns["id_albom"].HeaderText = "Альбом";
                dataGridView_albom.Columns["title"].HeaderText = "Название";
                dataGridView_albom.Columns["date_create"].HeaderText = "Дата создания";
                dataGridView_albom.Columns["username"].HeaderText = "Пользователь";
            }
        }
    
        private void button_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string username = textBox_polz.Text;
                string userIdQuery = "SELECT id_user FROM Users WHERE username = @username";

                int usersId;

                using (SqlCommand userIdCommand = new SqlCommand(userIdQuery, connection))
                {
                    userIdCommand.Parameters.AddWithValue("@username", username);
                    object result = userIdCommand.ExecuteScalar();

                    if (result != null)
                    {
                        usersId = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким именем не найден.");
                        return;
                    }
                }

                string query = "INSERT INTO Albums(id_albom , users_id, title, date_create) VALUES(@id_albom, @users_id, @title, @date_create)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string input1 = textBox_nomer_alboma.Text;
                    string input3 = textBox_name.Text;
                    string input4 = textBox_data.Text;

                    if (!string.IsNullOrWhiteSpace(input1) &&
                        !string.IsNullOrWhiteSpace(username) &&
                        !string.IsNullOrWhiteSpace(input3) &&
                        !string.IsNullOrWhiteSpace(input4))
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            if (row["id_albom"].ToString() == input1)
                            {
                                MessageBox.Show("Альбом с таким ID уже существует.");
                                return;
                            }
                        }

                        command.Parameters.AddWithValue("@id_albom", input1);
                        command.Parameters.AddWithValue("@users_id", usersId);
                        command.Parameters.AddWithValue("@title", input3);
                        command.Parameters.AddWithValue("@date_create", input4);

                        command.ExecuteNonQuery();

                        DataRow newRow = dataTable.NewRow();
                        newRow["id_albom"] = input1;
                        newRow["username"] = username;
                        newRow["title"] = input3;
                        newRow["date_create"] = input4;

                        dataTable.Rows.Add(newRow);

                        MessageBox.Show("Альбом добавлен успешно.");
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля перед добавлением.");
                    }
                }
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (dataGridView_albom.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_albom.SelectedRows[0];
                string idToDelete = selectedRow.Cells["id_albom"].Value.ToString();

                DeleteFromDatabase(idToDelete);
                LoadData();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.");
            }
        }
        private void DeleteFromDatabase(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Albums WHERE id_albom = @id_albom";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_albom", id);
                    command.ExecuteNonQuery();
                }
            }
        }


        private void button_red_Click(object sender, EventArgs e)
        {
            if (dataGridView_albom.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_albom.SelectedRows[0];
                string idToEdit = selectedRow.Cells["id_albom"].Value.ToString(); 

                string userIdQuery = "SELECT id_user FROM Users WHERE username = @username";
                int usersId;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand userIdCommand = new SqlCommand(userIdQuery, connection))
                    {
                        userIdCommand.Parameters.AddWithValue("@username", textBox_polz.Text);
                        object result = userIdCommand.ExecuteScalar();

                        if (result != null)
                        {
                            usersId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Пользователь с таким именем не найден.");
                            return;
                        }
                    }

                    string updateQuery = "UPDATE Albums SET users_id = @users_id, title = @title, date_create = @date_create WHERE id_albom = @id_albom";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id_albom", idToEdit);
                        command.Parameters.AddWithValue("@users_id", usersId);
                        command.Parameters.AddWithValue("@title", textBox_name.Text);
                        command.Parameters.AddWithValue("@date_create", textBox_data.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Альбом изменён успешно.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось изменить альбом. Проверьте данные.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите альбом для изменения.");
            }
        }
    }
}
