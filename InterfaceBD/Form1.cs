using System.Data.SqlClient;

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

            if (InitialCatalog?.Length == 0 || create_TableNameField.Text?.Length == 0)
            {
                create_ErrorMassage.Text = "Поле Имя базы данных и поле Имя таблицы не может быть пустым";
                create_ErrorMassage.Visible = true;
            }
            else
            {
                create_ErrorMassage.Visible = false;
            }                
        }

        private void read_readTableList_Click(object sender, EventArgs e)
        {
            InitialCatalog = read_NameBDField.Text;

            if (InitialCatalog?.Length == 0)
            {
                read_ErrorMassage.Text = "Поле Имя базы данных не может быть пустым";
                read_ErrorMassage.Visible = true;
            }
            else
            {
                read_ErrorMassage.Visible = false;
            }                
        }

        private void read_readData_Click(object sender, EventArgs e)
        {
            InitialCatalog = read_NameBDField.Text;

            if (InitialCatalog?.Length == 0 || read_TableName.Text?.Length == 0)
            {
                read_ErrorMassage.Text = "Поле Имя базы данных не может быть пустым";
                read_ErrorMassage.Visible = true;
            }
            else
            {
                read_ErrorMassage.Visible = false;
            }                
        }

        private void update_UpdateValue_Click(object sender, EventArgs e)
        {
            InitialCatalog = update_DBNameField.Text;

            if(InitialCatalog?.Length == 0 || update_TableNameField.Text?.Length == 0 || update_ColumnNameField.Text?.Length == 0
                || update_OldValueField.Text?.Length == 0 || update_NewValueField.Text?.Length == 0)
            {
                update_ErrorMassage.Text = "Все поля должны быть заполнены";
                update_ErrorMassage.Visible = true;
            }
            else
            {
                update_ErrorMassage.Visible = false;
            }
        }

        private void delete_ErrorMassage_Click(object sender, EventArgs e)
        {

        }

        private void delete_DeleteDataBase_Click(object sender, EventArgs e)
        {
            InitialCatalog = delete_DBNameField.Text;

            if(InitialCatalog?.Length == 0)
            {
                delete_ErrorMassage.Text = "Поле Имя базы данных не может быть пустым";
                delete_ErrorMassage.Visible = true;
            }
            else
            {
                delete_ErrorMassage.Visible = false;
            }
        }

        private void delete_DeleteTable_Click(object sender, EventArgs e)
        {
            if(delete_DBNameField.Text?.Length == 0 || delete_TableNameField.Text?.Length == 0)
            {
                delete_ErrorMassage.Text = "Поле Имя базы данных или Имя таблицы не может быть пустым";
                delete_ErrorMassage.Visible = true;
            }
            else
            {
                delete_ErrorMassage.Visible = false;
            }


        }

        private void delete_DeleteRows_Click(object sender, EventArgs e)
        {
            if (delete_DBNameField.Text?.Length == 0 || delete_TableNameField.Text?.Length == 0
                || delete_ColumnNameField.Text?.Length == 0 || delete_RowsValueField.Text?.Length == 0)
            {
                delete_ErrorMassage.Text = "Все поля формы должны бфть заполнены";
                delete_ErrorMassage.Visible = true;
            }
            else
            {
                delete_ErrorMassage.Visible = false;
            }
        }
    }
}