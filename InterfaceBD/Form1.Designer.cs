namespace InterfaceBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.connection = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.connection_SuccesfullMassage = new System.Windows.Forms.Label();
            this.connection_ErrorMassage = new System.Windows.Forms.Label();
            this.connection_DataBaseNameField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.connection_IdField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.connection_PasswordField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.connection_ServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createPanel = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.create_ColumnsName = new System.Windows.Forms.TextBox();
            this.create_SuccesfullMassage = new System.Windows.Forms.Label();
            this.create_ErrorMassage = new System.Windows.Forms.Label();
            this.create_Table = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.create_DataBaseNameFieldFromTable = new System.Windows.Forms.TextBox();
            this.create_NewDB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.create_TableNameField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_DateBaseNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.readPanel = new System.Windows.Forms.Panel();
            this.read_labelColumnName = new System.Windows.Forms.Label();
            this.read_ColumnsNameField = new System.Windows.Forms.TextBox();
            this.read_SuccesfullMassage = new System.Windows.Forms.Label();
            this.read_ErrorMassage = new System.Windows.Forms.Label();
            this.read_readData = new System.Windows.Forms.Button();
            this.read_customColumns = new System.Windows.Forms.RadioButton();
            this.read_allColumns = new System.Windows.Forms.RadioButton();
            this.read_readTableList = new System.Windows.Forms.Button();
            this.read_TableNameField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.read_NameBDField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.update_SuccesfullMassage = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.update_FilterColumnNameField = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.update_ErrorMassage = new System.Windows.Forms.Label();
            this.update_NewValueField = new System.Windows.Forms.TextBox();
            this.update_UpdateValue = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.update_TableNameField = new System.Windows.Forms.TextBox();
            this.update_ColumnNameField = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.update_DBNameField = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.delete_SuccesfullMassage = new System.Windows.Forms.Label();
            this.delete_DeleteDataBase = new System.Windows.Forms.Button();
            this.delete_ErrorMassage = new System.Windows.Forms.Label();
            this.delete_DeleteRows = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.delete_RowsValueField = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.delete_ColumnNameField = new System.Windows.Forms.TextBox();
            this.delete_DeleteTable = new System.Windows.Forms.Button();
            this.delete_TableNameField = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.delete_DBNameField = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.update_FilterColumnValueField = new System.Windows.Forms.TextBox();
            this.MenuPanel.SuspendLayout();
            this.connectionPanel.SuspendLayout();
            this.createPanel.SuspendLayout();
            this.readPanel.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.deletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.connection);
            this.MenuPanel.Controls.Add(this.delete);
            this.MenuPanel.Controls.Add(this.read);
            this.MenuPanel.Controls.Add(this.update);
            this.MenuPanel.Controls.Add(this.Create);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(180, 1023);
            this.MenuPanel.TabIndex = 0;
            // 
            // connection
            // 
            this.connection.BackColor = System.Drawing.Color.Gainsboro;
            this.connection.Location = new System.Drawing.Point(12, 12);
            this.connection.Margin = new System.Windows.Forms.Padding(10);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(153, 32);
            this.connection.TabIndex = 3;
            this.connection.Text = "Подключение";
            this.connection.UseVisualStyleBackColor = false;
            this.connection.Click += new System.EventHandler(this.connection_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Gainsboro;
            this.delete.Location = new System.Drawing.Point(12, 212);
            this.delete.Margin = new System.Windows.Forms.Padding(10);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(153, 32);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.Color.Gainsboro;
            this.read.Location = new System.Drawing.Point(12, 112);
            this.read.Margin = new System.Windows.Forms.Padding(10);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(153, 32);
            this.read.TabIndex = 1;
            this.read.Text = "Читать";
            this.read.UseVisualStyleBackColor = false;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Gainsboro;
            this.update.Location = new System.Drawing.Point(12, 162);
            this.update.Margin = new System.Windows.Forms.Padding(10);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(153, 32);
            this.update.TabIndex = 1;
            this.update.Text = "Модифицировать";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.Gainsboro;
            this.Create.Location = new System.Drawing.Point(12, 62);
            this.Create.Margin = new System.Windows.Forms.Padding(10);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(153, 32);
            this.Create.TabIndex = 0;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // connectionPanel
            // 
            this.connectionPanel.Controls.Add(this.connection_SuccesfullMassage);
            this.connectionPanel.Controls.Add(this.connection_ErrorMassage);
            this.connectionPanel.Controls.Add(this.connection_DataBaseNameField);
            this.connectionPanel.Controls.Add(this.label12);
            this.connectionPanel.Controls.Add(this.label11);
            this.connectionPanel.Controls.Add(this.connection_IdField);
            this.connectionPanel.Controls.Add(this.label10);
            this.connectionPanel.Controls.Add(this.connection_PasswordField);
            this.connectionPanel.Controls.Add(this.label7);
            this.connectionPanel.Controls.Add(this.connection_ServerName);
            this.connectionPanel.Controls.Add(this.label1);
            this.connectionPanel.Location = new System.Drawing.Point(186, 12);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(414, 481);
            this.connectionPanel.TabIndex = 1;
            this.connectionPanel.Visible = false;
            // 
            // connection_SuccesfullMassage
            // 
            this.connection_SuccesfullMassage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.connection_SuccesfullMassage.Dock = System.Windows.Forms.DockStyle.Top;
            this.connection_SuccesfullMassage.ForeColor = System.Drawing.Color.SeaGreen;
            this.connection_SuccesfullMassage.Location = new System.Drawing.Point(0, 0);
            this.connection_SuccesfullMassage.Name = "connection_SuccesfullMassage";
            this.connection_SuccesfullMassage.Size = new System.Drawing.Size(414, 23);
            this.connection_SuccesfullMassage.TabIndex = 12;
            this.connection_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            this.connection_SuccesfullMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connection_SuccesfullMassage.Visible = false;
            this.connection_SuccesfullMassage.Click += new System.EventHandler(this.connection_SuccesfullMassage_Click);
            // 
            // connection_ErrorMassage
            // 
            this.connection_ErrorMassage.BackColor = System.Drawing.Color.LavenderBlush;
            this.connection_ErrorMassage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.connection_ErrorMassage.ForeColor = System.Drawing.Color.Red;
            this.connection_ErrorMassage.Location = new System.Drawing.Point(0, 438);
            this.connection_ErrorMassage.Name = "connection_ErrorMassage";
            this.connection_ErrorMassage.Size = new System.Drawing.Size(414, 43);
            this.connection_ErrorMassage.TabIndex = 11;
            this.connection_ErrorMassage.Text = "Error";
            this.connection_ErrorMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connection_ErrorMassage.Visible = false;
            // 
            // connection_DataBaseNameField
            // 
            this.connection_DataBaseNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connection_DataBaseNameField.Location = new System.Drawing.Point(53, 174);
            this.connection_DataBaseNameField.Margin = new System.Windows.Forms.Padding(10);
            this.connection_DataBaseNameField.Name = "connection_DataBaseNameField";
            this.connection_DataBaseNameField.Size = new System.Drawing.Size(308, 27);
            this.connection_DataBaseNameField.TabIndex = 9;
            this.connection_DataBaseNameField.TextChanged += new System.EventHandler(this.connection_DataBaseNameField_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Location = new System.Drawing.Point(53, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(308, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "Введите имя базы данных";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Location = new System.Drawing.Point(53, 227);
            this.label11.Margin = new System.Windows.Forms.Padding(10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 54);
            this.label11.TabIndex = 7;
            this.label11.Text = "Для подключения с проверкой подлинности SQL Server";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connection_IdField
            // 
            this.connection_IdField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connection_IdField.Location = new System.Drawing.Point(53, 314);
            this.connection_IdField.Margin = new System.Windows.Forms.Padding(10);
            this.connection_IdField.Name = "connection_IdField";
            this.connection_IdField.Size = new System.Drawing.Size(308, 27);
            this.connection_IdField.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Location = new System.Drawing.Point(53, 284);
            this.label10.Margin = new System.Windows.Forms.Padding(10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(308, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Введите ID";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connection_PasswordField
            // 
            this.connection_PasswordField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connection_PasswordField.Location = new System.Drawing.Point(53, 393);
            this.connection_PasswordField.Margin = new System.Windows.Forms.Padding(10);
            this.connection_PasswordField.Name = "connection_PasswordField";
            this.connection_PasswordField.Size = new System.Drawing.Size(308, 27);
            this.connection_PasswordField.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Location = new System.Drawing.Point(53, 361);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Введите пароль";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connection_ServerName
            // 
            this.connection_ServerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connection_ServerName.Location = new System.Drawing.Point(53, 88);
            this.connection_ServerName.Margin = new System.Windows.Forms.Padding(10);
            this.connection_ServerName.Name = "connection_ServerName";
            this.connection_ServerName.Size = new System.Drawing.Size(308, 27);
            this.connection_ServerName.TabIndex = 2;
            this.connection_ServerName.Text = "DESKTOP-HHO6PH0";
            this.connection_ServerName.TextChanged += new System.EventHandler(this.connection_ServerName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя сервера для подключения к базе данных";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createPanel
            // 
            this.createPanel.Controls.Add(this.label22);
            this.createPanel.Controls.Add(this.create_ColumnsName);
            this.createPanel.Controls.Add(this.create_SuccesfullMassage);
            this.createPanel.Controls.Add(this.create_ErrorMassage);
            this.createPanel.Controls.Add(this.create_Table);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.create_DataBaseNameFieldFromTable);
            this.createPanel.Controls.Add(this.create_NewDB);
            this.createPanel.Controls.Add(this.label4);
            this.createPanel.Controls.Add(this.create_TableNameField);
            this.createPanel.Controls.Add(this.label5);
            this.createPanel.Controls.Add(this.label3);
            this.createPanel.Controls.Add(this.create_DateBaseNameField);
            this.createPanel.Controls.Add(this.label2);
            this.createPanel.Location = new System.Drawing.Point(620, 12);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(571, 481);
            this.createPanel.TabIndex = 4;
            this.createPanel.Visible = false;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.Location = new System.Drawing.Point(10, 323);
            this.label22.Margin = new System.Windows.Forms.Padding(10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(190, 70);
            this.label22.TabIndex = 15;
            this.label22.Text = "Введи имена столбцов и их параметры разделяя столбцы запятой";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // create_ColumnsName
            // 
            this.create_ColumnsName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_ColumnsName.Location = new System.Drawing.Point(220, 341);
            this.create_ColumnsName.Margin = new System.Windows.Forms.Padding(10);
            this.create_ColumnsName.Name = "create_ColumnsName";
            this.create_ColumnsName.Size = new System.Drawing.Size(308, 27);
            this.create_ColumnsName.TabIndex = 14;
            // 
            // create_SuccesfullMassage
            // 
            this.create_SuccesfullMassage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.create_SuccesfullMassage.Dock = System.Windows.Forms.DockStyle.Top;
            this.create_SuccesfullMassage.ForeColor = System.Drawing.Color.SeaGreen;
            this.create_SuccesfullMassage.Location = new System.Drawing.Point(0, 0);
            this.create_SuccesfullMassage.Name = "create_SuccesfullMassage";
            this.create_SuccesfullMassage.Size = new System.Drawing.Size(571, 23);
            this.create_SuccesfullMassage.TabIndex = 13;
            this.create_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            this.create_SuccesfullMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.create_SuccesfullMassage.Visible = false;
            this.create_SuccesfullMassage.Click += new System.EventHandler(this.create_SuccesfullMassage_Click);
            // 
            // create_ErrorMassage
            // 
            this.create_ErrorMassage.BackColor = System.Drawing.Color.LavenderBlush;
            this.create_ErrorMassage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.create_ErrorMassage.ForeColor = System.Drawing.Color.Red;
            this.create_ErrorMassage.Location = new System.Drawing.Point(0, 438);
            this.create_ErrorMassage.Name = "create_ErrorMassage";
            this.create_ErrorMassage.Size = new System.Drawing.Size(571, 43);
            this.create_ErrorMassage.TabIndex = 12;
            this.create_ErrorMassage.Text = "Error";
            this.create_ErrorMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.create_ErrorMassage.Visible = false;
            // 
            // create_Table
            // 
            this.create_Table.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_Table.BackColor = System.Drawing.Color.Gainsboro;
            this.create_Table.Location = new System.Drawing.Point(220, 388);
            this.create_Table.Margin = new System.Windows.Forms.Padding(10);
            this.create_Table.Name = "create_Table";
            this.create_Table.Size = new System.Drawing.Size(153, 32);
            this.create_Table.TabIndex = 10;
            this.create_Table.Text = "Создать таблицу";
            this.create_Table.UseVisualStyleBackColor = false;
            this.create_Table.Click += new System.EventHandler(this.create_Table_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(39, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Имя базы данных";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // create_DataBaseNameFieldFromTable
            // 
            this.create_DataBaseNameFieldFromTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_DataBaseNameFieldFromTable.Location = new System.Drawing.Point(220, 243);
            this.create_DataBaseNameFieldFromTable.Margin = new System.Windows.Forms.Padding(10);
            this.create_DataBaseNameFieldFromTable.Name = "create_DataBaseNameFieldFromTable";
            this.create_DataBaseNameFieldFromTable.Size = new System.Drawing.Size(308, 27);
            this.create_DataBaseNameFieldFromTable.TabIndex = 8;
            // 
            // create_NewDB
            // 
            this.create_NewDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_NewDB.BackColor = System.Drawing.Color.Gainsboro;
            this.create_NewDB.Location = new System.Drawing.Point(220, 130);
            this.create_NewDB.Margin = new System.Windows.Forms.Padding(10);
            this.create_NewDB.Name = "create_NewDB";
            this.create_NewDB.Size = new System.Drawing.Size(153, 32);
            this.create_NewDB.TabIndex = 4;
            this.create_NewDB.Text = "Создать БД";
            this.create_NewDB.UseVisualStyleBackColor = false;
            this.create_NewDB.Click += new System.EventHandler(this.create_NewDB_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(39, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя таблицы";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // create_TableNameField
            // 
            this.create_TableNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_TableNameField.Location = new System.Drawing.Point(220, 294);
            this.create_TableNameField.Margin = new System.Windows.Forms.Padding(10);
            this.create_TableNameField.Name = "create_TableNameField";
            this.create_TableNameField.Size = new System.Drawing.Size(308, 27);
            this.create_TableNameField.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Создать таблицу";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(39, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя базы данных";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // create_DateBaseNameField
            // 
            this.create_DateBaseNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_DateBaseNameField.Location = new System.Drawing.Point(220, 85);
            this.create_DateBaseNameField.Margin = new System.Windows.Forms.Padding(10);
            this.create_DateBaseNameField.Name = "create_DateBaseNameField";
            this.create_DateBaseNameField.Size = new System.Drawing.Size(308, 27);
            this.create_DateBaseNameField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Создать базу данных";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readPanel
            // 
            this.readPanel.Controls.Add(this.read_labelColumnName);
            this.readPanel.Controls.Add(this.read_ColumnsNameField);
            this.readPanel.Controls.Add(this.read_SuccesfullMassage);
            this.readPanel.Controls.Add(this.read_ErrorMassage);
            this.readPanel.Controls.Add(this.read_readData);
            this.readPanel.Controls.Add(this.read_customColumns);
            this.readPanel.Controls.Add(this.read_allColumns);
            this.readPanel.Controls.Add(this.read_readTableList);
            this.readPanel.Controls.Add(this.read_TableNameField);
            this.readPanel.Controls.Add(this.label8);
            this.readPanel.Controls.Add(this.read_NameBDField);
            this.readPanel.Controls.Add(this.label9);
            this.readPanel.Location = new System.Drawing.Point(1207, 12);
            this.readPanel.Name = "readPanel";
            this.readPanel.Size = new System.Drawing.Size(695, 481);
            this.readPanel.TabIndex = 5;
            this.readPanel.Visible = false;
            // 
            // read_labelColumnName
            // 
            this.read_labelColumnName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.read_labelColumnName.Location = new System.Drawing.Point(60, 309);
            this.read_labelColumnName.Margin = new System.Windows.Forms.Padding(10);
            this.read_labelColumnName.Name = "read_labelColumnName";
            this.read_labelColumnName.Size = new System.Drawing.Size(186, 50);
            this.read_labelColumnName.TabIndex = 18;
            this.read_labelColumnName.Text = "Введите имена столбцов через запятую";
            this.read_labelColumnName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.read_labelColumnName.Visible = false;
            // 
            // read_ColumnsNameField
            // 
            this.read_ColumnsNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.read_ColumnsNameField.Location = new System.Drawing.Point(264, 320);
            this.read_ColumnsNameField.Margin = new System.Windows.Forms.Padding(10);
            this.read_ColumnsNameField.Name = "read_ColumnsNameField";
            this.read_ColumnsNameField.Size = new System.Drawing.Size(308, 27);
            this.read_ColumnsNameField.TabIndex = 17;
            this.read_ColumnsNameField.Visible = false;
            // 
            // read_SuccesfullMassage
            // 
            this.read_SuccesfullMassage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.read_SuccesfullMassage.Dock = System.Windows.Forms.DockStyle.Top;
            this.read_SuccesfullMassage.ForeColor = System.Drawing.Color.SeaGreen;
            this.read_SuccesfullMassage.Location = new System.Drawing.Point(0, 0);
            this.read_SuccesfullMassage.Name = "read_SuccesfullMassage";
            this.read_SuccesfullMassage.Size = new System.Drawing.Size(695, 23);
            this.read_SuccesfullMassage.TabIndex = 16;
            this.read_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            this.read_SuccesfullMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.read_SuccesfullMassage.Visible = false;
            this.read_SuccesfullMassage.Click += new System.EventHandler(this.read_SuccesfullMassage_Click);
            // 
            // read_ErrorMassage
            // 
            this.read_ErrorMassage.BackColor = System.Drawing.Color.LavenderBlush;
            this.read_ErrorMassage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.read_ErrorMassage.ForeColor = System.Drawing.Color.Red;
            this.read_ErrorMassage.Location = new System.Drawing.Point(0, 438);
            this.read_ErrorMassage.Name = "read_ErrorMassage";
            this.read_ErrorMassage.Size = new System.Drawing.Size(695, 43);
            this.read_ErrorMassage.TabIndex = 13;
            this.read_ErrorMassage.Text = "Error";
            this.read_ErrorMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.read_ErrorMassage.Visible = false;
            // 
            // read_readData
            // 
            this.read_readData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.read_readData.BackColor = System.Drawing.Color.Gainsboro;
            this.read_readData.Location = new System.Drawing.Point(275, 330);
            this.read_readData.Margin = new System.Windows.Forms.Padding(10);
            this.read_readData.Name = "read_readData";
            this.read_readData.Size = new System.Drawing.Size(142, 32);
            this.read_readData.TabIndex = 15;
            this.read_readData.Text = "Читать данные";
            this.read_readData.UseVisualStyleBackColor = false;
            this.read_readData.Click += new System.EventHandler(this.read_readData_Click);
            // 
            // read_customColumns
            // 
            this.read_customColumns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.read_customColumns.AutoSize = true;
            this.read_customColumns.Location = new System.Drawing.Point(420, 282);
            this.read_customColumns.Name = "read_customColumns";
            this.read_customColumns.Size = new System.Drawing.Size(150, 24);
            this.read_customColumns.TabIndex = 13;
            this.read_customColumns.Text = "Выбрать столбцы";
            this.read_customColumns.UseVisualStyleBackColor = true;
            this.read_customColumns.CheckedChanged += new System.EventHandler(this.read_customColumns_CheckedChanged);
            // 
            // read_allColumns
            // 
            this.read_allColumns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.read_allColumns.AutoSize = true;
            this.read_allColumns.Checked = true;
            this.read_allColumns.Location = new System.Drawing.Point(273, 282);
            this.read_allColumns.Name = "read_allColumns";
            this.read_allColumns.Size = new System.Drawing.Size(114, 24);
            this.read_allColumns.TabIndex = 12;
            this.read_allColumns.TabStop = true;
            this.read_allColumns.Text = "Все столбцы";
            this.read_allColumns.UseVisualStyleBackColor = true;
            this.read_allColumns.CheckedChanged += new System.EventHandler(this.read_allColumns_CheckedChanged);
            // 
            // read_readTableList
            // 
            this.read_readTableList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.read_readTableList.BackColor = System.Drawing.Color.Gainsboro;
            this.read_readTableList.Location = new System.Drawing.Point(264, 141);
            this.read_readTableList.Margin = new System.Windows.Forms.Padding(10);
            this.read_readTableList.Name = "read_readTableList";
            this.read_readTableList.Size = new System.Drawing.Size(308, 32);
            this.read_readTableList.TabIndex = 11;
            this.read_readTableList.Text = "Читать список таблиц из БД";
            this.read_readTableList.UseVisualStyleBackColor = false;
            this.read_readTableList.Click += new System.EventHandler(this.read_readTableList_Click);
            // 
            // read_TableNameField
            // 
            this.read_TableNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.read_TableNameField.Location = new System.Drawing.Point(264, 227);
            this.read_TableNameField.Margin = new System.Windows.Forms.Padding(10);
            this.read_TableNameField.Name = "read_TableNameField";
            this.read_TableNameField.Size = new System.Drawing.Size(308, 27);
            this.read_TableNameField.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Location = new System.Drawing.Point(91, 230);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Имя таблицы";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // read_NameBDField
            // 
            this.read_NameBDField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.read_NameBDField.Location = new System.Drawing.Point(264, 94);
            this.read_NameBDField.Margin = new System.Windows.Forms.Padding(10);
            this.read_NameBDField.Name = "read_NameBDField";
            this.read_NameBDField.Size = new System.Drawing.Size(308, 27);
            this.read_NameBDField.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Location = new System.Drawing.Point(91, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Имя базы данных";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.label23);
            this.updatePanel.Controls.Add(this.update_FilterColumnValueField);
            this.updatePanel.Controls.Add(this.update_SuccesfullMassage);
            this.updatePanel.Controls.Add(this.label21);
            this.updatePanel.Controls.Add(this.update_FilterColumnNameField);
            this.updatePanel.Controls.Add(this.label19);
            this.updatePanel.Controls.Add(this.update_ErrorMassage);
            this.updatePanel.Controls.Add(this.update_NewValueField);
            this.updatePanel.Controls.Add(this.update_UpdateValue);
            this.updatePanel.Controls.Add(this.label20);
            this.updatePanel.Controls.Add(this.update_TableNameField);
            this.updatePanel.Controls.Add(this.update_ColumnNameField);
            this.updatePanel.Controls.Add(this.label13);
            this.updatePanel.Controls.Add(this.update_DBNameField);
            this.updatePanel.Controls.Add(this.label14);
            this.updatePanel.Location = new System.Drawing.Point(186, 513);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(712, 481);
            this.updatePanel.TabIndex = 12;
            this.updatePanel.Visible = false;
            // 
            // update_SuccesfullMassage
            // 
            this.update_SuccesfullMassage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.update_SuccesfullMassage.Dock = System.Windows.Forms.DockStyle.Top;
            this.update_SuccesfullMassage.ForeColor = System.Drawing.Color.SeaGreen;
            this.update_SuccesfullMassage.Location = new System.Drawing.Point(0, 0);
            this.update_SuccesfullMassage.Name = "update_SuccesfullMassage";
            this.update_SuccesfullMassage.Size = new System.Drawing.Size(712, 23);
            this.update_SuccesfullMassage.TabIndex = 25;
            this.update_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            this.update_SuccesfullMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update_SuccesfullMassage.Visible = false;
            this.update_SuccesfullMassage.Click += new System.EventHandler(this.update_SuccesfullMassage_Click);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.Location = new System.Drawing.Point(44, 268);
            this.label21.Margin = new System.Windows.Forms.Padding(10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(183, 20);
            this.label21.TabIndex = 24;
            this.label21.Text = "Имя столбца для отбора";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // update_FilterColumnNameField
            // 
            this.update_FilterColumnNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_FilterColumnNameField.Location = new System.Drawing.Point(262, 265);
            this.update_FilterColumnNameField.Margin = new System.Windows.Forms.Padding(10);
            this.update_FilterColumnNameField.Name = "update_FilterColumnNameField";
            this.update_FilterColumnNameField.Size = new System.Drawing.Size(308, 27);
            this.update_FilterColumnNameField.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.Location = new System.Drawing.Point(81, 169);
            this.label19.Margin = new System.Windows.Forms.Padding(10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(147, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "Имя столбца";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // update_ErrorMassage
            // 
            this.update_ErrorMassage.BackColor = System.Drawing.Color.LavenderBlush;
            this.update_ErrorMassage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.update_ErrorMassage.ForeColor = System.Drawing.Color.Red;
            this.update_ErrorMassage.Location = new System.Drawing.Point(0, 438);
            this.update_ErrorMassage.Name = "update_ErrorMassage";
            this.update_ErrorMassage.Size = new System.Drawing.Size(712, 43);
            this.update_ErrorMassage.TabIndex = 16;
            this.update_ErrorMassage.Text = "Error";
            this.update_ErrorMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update_ErrorMassage.Visible = false;
            // 
            // update_NewValueField
            // 
            this.update_NewValueField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_NewValueField.Location = new System.Drawing.Point(262, 216);
            this.update_NewValueField.Margin = new System.Windows.Forms.Padding(10);
            this.update_NewValueField.Name = "update_NewValueField";
            this.update_NewValueField.Size = new System.Drawing.Size(308, 27);
            this.update_NewValueField.TabIndex = 20;
            // 
            // update_UpdateValue
            // 
            this.update_UpdateValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_UpdateValue.BackColor = System.Drawing.Color.Gainsboro;
            this.update_UpdateValue.Location = new System.Drawing.Point(262, 376);
            this.update_UpdateValue.Margin = new System.Windows.Forms.Padding(10);
            this.update_UpdateValue.Name = "update_UpdateValue";
            this.update_UpdateValue.Size = new System.Drawing.Size(308, 32);
            this.update_UpdateValue.TabIndex = 11;
            this.update_UpdateValue.Text = "Изменить значение";
            this.update_UpdateValue.UseVisualStyleBackColor = false;
            this.update_UpdateValue.Click += new System.EventHandler(this.update_UpdateValue_Click);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.Location = new System.Drawing.Point(27, 214);
            this.label20.Margin = new System.Windows.Forms.Padding(10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(201, 28);
            this.label20.TabIndex = 19;
            this.label20.Text = "Новое значение столбца";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // update_TableNameField
            // 
            this.update_TableNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_TableNameField.Location = new System.Drawing.Point(262, 116);
            this.update_TableNameField.Margin = new System.Windows.Forms.Padding(10);
            this.update_TableNameField.Name = "update_TableNameField";
            this.update_TableNameField.Size = new System.Drawing.Size(308, 27);
            this.update_TableNameField.TabIndex = 4;
            // 
            // update_ColumnNameField
            // 
            this.update_ColumnNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_ColumnNameField.Location = new System.Drawing.Point(262, 167);
            this.update_ColumnNameField.Margin = new System.Windows.Forms.Padding(10);
            this.update_ColumnNameField.Name = "update_ColumnNameField";
            this.update_ColumnNameField.Size = new System.Drawing.Size(308, 27);
            this.update_ColumnNameField.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Location = new System.Drawing.Point(72, 121);
            this.label13.Margin = new System.Windows.Forms.Padding(10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Имя таблицы";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // update_DBNameField
            // 
            this.update_DBNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_DBNameField.Location = new System.Drawing.Point(262, 66);
            this.update_DBNameField.Margin = new System.Windows.Forms.Padding(10);
            this.update_DBNameField.Name = "update_DBNameField";
            this.update_DBNameField.Size = new System.Drawing.Size(308, 27);
            this.update_DBNameField.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.Location = new System.Drawing.Point(72, 71);
            this.label14.Margin = new System.Windows.Forms.Padding(10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Имя базы данных";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deletePanel
            // 
            this.deletePanel.Controls.Add(this.delete_SuccesfullMassage);
            this.deletePanel.Controls.Add(this.delete_DeleteDataBase);
            this.deletePanel.Controls.Add(this.delete_ErrorMassage);
            this.deletePanel.Controls.Add(this.delete_DeleteRows);
            this.deletePanel.Controls.Add(this.label17);
            this.deletePanel.Controls.Add(this.delete_RowsValueField);
            this.deletePanel.Controls.Add(this.label18);
            this.deletePanel.Controls.Add(this.delete_ColumnNameField);
            this.deletePanel.Controls.Add(this.delete_DeleteTable);
            this.deletePanel.Controls.Add(this.delete_TableNameField);
            this.deletePanel.Controls.Add(this.label15);
            this.deletePanel.Controls.Add(this.delete_DBNameField);
            this.deletePanel.Controls.Add(this.label16);
            this.deletePanel.Location = new System.Drawing.Point(959, 513);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(707, 481);
            this.deletePanel.TabIndex = 13;
            this.deletePanel.Visible = false;
            // 
            // delete_SuccesfullMassage
            // 
            this.delete_SuccesfullMassage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.delete_SuccesfullMassage.Dock = System.Windows.Forms.DockStyle.Top;
            this.delete_SuccesfullMassage.ForeColor = System.Drawing.Color.SeaGreen;
            this.delete_SuccesfullMassage.Location = new System.Drawing.Point(0, 0);
            this.delete_SuccesfullMassage.Name = "delete_SuccesfullMassage";
            this.delete_SuccesfullMassage.Size = new System.Drawing.Size(707, 23);
            this.delete_SuccesfullMassage.TabIndex = 19;
            this.delete_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            this.delete_SuccesfullMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete_SuccesfullMassage.Visible = false;
            this.delete_SuccesfullMassage.Click += new System.EventHandler(this.delete_SuccesfullMassage_Click);
            // 
            // delete_DeleteDataBase
            // 
            this.delete_DeleteDataBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_DeleteDataBase.BackColor = System.Drawing.Color.Gainsboro;
            this.delete_DeleteDataBase.Location = new System.Drawing.Point(314, 100);
            this.delete_DeleteDataBase.Margin = new System.Windows.Forms.Padding(10);
            this.delete_DeleteDataBase.Name = "delete_DeleteDataBase";
            this.delete_DeleteDataBase.Size = new System.Drawing.Size(177, 32);
            this.delete_DeleteDataBase.TabIndex = 18;
            this.delete_DeleteDataBase.Text = "Удалить базу данных";
            this.delete_DeleteDataBase.UseVisualStyleBackColor = false;
            this.delete_DeleteDataBase.Click += new System.EventHandler(this.delete_DeleteDataBase_Click);
            // 
            // delete_ErrorMassage
            // 
            this.delete_ErrorMassage.BackColor = System.Drawing.Color.LavenderBlush;
            this.delete_ErrorMassage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delete_ErrorMassage.ForeColor = System.Drawing.Color.Red;
            this.delete_ErrorMassage.Location = new System.Drawing.Point(0, 438);
            this.delete_ErrorMassage.Name = "delete_ErrorMassage";
            this.delete_ErrorMassage.Size = new System.Drawing.Size(707, 43);
            this.delete_ErrorMassage.TabIndex = 17;
            this.delete_ErrorMassage.Text = "Error";
            this.delete_ErrorMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete_ErrorMassage.Visible = false;
            this.delete_ErrorMassage.Click += new System.EventHandler(this.delete_ErrorMassage_Click);
            // 
            // delete_DeleteRows
            // 
            this.delete_DeleteRows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_DeleteRows.BackColor = System.Drawing.Color.Gainsboro;
            this.delete_DeleteRows.Location = new System.Drawing.Point(314, 368);
            this.delete_DeleteRows.Margin = new System.Windows.Forms.Padding(10);
            this.delete_DeleteRows.Name = "delete_DeleteRows";
            this.delete_DeleteRows.Size = new System.Drawing.Size(177, 32);
            this.delete_DeleteRows.TabIndex = 17;
            this.delete_DeleteRows.Text = "Удалить строки";
            this.delete_DeleteRows.UseVisualStyleBackColor = false;
            this.delete_DeleteRows.Click += new System.EventHandler(this.delete_DeleteRows_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.Location = new System.Drawing.Point(70, 271);
            this.label17.Margin = new System.Windows.Forms.Padding(10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "Имя столбца";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // delete_RowsValueField
            // 
            this.delete_RowsValueField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_RowsValueField.Location = new System.Drawing.Point(251, 321);
            this.delete_RowsValueField.Margin = new System.Windows.Forms.Padding(10);
            this.delete_RowsValueField.Name = "delete_RowsValueField";
            this.delete_RowsValueField.Size = new System.Drawing.Size(308, 27);
            this.delete_RowsValueField.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.Location = new System.Drawing.Point(9, 309);
            this.label18.Margin = new System.Windows.Forms.Padding(10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(207, 47);
            this.label18.TabIndex = 14;
            this.label18.Text = "Значение столбца в строке, которую нужно удалить";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // delete_ColumnNameField
            // 
            this.delete_ColumnNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_ColumnNameField.Location = new System.Drawing.Point(251, 267);
            this.delete_ColumnNameField.Margin = new System.Windows.Forms.Padding(10);
            this.delete_ColumnNameField.Name = "delete_ColumnNameField";
            this.delete_ColumnNameField.Size = new System.Drawing.Size(308, 27);
            this.delete_ColumnNameField.TabIndex = 13;
            // 
            // delete_DeleteTable
            // 
            this.delete_DeleteTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_DeleteTable.BackColor = System.Drawing.Color.Gainsboro;
            this.delete_DeleteTable.Location = new System.Drawing.Point(314, 204);
            this.delete_DeleteTable.Margin = new System.Windows.Forms.Padding(10);
            this.delete_DeleteTable.Name = "delete_DeleteTable";
            this.delete_DeleteTable.Size = new System.Drawing.Size(177, 32);
            this.delete_DeleteTable.TabIndex = 11;
            this.delete_DeleteTable.Text = "Удалить таблицу";
            this.delete_DeleteTable.UseVisualStyleBackColor = false;
            this.delete_DeleteTable.Click += new System.EventHandler(this.delete_DeleteTable_Click);
            // 
            // delete_TableNameField
            // 
            this.delete_TableNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_TableNameField.Location = new System.Drawing.Point(251, 157);
            this.delete_TableNameField.Margin = new System.Windows.Forms.Padding(10);
            this.delete_TableNameField.Name = "delete_TableNameField";
            this.delete_TableNameField.Size = new System.Drawing.Size(308, 27);
            this.delete_TableNameField.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.Location = new System.Drawing.Point(70, 157);
            this.label15.Margin = new System.Windows.Forms.Padding(10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Имя таблицы";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // delete_DBNameField
            // 
            this.delete_DBNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_DBNameField.Location = new System.Drawing.Point(251, 53);
            this.delete_DBNameField.Margin = new System.Windows.Forms.Padding(10);
            this.delete_DBNameField.Name = "delete_DBNameField";
            this.delete_DBNameField.Size = new System.Drawing.Size(308, 27);
            this.delete_DBNameField.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.Location = new System.Drawing.Point(58, 56);
            this.label16.Margin = new System.Windows.Forms.Padding(10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Имя базы данных";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.Location = new System.Drawing.Point(44, 315);
            this.label23.Margin = new System.Windows.Forms.Padding(10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(183, 20);
            this.label23.TabIndex = 27;
            this.label23.Text = "Значение для отбора";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // update_FilterColumnValueField
            // 
            this.update_FilterColumnValueField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_FilterColumnValueField.Location = new System.Drawing.Point(262, 312);
            this.update_FilterColumnValueField.Margin = new System.Windows.Forms.Padding(10);
            this.update_FilterColumnValueField.Name = "update_FilterColumnValueField";
            this.update_FilterColumnValueField.Size = new System.Drawing.Size(308, 27);
            this.update_FilterColumnValueField.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 1023);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.readPanel);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.connectionPanel);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "InerfaceBD";
            this.MenuPanel.ResumeLayout(false);
            this.connectionPanel.ResumeLayout(false);
            this.connectionPanel.PerformLayout();
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            this.readPanel.ResumeLayout(false);
            this.readPanel.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private Button delete;
        private Button read;
        private Button update;
        private Button Create;
        private Panel connectionPanel;
        private Button connection;
        private TextBox connection_ServerName;
        private Label label1;
        private Panel createPanel;
        private Label label6;
        private TextBox create_DataBaseNameFieldFromTable;
        private Button create_NewDB;
        private Label label4;
        private TextBox create_TableNameField;
        private Label label5;
        private Label label3;
        private TextBox create_DateBaseNameField;
        private Label label2;
        private TextBox connection_PasswordField;
        private Label label7;
        private Button create_Table;
        private Panel readPanel;
        private TextBox read_TableNameField;
        private Label label8;
        private Label label9;
        private TextBox read_NameBDField;
        private Button read_readTableList;
        private TextBox connection_IdField;
        private Label label10;
        private Label label11;
        private TextBox connection_DataBaseNameField;
        private Label label12;
        private Panel updatePanel;
        private Button update_UpdateValue;
        private TextBox update_TableNameField;
        private Label label13;
        private TextBox update_DBNameField;
        private Label label14;
        private Panel deletePanel;
        private Button delete_DeleteTable;
        private TextBox delete_TableNameField;
        private Label label15;
        private TextBox delete_DBNameField;
        private Label label16;
        private RadioButton read_customColumns;
        private RadioButton read_allColumns;
        private Button read_readData;
        private Button delete_DeleteRows;
        private Label label17;
        private TextBox delete_RowsValueField;
        private Label label18;
        private TextBox delete_ColumnNameField;
        private Label connection_ErrorMassage;
        private Label create_ErrorMassage;
        private Label read_ErrorMassage;
        private Label update_ErrorMassage;
        private Label delete_ErrorMassage;
        private TextBox update_FilterColumnNameField;
        private Label label19;
        private TextBox update_NewValueField;
        private Label label20;
        private TextBox update_ColumnNameField;
        private Label label21;
        private Button delete_DeleteDataBase;
        private Label connection_SuccesfullMassage;
        private Label create_SuccesfullMassage;
        private Label read_SuccesfullMassage;
        private Label update_SuccesfullMassage;
        private Label delete_SuccesfullMassage;
        private Label label22;
        private TextBox create_ColumnsName;
        private Label read_labelColumnName;
        private TextBox read_ColumnsNameField;
        private Label label23;
        private TextBox update_FilterColumnValueField;
    }
}