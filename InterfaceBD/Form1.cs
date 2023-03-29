using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace InterfaceBD

{
    public partial class Form1 : Form
    {
        string? DataSource;
        string? InitialCatalog;
                
        public Form1()
        {
            InitializeComponent();

            Width = 800;
            Height = 500;
            connectionPanel.Dock = DockStyle.Fill;
            createPanel.Dock = DockStyle.Fill;
            readPanel.Dock = DockStyle.Fill;
            updatePanel.Dock = DockStyle.Fill;
            deletePanel.Dock = DockStyle.Fill;

            connection.BackColor = Color.White;
            connectionPanel.Visible = true;
        }

        string GetConnectionString(string dataSource, string initialCatalog)
        {
            return @"Data Source = " + dataSource + "; Initial Catalog = " + initialCatalog + "; Trusted_Connection=True; Encrypt = False";
        }

        private void connection_Click(object sender, EventArgs e)
        {
            connection.BackColor = Color.White;

            Create.BackColor = Color.Gainsboro;
            read.BackColor = Color.Gainsboro;
            update.BackColor = Color.Gainsboro;
            delete.BackColor = Color.Gainsboro;

            connectionPanel.Visible = true;
            
            createPanel.Visible = false;
            readPanel.Visible = false;
            updatePanel.Visible = false;
            deletePanel.Visible = false;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Create.BackColor = Color.White;

            connection.BackColor = Color.Gainsboro;                        
            read.BackColor = Color.Gainsboro;
            update.BackColor = Color.Gainsboro;
            delete.BackColor = Color.Gainsboro;

            createPanel.Visible = true;            

            connectionPanel.Visible = false;
            readPanel.Visible = false;
            updatePanel.Visible = false;
            deletePanel.Visible = false;
        }

        private void read_Click(object sender, EventArgs e)
        {
            read.BackColor = Color.White;

            connection.BackColor = Color.Gainsboro;
            Create.BackColor = Color.Gainsboro;            
            update.BackColor = Color.Gainsboro;
            delete.BackColor = Color.Gainsboro;

            readPanel.Visible = true;
            
            connectionPanel.Visible = false;
            createPanel.Visible = false;
            updatePanel.Visible = false;
            deletePanel.Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            update.BackColor = Color.White;

            connection.BackColor = Color.Gainsboro;
            Create.BackColor = Color.Gainsboro;
            read.BackColor = Color.Gainsboro;
            delete.BackColor = Color.Gainsboro;

            updatePanel.Visible = true;

            connectionPanel.Visible = false;
            createPanel.Visible = false;
            readPanel.Visible = false;
            deletePanel.Visible = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            delete.BackColor = Color.White;

            connection.BackColor = Color.Gainsboro;
            Create.BackColor = Color.Gainsboro;
            read.BackColor = Color.Gainsboro;
            update.BackColor = Color.Gainsboro;
            
            deletePanel.Visible=true;

            connectionPanel.Visible = false;
            createPanel.Visible = false;
            readPanel.Visible = false;
            updatePanel.Visible = false;
        }

        private void connectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connection_ServerName_TextChanged(object sender, EventArgs e)
        {
            DataSource = connection_ServerName.Text;

            if (DataSource?.Length == 0)
            {
                connection_ErrorMassage.Text = "Поле Имя сервера не может быть пустым";
                connection_ErrorMassage.Visible = true;
            }
            else
            {
                connection_ErrorMassage.Visible = false;
            }                
        }

        private void connection_DataBaseNameField_TextChanged(object sender, EventArgs e)
        {
            InitialCatalog = connection_DataBaseNameField.Text;
        }

        private void create_NewDB_Click(object sender, EventArgs e)
        {
            InitialCatalog = create_DateBaseNameField.Text;

            if (InitialCatalog?.Length == 0)
            {
                create_ErrorMassage.Text = "Поле Имя базы данных не может быть пустым";
                create_ErrorMassage.Visible = true;
            }
            else
            {
                create_ErrorMassage.Visible = false;

                try
                {
                    using (SqlConnection connection = new SqlConnection(GetConnectionString(DataSource, "master")))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();

                        command.CommandText = $"CREATE DATABASE {InitialCatalog}";

                        command.Connection = connection;

                        command.ExecuteNonQuery();
                    }

                    create_SuccesfullMassage.Visible = true;
                }
                catch (Exception)
                {
                    create_ErrorMassage.Visible = true;
                    create_ErrorMassage.Text = "Ошибка при работе с базой данных";
                }                
            }
        }

        private void create_Table_Click(object sender, EventArgs e)
        {
            InitialCatalog = create_DataBaseNameFieldFromTable.Text;

            if (InitialCatalog?.Length == 0 || create_TableNameField.Text?.Length == 0 || create_ColumnsName.Text?.Length == 0)
            {
                create_ErrorMassage.Text = "Поля Имя базы данных, Имя таблицы, Имя столбцов не могут быть пустыми";
                create_ErrorMassage.Visible = true;
            }
            else
            {
                create_ErrorMassage.Visible = false;

                try
                {
                    using (SqlConnection connection = new SqlConnection(GetConnectionString(DataSource, InitialCatalog)))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();

                        command.CommandText = $"CREATE TABLE {create_TableNameField.Text}({create_ColumnsName.Text});";

                        command.Connection = connection;

                        command.ExecuteNonQuery();
                    }

                    create_SuccesfullMassage.Visible = true;
                }
                catch (Exception)
                {
                    create_ErrorMassage.Visible = true;
                    create_ErrorMassage.Text = "Ошибка при работе с базой данных";
                }
            }                
        }

        private void read_readTableList_Click(object sender, EventArgs e)
        {
            InitialCatalog = read_NameBDField.Text;

            if (InitialCatalog?.Length == 0 || DataSource?.Length == 0)
            {
                if(DataSource != null)
                    read_ErrorMassage.Text = "Поле Имя базы данных не может быть пустым";
                else
                    read_ErrorMassage.Text = "Поле Имя сервера не может быть пустым";

                read_ErrorMassage.Visible = true;
            }
            else
            {
                read_ErrorMassage.Visible = false;

                try
                {
                    using (SqlConnection connection = new SqlConnection(GetConnectionString(DataSource, InitialCatalog)))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES";
                        command.Connection = connection;

                        SqlDataReader reader = command.ExecuteReader();
                                            
                        if(reader.HasRows)
                        {
                            int columnCount = reader.FieldCount;

                            List<string> columnName = new List<string>();

                            for (int i = 0; i < columnCount; i++)
                            {
                                columnName.Add(reader.GetName(i));
                            }

                            List<List<string>> rowsValues = new List<List<string>>();

                            while (reader.Read())
                            {
                                var tempList = new List<string>();
                                for (int i = 0; i < columnCount; i++)
                                {
                                    tempList.Add(reader.GetValue(i).ToString() ?? "NULL");
                                }

                                rowsValues.Add(tempList);
                            }

                            connection.Close();


                            TableList tableList = new TableList() { Text = InitialCatalog };

                            var table = new TableLayoutPanel()
                            {
                                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                                RowCount = 0,
                                ColumnCount = columnCount,
                                Dock = DockStyle.Fill
                            };

                            for (int i = 0; i < rowsValues.Count; i++)
                            {
                                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                            }

                            for (int i = 0; i < columnName.Count; i++)
                            {
                                table.Controls.Add(new Label() { Text = columnName[i], Dock = DockStyle.Fill, Font = new Font(FontFamily.GenericSansSerif,11f, FontStyle.Bold) }, i, 0);
                            }

                            for (int i = 0; i < rowsValues.Count; i++)
                            {
                                for (int j = 0; j < rowsValues[i].Count; j++)
                                {
                                    table.Controls.Add(new Label() { Text = rowsValues[i][j], Dock = DockStyle.Fill }, j, i + 1);
                                }
                            }

                            tableList.Controls.Add(table);

                            tableList.Width = 500;
                            tableList.Height = 30 * rowsValues.Count + 90;

                            tableList.Show();

                            read_SuccesfullMassage.Visible = true;
                        }
                    }
                }
                catch (Exception)
                {
                    read_ErrorMassage.Visible = true;
                    read_ErrorMassage.Text = "Ошибка при работе с базой данных";
                }
            }                
        }

        private void read_readData_Click(object sender, EventArgs e)
        {
            InitialCatalog = read_NameBDField.Text;

            if (InitialCatalog?.Length == 0 || read_TableNameField.Text?.Length == 0)
            {
                if(DataSource != null)
                    read_ErrorMassage.Text = "Поле Имя базы данных не может быть пустым";
                else
                    read_ErrorMassage.Text = "Поле Имя сервера не может быть пустым";
                read_ErrorMassage.Visible = true;
            }
            else
            {
                read_ErrorMassage.Visible = false;

                try
                {
                    using (SqlConnection connection = new SqlConnection(GetConnectionString(DataSource, InitialCatalog)))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();

                        if(read_allColumns.Checked)
                            command.CommandText = $"SELECT * FROM {read_TableNameField.Text}";
                        if(read_customColumns.Checked)
                            command.CommandText = $"SELECT {read_ColumnsNameField.Text} FROM {read_TableNameField.Text}";

                        command.Connection = connection;

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            int columnCount = reader.FieldCount;

                            List<string> columnName = new List<string>();

                            for (int i = 0; i < columnCount; i++)
                            {
                                columnName.Add(reader.GetName(i));
                            }

                            List<List<string>> rowsValues = new List<List<string>>();

                            while (reader.Read())
                            {
                                var tempList = new List<string>();
                                for (int i = 0; i < columnCount; i++)
                                {
                                    tempList.Add(reader.GetValue(i).ToString() ?? "NULL");
                                }

                                rowsValues.Add(tempList);
                            }

                            connection.Close();


                            TableList tableList = new TableList() { Text = InitialCatalog };

                            var table = new TableLayoutPanel()
                            {
                                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                                RowCount = 0,
                                ColumnCount = columnCount,
                                Dock = DockStyle.Fill
                            };

                            for (int i = 0; i < rowsValues.Count; i++)
                            {
                                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                            }

                            for (int i = 0; i < columnName.Count; i++)
                            {
                                table.Controls.Add(new Label() { Text = columnName[i], Dock = DockStyle.Fill, Font = new Font(FontFamily.GenericSansSerif, 11f, FontStyle.Bold) }, i, 0);
                            }

                            for (int i = 0; i < rowsValues.Count; i++)
                            {
                                for (int j = 0; j < rowsValues[i].Count; j++)
                                {
                                    table.Controls.Add(new Label() { Text = rowsValues[i][j], Dock = DockStyle.Fill }, j, i + 1);
                                }
                            }

                            tableList.Controls.Add(table);

                            tableList.Width = 500;
                            tableList.Height = 30 * rowsValues.Count + 90;

                            tableList.Show();

                            read_SuccesfullMassage.Visible = true;
                        }
                    }
                }
                catch (Exception)
                {
                    read_ErrorMassage.Visible = true;
                    read_ErrorMassage.Text = "Ошибка при работе с базой данных";
                }
            }                
        }

        private void update_UpdateValue_Click(object sender, EventArgs e)
        {
            InitialCatalog = update_DBNameField.Text;
            if(DataSource?.Length == 0)
            {
                update_ErrorMassage.Text = "Поле Имя сервера должно быть заполнено";
                update_ErrorMassage.Visible = true;
            }
            else
            {
                update_ErrorMassage.Visible = false;
            }

            if(InitialCatalog?.Length == 0 || update_TableNameField.Text?.Length == 0 || update_ColumnNameField.Text?.Length == 0
                || update_NewValueField.Text?.Length == 0 || update_FilterColumnNameField.Text?.Length == 0 || update_FilterColumnValueField.Text?.Length == 0)
            {
                update_ErrorMassage.Text = "Все поля должны быть заполнены";
                update_ErrorMassage.Visible = true;
            }
            else
            {
                update_ErrorMassage.Visible = false;

                try
                {
                    using (SqlConnection connection = new SqlConnection(GetConnectionString(DataSource, InitialCatalog)))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();

                        command.CommandText = $"UPDATE {update_TableNameField.Text} SET {update_ColumnNameField.Text} = '{update_NewValueField.Text}'" +
                            $" WHERE {update_FilterColumnNameField.Text} = '{update_FilterColumnValueField.Text}';";

                        command.Connection = connection;

                        command.ExecuteNonQuery();

                        connection.Close();
                    }

                    update_SuccesfullMassage.Visible = true;
                }
                catch (Exception)
                {
                    update_ErrorMassage.Text = "Ошибка при работе с базой данных";
                    update_ErrorMassage.Visible = true;
                }
            }
        }

        private void delete_ErrorMassage_Click(object sender, EventArgs e)
        {

        }

        private void delete_DeleteDataBase_Click(object sender, EventArgs e)
        {
            InitialCatalog = delete_DBNameField.Text;

            if (DataSource?.Length == 0)
            {
                delete_ErrorMassage.Text = "Поле Имя сервера должно быть заполнено";
                delete_ErrorMassage.Visible = true;
            }
            else
            {
                delete_ErrorMassage.Visible = false;
            }

            if (InitialCatalog?.Length == 0)
            {
                delete_ErrorMassage.Text = "Поле Имя базы данных не может быть пустым";
                delete_ErrorMassage.Visible = true;
            }
            else
            {
                delete_ErrorMassage.Visible = false;

                try
                {
                    using (SqlConnection connection = new SqlConnection(GetConnectionString(DataSource, "master")))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();

                        command.CommandText = $"DROP DATABASE {delete_DBNameField.Text}";

                        command.Connection = connection;

                        command.ExecuteNonQuery();

                        connection.Close();
                    }

                    update_SuccesfullMassage.Visible = true;
                }
                catch (Exception)
                {
                    delete_ErrorMassage.Text = "Ошибка при работе с базой данных";
                    delete_ErrorMassage.Visible = true;
                }
            }
        }

        private void delete_DeleteTable_Click(object sender, EventArgs e)
        {
            InitialCatalog = delete_DBNameField.Text;

            if (DataSource?.Length == 0)
            {
                delete_ErrorMassage.Text = "Поле Имя сервера должно быть заполнено";
                delete_ErrorMassage.Visible = true;
            }
            else
            {
                delete_ErrorMassage.Visible = false;
            }

            if (InitialCatalog?.Length == 0)
            {
                delete_ErrorMassage.Text = "Поле Имя базы данных не может быть пустым";
                delete_ErrorMassage.Visible = true;
            }
            else
            {
                delete_ErrorMassage.Visible = false;

                try
                {
                    using (SqlConnection connection = new SqlConnection(GetConnectionString(DataSource, InitialCatalog)))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();

                        command.CommandText = $"DROP TABLE {delete_TableNameField.Text}";

                        command.Connection = connection;

                        command.ExecuteNonQuery();

                        connection.Close();
                    }

                    delete_SuccesfullMassage.Visible = true;
                }
                catch (Exception)
                {
                    delete_ErrorMassage.Text = "Ошибка при работе с базой данных";
                    delete_ErrorMassage.Visible = true;
                }
            }
        }

        private void delete_DeleteRows_Click(object sender, EventArgs e)
        {
            InitialCatalog = delete_DBNameField.Text;

            if (DataSource?.Length == 0)
            {
                delete_ErrorMassage.Text = "Поле Имя сервера должно быть заполнено";
                delete_ErrorMassage.Visible = true;
            }
            else
            {
                delete_ErrorMassage.Visible = false;
            }

            if (InitialCatalog?.Length == 0)
            {
                delete_ErrorMassage.Text = "Поле Имя базы данных не может быть пустым";
                delete_ErrorMassage.Visible = true;
            }
            else
            {
                delete_ErrorMassage.Visible = false;

                try
                {
                    using (SqlConnection connection = new SqlConnection(GetConnectionString(DataSource, InitialCatalog)))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();

                        command.CommandText = $"DELETE FROM {delete_TableNameField.Text} WHERE {delete_ColumnNameField.Text} = '{delete_RowsValueField.Text}'";

                        command.Connection = connection;

                        command.ExecuteNonQuery();

                        connection.Close();
                    }

                    delete_SuccesfullMassage.Visible = true;
                }
                catch (Exception)
                {
                    delete_ErrorMassage.Text = "Ошибка при работе с базой данных";
                    delete_ErrorMassage.Visible = true;
                }
            }
        }

        private void connection_SuccesfullMassage_Click(object sender, EventArgs e)
        {
            connection_SuccesfullMassage.Visible = false;
        }

        private void create_SuccesfullMassage_Click(object sender, EventArgs e)
        {
            create_SuccesfullMassage.Visible = false;
        }

        private void read_SuccesfullMassage_Click(object sender, EventArgs e)
        {
            read_SuccesfullMassage.Visible = false;
        }

        private void update_SuccesfullMassage_Click(object sender, EventArgs e)
        {
            update_SuccesfullMassage.Visible = false;
        }

        private void delete_SuccesfullMassage_Click(object sender, EventArgs e)
        {
            delete_SuccesfullMassage.Visible = false;
        }

        private void read_allColumns_CheckedChanged(object sender, EventArgs e)
        {
            read_readData.Location = new Point(275, 330);

            read_ColumnsNameField.Visible = false;
            read_labelColumnName.Visible = false;
        }

        private void read_customColumns_CheckedChanged(object sender, EventArgs e)
        {
            read_readData.Location = new Point(275, 360);

            read_ColumnsNameField.Visible = true;
            read_labelColumnName.Visible = true;
        }
    }
}