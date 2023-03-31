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
            MenuPanel = new Panel();
            add = new Button();
            connection = new Button();
            delete = new Button();
            read = new Button();
            update = new Button();
            Create = new Button();
            connectionPanel = new Panel();
            connection_SuccesfullMassage = new Label();
            connection_ErrorMassage = new Label();
            connection_DataBaseNameField = new TextBox();
            label12 = new Label();
            label11 = new Label();
            connection_IdField = new TextBox();
            label10 = new Label();
            connection_PasswordField = new TextBox();
            label7 = new Label();
            connection_ServerName = new TextBox();
            label1 = new Label();
            createPanel = new Panel();
            label22 = new Label();
            create_ColumnsName = new TextBox();
            create_SuccesfullMassage = new Label();
            create_ErrorMassage = new Label();
            create_Table = new Button();
            label6 = new Label();
            create_DataBaseNameFieldFromTable = new TextBox();
            create_NewDB = new Button();
            label4 = new Label();
            create_TableNameField = new TextBox();
            label5 = new Label();
            label3 = new Label();
            create_DateBaseNameField = new TextBox();
            label2 = new Label();
            readPanel = new Panel();
            read_labelColumnName = new Label();
            read_ColumnsNameField = new TextBox();
            read_SuccesfullMassage = new Label();
            read_ErrorMassage = new Label();
            read_readData = new Button();
            read_customColumns = new RadioButton();
            read_allColumns = new RadioButton();
            read_readTableList = new Button();
            read_TableNameField = new TextBox();
            label8 = new Label();
            read_NameBDField = new TextBox();
            label9 = new Label();
            updatePanel = new Panel();
            label23 = new Label();
            update_FilterColumnValueField = new TextBox();
            update_SuccesfullMassage = new Label();
            label21 = new Label();
            update_FilterColumnNameField = new TextBox();
            label19 = new Label();
            update_ErrorMassage = new Label();
            update_NewValueField = new TextBox();
            update_UpdateValue = new Button();
            label20 = new Label();
            update_TableNameField = new TextBox();
            update_ColumnNameField = new TextBox();
            label13 = new Label();
            update_DBNameField = new TextBox();
            label14 = new Label();
            deletePanel = new Panel();
            delete_SuccesfullMassage = new Label();
            delete_DeleteDataBase = new Button();
            delete_ErrorMassage = new Label();
            delete_DeleteRows = new Button();
            label17 = new Label();
            delete_RowsValueField = new TextBox();
            label18 = new Label();
            delete_ColumnNameField = new TextBox();
            delete_DeleteTable = new Button();
            delete_TableNameField = new TextBox();
            label15 = new Label();
            delete_DBNameField = new TextBox();
            label16 = new Label();
            addPanel = new Panel();
            add_SuccesfullMassage = new Label();
            label27 = new Label();
            add_ErrorMassage = new Label();
            add_ColumnValues = new TextBox();
            add_addEntry = new Button();
            label29 = new Label();
            add_TableNameField = new TextBox();
            add_ColumnNameField = new TextBox();
            label30 = new Label();
            add_NameBDField = new TextBox();
            label31 = new Label();
            MenuPanel.SuspendLayout();
            connectionPanel.SuspendLayout();
            createPanel.SuspendLayout();
            readPanel.SuspendLayout();
            updatePanel.SuspendLayout();
            deletePanel.SuspendLayout();
            addPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.Controls.Add(add);
            MenuPanel.Controls.Add(connection);
            MenuPanel.Controls.Add(delete);
            MenuPanel.Controls.Add(read);
            MenuPanel.Controls.Add(update);
            MenuPanel.Controls.Add(Create);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Margin = new Padding(3, 4, 3, 4);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(180, 1023);
            MenuPanel.TabIndex = 0;
            // 
            // add
            // 
            add.BackColor = Color.Gainsboro;
            add.Location = new Point(12, 112);
            add.Margin = new Padding(10);
            add.Name = "add";
            add.Size = new Size(153, 32);
            add.TabIndex = 4;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // connection
            // 
            connection.BackColor = Color.Gainsboro;
            connection.Location = new Point(12, 12);
            connection.Margin = new Padding(10);
            connection.Name = "connection";
            connection.Size = new Size(153, 32);
            connection.TabIndex = 3;
            connection.Text = "Подключение";
            connection.UseVisualStyleBackColor = false;
            connection.Click += connection_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Gainsboro;
            delete.Location = new Point(12, 262);
            delete.Margin = new Padding(10);
            delete.Name = "delete";
            delete.Size = new Size(153, 32);
            delete.TabIndex = 2;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // read
            // 
            read.BackColor = Color.Gainsboro;
            read.Location = new Point(12, 162);
            read.Margin = new Padding(10);
            read.Name = "read";
            read.Size = new Size(153, 32);
            read.TabIndex = 1;
            read.Text = "Читать";
            read.UseVisualStyleBackColor = false;
            read.Click += read_Click;
            // 
            // update
            // 
            update.BackColor = Color.Gainsboro;
            update.Location = new Point(12, 212);
            update.Margin = new Padding(10);
            update.Name = "update";
            update.Size = new Size(153, 32);
            update.TabIndex = 1;
            update.Text = "Модифицировать";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // Create
            // 
            Create.BackColor = Color.Gainsboro;
            Create.Location = new Point(12, 62);
            Create.Margin = new Padding(10);
            Create.Name = "Create";
            Create.Size = new Size(153, 32);
            Create.TabIndex = 0;
            Create.Text = "Создать";
            Create.UseVisualStyleBackColor = false;
            Create.Click += Create_Click;
            // 
            // connectionPanel
            // 
            connectionPanel.Controls.Add(connection_SuccesfullMassage);
            connectionPanel.Controls.Add(connection_ErrorMassage);
            connectionPanel.Controls.Add(connection_DataBaseNameField);
            connectionPanel.Controls.Add(label12);
            connectionPanel.Controls.Add(label11);
            connectionPanel.Controls.Add(connection_IdField);
            connectionPanel.Controls.Add(label10);
            connectionPanel.Controls.Add(connection_PasswordField);
            connectionPanel.Controls.Add(label7);
            connectionPanel.Controls.Add(connection_ServerName);
            connectionPanel.Controls.Add(label1);
            connectionPanel.Location = new Point(186, 12);
            connectionPanel.Name = "connectionPanel";
            connectionPanel.Size = new Size(414, 481);
            connectionPanel.TabIndex = 1;
            connectionPanel.Visible = false;
            // 
            // connection_SuccesfullMassage
            // 
            connection_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            connection_SuccesfullMassage.Dock = DockStyle.Top;
            connection_SuccesfullMassage.ForeColor = Color.SeaGreen;
            connection_SuccesfullMassage.Location = new Point(0, 0);
            connection_SuccesfullMassage.Name = "connection_SuccesfullMassage";
            connection_SuccesfullMassage.Size = new Size(414, 23);
            connection_SuccesfullMassage.TabIndex = 12;
            connection_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            connection_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            connection_SuccesfullMassage.Visible = false;
            connection_SuccesfullMassage.Click += connection_SuccesfullMassage_Click;
            // 
            // connection_ErrorMassage
            // 
            connection_ErrorMassage.BackColor = Color.LavenderBlush;
            connection_ErrorMassage.Dock = DockStyle.Bottom;
            connection_ErrorMassage.ForeColor = Color.Red;
            connection_ErrorMassage.Location = new Point(0, 438);
            connection_ErrorMassage.Name = "connection_ErrorMassage";
            connection_ErrorMassage.Size = new Size(414, 43);
            connection_ErrorMassage.TabIndex = 11;
            connection_ErrorMassage.Text = "Error";
            connection_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            connection_ErrorMassage.Visible = false;
            // 
            // connection_DataBaseNameField
            // 
            connection_DataBaseNameField.Anchor = AnchorStyles.None;
            connection_DataBaseNameField.Location = new Point(53, 174);
            connection_DataBaseNameField.Margin = new Padding(10);
            connection_DataBaseNameField.Name = "connection_DataBaseNameField";
            connection_DataBaseNameField.Size = new Size(308, 27);
            connection_DataBaseNameField.TabIndex = 9;
            connection_DataBaseNameField.TextChanged += connection_DataBaseNameField_TextChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.Location = new Point(53, 140);
            label12.Margin = new Padding(10);
            label12.Name = "label12";
            label12.Size = new Size(308, 25);
            label12.TabIndex = 8;
            label12.Text = "Введите имя базы данных";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.Location = new Point(53, 227);
            label11.Margin = new Padding(10);
            label11.Name = "label11";
            label11.Size = new Size(308, 54);
            label11.TabIndex = 7;
            label11.Text = "Для подключения с проверкой подлинности SQL Server";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // connection_IdField
            // 
            connection_IdField.Anchor = AnchorStyles.None;
            connection_IdField.Location = new Point(53, 314);
            connection_IdField.Margin = new Padding(10);
            connection_IdField.Name = "connection_IdField";
            connection_IdField.Size = new Size(308, 27);
            connection_IdField.TabIndex = 6;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.Location = new Point(53, 284);
            label10.Margin = new Padding(10);
            label10.Name = "label10";
            label10.Size = new Size(308, 20);
            label10.TabIndex = 5;
            label10.Text = "Введите ID";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // connection_PasswordField
            // 
            connection_PasswordField.Anchor = AnchorStyles.None;
            connection_PasswordField.Location = new Point(53, 393);
            connection_PasswordField.Margin = new Padding(10);
            connection_PasswordField.Name = "connection_PasswordField";
            connection_PasswordField.Size = new Size(308, 27);
            connection_PasswordField.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Location = new Point(53, 361);
            label7.Margin = new Padding(10);
            label7.Name = "label7";
            label7.Size = new Size(308, 20);
            label7.TabIndex = 3;
            label7.Text = "Введите пароль";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // connection_ServerName
            // 
            connection_ServerName.Anchor = AnchorStyles.None;
            connection_ServerName.Location = new Point(53, 88);
            connection_ServerName.Margin = new Padding(10);
            connection_ServerName.Name = "connection_ServerName";
            connection_ServerName.Size = new Size(308, 27);
            connection_ServerName.TabIndex = 2;
            connection_ServerName.Text = "DESKTOP-HHO6PH0";
            connection_ServerName.TextChanged += connection_ServerName_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(53, 33);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(308, 44);
            label1.TabIndex = 0;
            label1.Text = "Введите имя сервера для подключения к базе данных";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createPanel
            // 
            createPanel.Controls.Add(label22);
            createPanel.Controls.Add(create_ColumnsName);
            createPanel.Controls.Add(create_SuccesfullMassage);
            createPanel.Controls.Add(create_ErrorMassage);
            createPanel.Controls.Add(create_Table);
            createPanel.Controls.Add(label6);
            createPanel.Controls.Add(create_DataBaseNameFieldFromTable);
            createPanel.Controls.Add(create_NewDB);
            createPanel.Controls.Add(label4);
            createPanel.Controls.Add(create_TableNameField);
            createPanel.Controls.Add(label5);
            createPanel.Controls.Add(label3);
            createPanel.Controls.Add(create_DateBaseNameField);
            createPanel.Controls.Add(label2);
            createPanel.Location = new Point(620, 12);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(571, 481);
            createPanel.TabIndex = 4;
            createPanel.Visible = false;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.None;
            label22.Location = new Point(10, 323);
            label22.Margin = new Padding(10);
            label22.Name = "label22";
            label22.Size = new Size(190, 70);
            label22.TabIndex = 15;
            label22.Text = "Введи имена столбцов и их параметры разделяя столбцы запятой";
            label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_ColumnsName
            // 
            create_ColumnsName.Anchor = AnchorStyles.None;
            create_ColumnsName.Location = new Point(220, 341);
            create_ColumnsName.Margin = new Padding(10);
            create_ColumnsName.Name = "create_ColumnsName";
            create_ColumnsName.Size = new Size(308, 27);
            create_ColumnsName.TabIndex = 14;
            // 
            // create_SuccesfullMassage
            // 
            create_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            create_SuccesfullMassage.Dock = DockStyle.Top;
            create_SuccesfullMassage.ForeColor = Color.SeaGreen;
            create_SuccesfullMassage.Location = new Point(0, 0);
            create_SuccesfullMassage.Name = "create_SuccesfullMassage";
            create_SuccesfullMassage.Size = new Size(571, 23);
            create_SuccesfullMassage.TabIndex = 13;
            create_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            create_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            create_SuccesfullMassage.Visible = false;
            create_SuccesfullMassage.Click += create_SuccesfullMassage_Click;
            // 
            // create_ErrorMassage
            // 
            create_ErrorMassage.BackColor = Color.LavenderBlush;
            create_ErrorMassage.Dock = DockStyle.Bottom;
            create_ErrorMassage.ForeColor = Color.Red;
            create_ErrorMassage.Location = new Point(0, 438);
            create_ErrorMassage.Name = "create_ErrorMassage";
            create_ErrorMassage.Size = new Size(571, 43);
            create_ErrorMassage.TabIndex = 12;
            create_ErrorMassage.Text = "Error";
            create_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            create_ErrorMassage.Visible = false;
            // 
            // create_Table
            // 
            create_Table.Anchor = AnchorStyles.None;
            create_Table.BackColor = Color.Gainsboro;
            create_Table.Location = new Point(220, 388);
            create_Table.Margin = new Padding(10);
            create_Table.Name = "create_Table";
            create_Table.Size = new Size(153, 32);
            create_Table.TabIndex = 10;
            create_Table.Text = "Создать таблицу";
            create_Table.UseVisualStyleBackColor = false;
            create_Table.Click += create_Table_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Location = new Point(39, 246);
            label6.Margin = new Padding(10);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 9;
            label6.Text = "Имя базы данных";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_DataBaseNameFieldFromTable
            // 
            create_DataBaseNameFieldFromTable.Anchor = AnchorStyles.None;
            create_DataBaseNameFieldFromTable.Location = new Point(220, 243);
            create_DataBaseNameFieldFromTable.Margin = new Padding(10);
            create_DataBaseNameFieldFromTable.Name = "create_DataBaseNameFieldFromTable";
            create_DataBaseNameFieldFromTable.Size = new Size(308, 27);
            create_DataBaseNameFieldFromTable.TabIndex = 8;
            // 
            // create_NewDB
            // 
            create_NewDB.Anchor = AnchorStyles.None;
            create_NewDB.BackColor = Color.Gainsboro;
            create_NewDB.Location = new Point(220, 130);
            create_NewDB.Margin = new Padding(10);
            create_NewDB.Name = "create_NewDB";
            create_NewDB.Size = new Size(153, 32);
            create_NewDB.TabIndex = 4;
            create_NewDB.Text = "Создать БД";
            create_NewDB.UseVisualStyleBackColor = false;
            create_NewDB.Click += create_NewDB_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Location = new Point(39, 297);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 7;
            label4.Text = "Имя таблицы";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_TableNameField
            // 
            create_TableNameField.Anchor = AnchorStyles.None;
            create_TableNameField.Location = new Point(220, 294);
            create_TableNameField.Margin = new Padding(10);
            create_TableNameField.Name = "create_TableNameField";
            create_TableNameField.Size = new Size(308, 27);
            create_TableNameField.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(233, 213);
            label5.Margin = new Padding(10);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 5;
            label5.Text = "Создать таблицу";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Location = new Point(39, 88);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 4;
            label3.Text = "Имя базы данных";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_DateBaseNameField
            // 
            create_DateBaseNameField.Anchor = AnchorStyles.None;
            create_DateBaseNameField.Location = new Point(220, 85);
            create_DateBaseNameField.Margin = new Padding(10);
            create_DateBaseNameField.Name = "create_DateBaseNameField";
            create_DateBaseNameField.Size = new Size(308, 27);
            create_DateBaseNameField.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(221, 48);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 0;
            label2.Text = "Создать базу данных";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // readPanel
            // 
            readPanel.Controls.Add(read_labelColumnName);
            readPanel.Controls.Add(read_ColumnsNameField);
            readPanel.Controls.Add(read_SuccesfullMassage);
            readPanel.Controls.Add(read_ErrorMassage);
            readPanel.Controls.Add(read_readData);
            readPanel.Controls.Add(read_customColumns);
            readPanel.Controls.Add(read_allColumns);
            readPanel.Controls.Add(read_readTableList);
            readPanel.Controls.Add(read_TableNameField);
            readPanel.Controls.Add(label8);
            readPanel.Controls.Add(read_NameBDField);
            readPanel.Controls.Add(label9);
            readPanel.Location = new Point(198, 516);
            readPanel.Name = "readPanel";
            readPanel.Size = new Size(538, 481);
            readPanel.TabIndex = 5;
            readPanel.Visible = false;
            // 
            // read_labelColumnName
            // 
            read_labelColumnName.Anchor = AnchorStyles.None;
            read_labelColumnName.Location = new Point(-18, 309);
            read_labelColumnName.Margin = new Padding(10);
            read_labelColumnName.Name = "read_labelColumnName";
            read_labelColumnName.Size = new Size(186, 50);
            read_labelColumnName.TabIndex = 18;
            read_labelColumnName.Text = "Введите имена столбцов через запятую";
            read_labelColumnName.TextAlign = ContentAlignment.MiddleRight;
            read_labelColumnName.Visible = false;
            // 
            // read_ColumnsNameField
            // 
            read_ColumnsNameField.Anchor = AnchorStyles.None;
            read_ColumnsNameField.Location = new Point(186, 320);
            read_ColumnsNameField.Margin = new Padding(10);
            read_ColumnsNameField.Name = "read_ColumnsNameField";
            read_ColumnsNameField.Size = new Size(308, 27);
            read_ColumnsNameField.TabIndex = 17;
            read_ColumnsNameField.Visible = false;
            // 
            // read_SuccesfullMassage
            // 
            read_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            read_SuccesfullMassage.Dock = DockStyle.Top;
            read_SuccesfullMassage.ForeColor = Color.SeaGreen;
            read_SuccesfullMassage.Location = new Point(0, 0);
            read_SuccesfullMassage.Name = "read_SuccesfullMassage";
            read_SuccesfullMassage.Size = new Size(538, 23);
            read_SuccesfullMassage.TabIndex = 16;
            read_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            read_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            read_SuccesfullMassage.Visible = false;
            read_SuccesfullMassage.Click += read_SuccesfullMassage_Click;
            // 
            // read_ErrorMassage
            // 
            read_ErrorMassage.BackColor = Color.LavenderBlush;
            read_ErrorMassage.Dock = DockStyle.Bottom;
            read_ErrorMassage.ForeColor = Color.Red;
            read_ErrorMassage.Location = new Point(0, 438);
            read_ErrorMassage.Name = "read_ErrorMassage";
            read_ErrorMassage.Size = new Size(538, 43);
            read_ErrorMassage.TabIndex = 13;
            read_ErrorMassage.Text = "Error";
            read_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            read_ErrorMassage.Visible = false;
            // 
            // read_readData
            // 
            read_readData.Anchor = AnchorStyles.None;
            read_readData.BackColor = Color.Gainsboro;
            read_readData.Location = new Point(197, 330);
            read_readData.Margin = new Padding(10);
            read_readData.Name = "read_readData";
            read_readData.Size = new Size(142, 32);
            read_readData.TabIndex = 15;
            read_readData.Text = "Читать данные";
            read_readData.UseVisualStyleBackColor = false;
            read_readData.Click += read_readData_Click;
            // 
            // read_customColumns
            // 
            read_customColumns.Anchor = AnchorStyles.None;
            read_customColumns.AutoSize = true;
            read_customColumns.Location = new Point(342, 282);
            read_customColumns.Name = "read_customColumns";
            read_customColumns.Size = new Size(150, 24);
            read_customColumns.TabIndex = 13;
            read_customColumns.Text = "Выбрать столбцы";
            read_customColumns.UseVisualStyleBackColor = true;
            read_customColumns.CheckedChanged += read_customColumns_CheckedChanged;
            // 
            // read_allColumns
            // 
            read_allColumns.Anchor = AnchorStyles.None;
            read_allColumns.AutoSize = true;
            read_allColumns.Checked = true;
            read_allColumns.Location = new Point(195, 282);
            read_allColumns.Name = "read_allColumns";
            read_allColumns.Size = new Size(114, 24);
            read_allColumns.TabIndex = 12;
            read_allColumns.TabStop = true;
            read_allColumns.Text = "Все столбцы";
            read_allColumns.UseVisualStyleBackColor = true;
            read_allColumns.CheckedChanged += read_allColumns_CheckedChanged;
            // 
            // read_readTableList
            // 
            read_readTableList.Anchor = AnchorStyles.None;
            read_readTableList.BackColor = Color.Gainsboro;
            read_readTableList.Location = new Point(186, 141);
            read_readTableList.Margin = new Padding(10);
            read_readTableList.Name = "read_readTableList";
            read_readTableList.Size = new Size(308, 32);
            read_readTableList.TabIndex = 11;
            read_readTableList.Text = "Читать список таблиц из БД";
            read_readTableList.UseVisualStyleBackColor = false;
            read_readTableList.Click += read_readTableList_Click;
            // 
            // read_TableNameField
            // 
            read_TableNameField.Anchor = AnchorStyles.None;
            read_TableNameField.Location = new Point(186, 227);
            read_TableNameField.Margin = new Padding(10);
            read_TableNameField.Name = "read_TableNameField";
            read_TableNameField.Size = new Size(308, 27);
            read_TableNameField.TabIndex = 4;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Location = new Point(13, 230);
            label8.Margin = new Padding(10);
            label8.Name = "label8";
            label8.Size = new Size(155, 20);
            label8.TabIndex = 3;
            label8.Text = "Имя таблицы";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // read_NameBDField
            // 
            read_NameBDField.Anchor = AnchorStyles.None;
            read_NameBDField.Location = new Point(186, 94);
            read_NameBDField.Margin = new Padding(10);
            read_NameBDField.Name = "read_NameBDField";
            read_NameBDField.Size = new Size(308, 27);
            read_NameBDField.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.Location = new Point(13, 97);
            label9.Margin = new Padding(10);
            label9.Name = "label9";
            label9.Size = new Size(155, 20);
            label9.TabIndex = 0;
            label9.Text = "Имя базы данных";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updatePanel
            // 
            updatePanel.Controls.Add(label23);
            updatePanel.Controls.Add(update_FilterColumnValueField);
            updatePanel.Controls.Add(update_SuccesfullMassage);
            updatePanel.Controls.Add(label21);
            updatePanel.Controls.Add(update_FilterColumnNameField);
            updatePanel.Controls.Add(label19);
            updatePanel.Controls.Add(update_ErrorMassage);
            updatePanel.Controls.Add(update_NewValueField);
            updatePanel.Controls.Add(update_UpdateValue);
            updatePanel.Controls.Add(label20);
            updatePanel.Controls.Add(update_TableNameField);
            updatePanel.Controls.Add(update_ColumnNameField);
            updatePanel.Controls.Add(label13);
            updatePanel.Controls.Add(update_DBNameField);
            updatePanel.Controls.Add(label14);
            updatePanel.Location = new Point(766, 516);
            updatePanel.Name = "updatePanel";
            updatePanel.Size = new Size(594, 481);
            updatePanel.TabIndex = 12;
            updatePanel.Visible = false;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.None;
            label23.Location = new Point(-15, 315);
            label23.Margin = new Padding(10);
            label23.Name = "label23";
            label23.Size = new Size(183, 20);
            label23.TabIndex = 27;
            label23.Text = "Значение для отбора";
            label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update_FilterColumnValueField
            // 
            update_FilterColumnValueField.Anchor = AnchorStyles.None;
            update_FilterColumnValueField.Location = new Point(203, 312);
            update_FilterColumnValueField.Margin = new Padding(10);
            update_FilterColumnValueField.Name = "update_FilterColumnValueField";
            update_FilterColumnValueField.Size = new Size(308, 27);
            update_FilterColumnValueField.TabIndex = 26;
            // 
            // update_SuccesfullMassage
            // 
            update_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            update_SuccesfullMassage.Dock = DockStyle.Top;
            update_SuccesfullMassage.ForeColor = Color.SeaGreen;
            update_SuccesfullMassage.Location = new Point(0, 0);
            update_SuccesfullMassage.Name = "update_SuccesfullMassage";
            update_SuccesfullMassage.Size = new Size(594, 23);
            update_SuccesfullMassage.TabIndex = 25;
            update_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            update_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            update_SuccesfullMassage.Visible = false;
            update_SuccesfullMassage.Click += update_SuccesfullMassage_Click;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.None;
            label21.Location = new Point(-15, 268);
            label21.Margin = new Padding(10);
            label21.Name = "label21";
            label21.Size = new Size(183, 20);
            label21.TabIndex = 24;
            label21.Text = "Имя столбца для отбора";
            label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update_FilterColumnNameField
            // 
            update_FilterColumnNameField.Anchor = AnchorStyles.None;
            update_FilterColumnNameField.Location = new Point(203, 265);
            update_FilterColumnNameField.Margin = new Padding(10);
            update_FilterColumnNameField.Name = "update_FilterColumnNameField";
            update_FilterColumnNameField.Size = new Size(308, 27);
            update_FilterColumnNameField.TabIndex = 23;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.Location = new Point(22, 169);
            label19.Margin = new Padding(10);
            label19.Name = "label19";
            label19.Size = new Size(147, 20);
            label19.TabIndex = 21;
            label19.Text = "Имя столбца";
            label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update_ErrorMassage
            // 
            update_ErrorMassage.BackColor = Color.LavenderBlush;
            update_ErrorMassage.Dock = DockStyle.Bottom;
            update_ErrorMassage.ForeColor = Color.Red;
            update_ErrorMassage.Location = new Point(0, 438);
            update_ErrorMassage.Name = "update_ErrorMassage";
            update_ErrorMassage.Size = new Size(594, 43);
            update_ErrorMassage.TabIndex = 16;
            update_ErrorMassage.Text = "Error";
            update_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            update_ErrorMassage.Visible = false;
            // 
            // update_NewValueField
            // 
            update_NewValueField.Anchor = AnchorStyles.None;
            update_NewValueField.Location = new Point(203, 216);
            update_NewValueField.Margin = new Padding(10);
            update_NewValueField.Name = "update_NewValueField";
            update_NewValueField.Size = new Size(308, 27);
            update_NewValueField.TabIndex = 20;
            // 
            // update_UpdateValue
            // 
            update_UpdateValue.Anchor = AnchorStyles.None;
            update_UpdateValue.BackColor = Color.Gainsboro;
            update_UpdateValue.Location = new Point(203, 376);
            update_UpdateValue.Margin = new Padding(10);
            update_UpdateValue.Name = "update_UpdateValue";
            update_UpdateValue.Size = new Size(308, 32);
            update_UpdateValue.TabIndex = 11;
            update_UpdateValue.Text = "Изменить значение";
            update_UpdateValue.UseVisualStyleBackColor = false;
            update_UpdateValue.Click += update_UpdateValue_Click;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.Location = new Point(-32, 214);
            label20.Margin = new Padding(10);
            label20.Name = "label20";
            label20.Size = new Size(201, 28);
            label20.TabIndex = 19;
            label20.Text = "Новое значение столбца";
            label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update_TableNameField
            // 
            update_TableNameField.Anchor = AnchorStyles.None;
            update_TableNameField.Location = new Point(203, 116);
            update_TableNameField.Margin = new Padding(10);
            update_TableNameField.Name = "update_TableNameField";
            update_TableNameField.Size = new Size(308, 27);
            update_TableNameField.TabIndex = 4;
            // 
            // update_ColumnNameField
            // 
            update_ColumnNameField.Anchor = AnchorStyles.None;
            update_ColumnNameField.Location = new Point(203, 167);
            update_ColumnNameField.Margin = new Padding(10);
            update_ColumnNameField.Name = "update_ColumnNameField";
            update_ColumnNameField.Size = new Size(308, 27);
            update_ColumnNameField.TabIndex = 18;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.Location = new Point(13, 121);
            label13.Margin = new Padding(10);
            label13.Name = "label13";
            label13.Size = new Size(155, 20);
            label13.TabIndex = 3;
            label13.Text = "Имя таблицы";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update_DBNameField
            // 
            update_DBNameField.Anchor = AnchorStyles.None;
            update_DBNameField.Location = new Point(203, 66);
            update_DBNameField.Margin = new Padding(10);
            update_DBNameField.Name = "update_DBNameField";
            update_DBNameField.Size = new Size(308, 27);
            update_DBNameField.TabIndex = 2;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.Location = new Point(13, 71);
            label14.Margin = new Padding(10);
            label14.Name = "label14";
            label14.Size = new Size(155, 20);
            label14.TabIndex = 0;
            label14.Text = "Имя базы данных";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deletePanel
            // 
            deletePanel.Controls.Add(delete_SuccesfullMassage);
            deletePanel.Controls.Add(delete_DeleteDataBase);
            deletePanel.Controls.Add(delete_ErrorMassage);
            deletePanel.Controls.Add(delete_DeleteRows);
            deletePanel.Controls.Add(label17);
            deletePanel.Controls.Add(delete_RowsValueField);
            deletePanel.Controls.Add(label18);
            deletePanel.Controls.Add(delete_ColumnNameField);
            deletePanel.Controls.Add(delete_DeleteTable);
            deletePanel.Controls.Add(delete_TableNameField);
            deletePanel.Controls.Add(label15);
            deletePanel.Controls.Add(delete_DBNameField);
            deletePanel.Controls.Add(label16);
            deletePanel.Location = new Point(1377, 513);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(535, 481);
            deletePanel.TabIndex = 13;
            deletePanel.Visible = false;
            // 
            // delete_SuccesfullMassage
            // 
            delete_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            delete_SuccesfullMassage.Dock = DockStyle.Top;
            delete_SuccesfullMassage.ForeColor = Color.SeaGreen;
            delete_SuccesfullMassage.Location = new Point(0, 0);
            delete_SuccesfullMassage.Name = "delete_SuccesfullMassage";
            delete_SuccesfullMassage.Size = new Size(535, 23);
            delete_SuccesfullMassage.TabIndex = 19;
            delete_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            delete_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            delete_SuccesfullMassage.Visible = false;
            delete_SuccesfullMassage.Click += delete_SuccesfullMassage_Click;
            // 
            // delete_DeleteDataBase
            // 
            delete_DeleteDataBase.Anchor = AnchorStyles.None;
            delete_DeleteDataBase.BackColor = Color.Gainsboro;
            delete_DeleteDataBase.Location = new Point(228, 100);
            delete_DeleteDataBase.Margin = new Padding(10);
            delete_DeleteDataBase.Name = "delete_DeleteDataBase";
            delete_DeleteDataBase.Size = new Size(177, 32);
            delete_DeleteDataBase.TabIndex = 18;
            delete_DeleteDataBase.Text = "Удалить базу данных";
            delete_DeleteDataBase.UseVisualStyleBackColor = false;
            delete_DeleteDataBase.Click += delete_DeleteDataBase_Click;
            // 
            // delete_ErrorMassage
            // 
            delete_ErrorMassage.BackColor = Color.LavenderBlush;
            delete_ErrorMassage.Dock = DockStyle.Bottom;
            delete_ErrorMassage.ForeColor = Color.Red;
            delete_ErrorMassage.Location = new Point(0, 438);
            delete_ErrorMassage.Name = "delete_ErrorMassage";
            delete_ErrorMassage.Size = new Size(535, 43);
            delete_ErrorMassage.TabIndex = 17;
            delete_ErrorMassage.Text = "Error";
            delete_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            delete_ErrorMassage.Visible = false;
            delete_ErrorMassage.Click += delete_ErrorMassage_Click;
            // 
            // delete_DeleteRows
            // 
            delete_DeleteRows.Anchor = AnchorStyles.None;
            delete_DeleteRows.BackColor = Color.Gainsboro;
            delete_DeleteRows.Location = new Point(228, 368);
            delete_DeleteRows.Margin = new Padding(10);
            delete_DeleteRows.Name = "delete_DeleteRows";
            delete_DeleteRows.Size = new Size(177, 32);
            delete_DeleteRows.TabIndex = 17;
            delete_DeleteRows.Text = "Удалить строки";
            delete_DeleteRows.UseVisualStyleBackColor = false;
            delete_DeleteRows.Click += delete_DeleteRows_Click;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.Location = new Point(-16, 271);
            label17.Margin = new Padding(10);
            label17.Name = "label17";
            label17.Size = new Size(147, 20);
            label17.TabIndex = 16;
            label17.Text = "Имя столбца";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // delete_RowsValueField
            // 
            delete_RowsValueField.Anchor = AnchorStyles.None;
            delete_RowsValueField.Location = new Point(165, 321);
            delete_RowsValueField.Margin = new Padding(10);
            delete_RowsValueField.Name = "delete_RowsValueField";
            delete_RowsValueField.Size = new Size(308, 27);
            delete_RowsValueField.TabIndex = 15;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.Location = new Point(-77, 309);
            label18.Margin = new Padding(10);
            label18.Name = "label18";
            label18.Size = new Size(207, 47);
            label18.TabIndex = 14;
            label18.Text = "Значение столбца в строке, которую нужно удалить";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // delete_ColumnNameField
            // 
            delete_ColumnNameField.Anchor = AnchorStyles.None;
            delete_ColumnNameField.Location = new Point(165, 267);
            delete_ColumnNameField.Margin = new Padding(10);
            delete_ColumnNameField.Name = "delete_ColumnNameField";
            delete_ColumnNameField.Size = new Size(308, 27);
            delete_ColumnNameField.TabIndex = 13;
            // 
            // delete_DeleteTable
            // 
            delete_DeleteTable.Anchor = AnchorStyles.None;
            delete_DeleteTable.BackColor = Color.Gainsboro;
            delete_DeleteTable.Location = new Point(228, 204);
            delete_DeleteTable.Margin = new Padding(10);
            delete_DeleteTable.Name = "delete_DeleteTable";
            delete_DeleteTable.Size = new Size(177, 32);
            delete_DeleteTable.TabIndex = 11;
            delete_DeleteTable.Text = "Удалить таблицу";
            delete_DeleteTable.UseVisualStyleBackColor = false;
            delete_DeleteTable.Click += delete_DeleteTable_Click;
            // 
            // delete_TableNameField
            // 
            delete_TableNameField.Anchor = AnchorStyles.None;
            delete_TableNameField.Location = new Point(165, 157);
            delete_TableNameField.Margin = new Padding(10);
            delete_TableNameField.Name = "delete_TableNameField";
            delete_TableNameField.Size = new Size(308, 27);
            delete_TableNameField.TabIndex = 4;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.Location = new Point(-16, 157);
            label15.Margin = new Padding(10);
            label15.Name = "label15";
            label15.Size = new Size(147, 20);
            label15.TabIndex = 3;
            label15.Text = "Имя таблицы";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // delete_DBNameField
            // 
            delete_DBNameField.Anchor = AnchorStyles.None;
            delete_DBNameField.Location = new Point(165, 53);
            delete_DBNameField.Margin = new Padding(10);
            delete_DBNameField.Name = "delete_DBNameField";
            delete_DBNameField.Size = new Size(308, 27);
            delete_DBNameField.TabIndex = 2;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.Location = new Point(-28, 56);
            label16.Margin = new Padding(10);
            label16.Name = "label16";
            label16.Size = new Size(159, 20);
            label16.TabIndex = 0;
            label16.Text = "Имя базы данных";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addPanel
            // 
            addPanel.Controls.Add(add_SuccesfullMassage);
            addPanel.Controls.Add(label27);
            addPanel.Controls.Add(add_ErrorMassage);
            addPanel.Controls.Add(add_ColumnValues);
            addPanel.Controls.Add(add_addEntry);
            addPanel.Controls.Add(label29);
            addPanel.Controls.Add(add_TableNameField);
            addPanel.Controls.Add(add_ColumnNameField);
            addPanel.Controls.Add(label30);
            addPanel.Controls.Add(add_NameBDField);
            addPanel.Controls.Add(label31);
            addPanel.Location = new Point(1229, 12);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(642, 481);
            addPanel.TabIndex = 28;
            addPanel.Visible = false;
            // 
            // add_SuccesfullMassage
            // 
            add_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            add_SuccesfullMassage.Dock = DockStyle.Top;
            add_SuccesfullMassage.ForeColor = Color.SeaGreen;
            add_SuccesfullMassage.Location = new Point(0, 0);
            add_SuccesfullMassage.Name = "add_SuccesfullMassage";
            add_SuccesfullMassage.Size = new Size(642, 23);
            add_SuccesfullMassage.TabIndex = 25;
            add_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            add_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            add_SuccesfullMassage.Visible = false;
            add_SuccesfullMassage.Click += add_SuccesfullMassage_Click;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.None;
            label27.Location = new Point(40, 156);
            label27.Margin = new Padding(10);
            label27.Name = "label27";
            label27.Size = new Size(197, 47);
            label27.TabIndex = 21;
            label27.Text = "Имена столбцов через запятую";
            label27.TextAlign = ContentAlignment.MiddleRight;
            // 
            // add_ErrorMassage
            // 
            add_ErrorMassage.BackColor = Color.LavenderBlush;
            add_ErrorMassage.Dock = DockStyle.Bottom;
            add_ErrorMassage.ForeColor = Color.Red;
            add_ErrorMassage.Location = new Point(0, 438);
            add_ErrorMassage.Name = "add_ErrorMassage";
            add_ErrorMassage.Size = new Size(642, 43);
            add_ErrorMassage.TabIndex = 16;
            add_ErrorMassage.Text = "Error";
            add_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            add_ErrorMassage.Visible = false;
            // 
            // add_ColumnValues
            // 
            add_ColumnValues.Anchor = AnchorStyles.None;
            add_ColumnValues.Location = new Point(271, 242);
            add_ColumnValues.Margin = new Padding(10);
            add_ColumnValues.Name = "add_ColumnValues";
            add_ColumnValues.Size = new Size(308, 27);
            add_ColumnValues.TabIndex = 20;
            // 
            // add_addEntry
            // 
            add_addEntry.Anchor = AnchorStyles.None;
            add_addEntry.BackColor = Color.Gainsboro;
            add_addEntry.Location = new Point(183, 349);
            add_addEntry.Margin = new Padding(10);
            add_addEntry.Name = "add_addEntry";
            add_addEntry.Size = new Size(308, 32);
            add_addEntry.TabIndex = 11;
            add_addEntry.Text = "Добавить запись";
            add_addEntry.UseVisualStyleBackColor = false;
            add_addEntry.Click += add_addEntry_Click;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.None;
            label29.Location = new Point(10, 225);
            label29.Margin = new Padding(10);
            label29.Name = "label29";
            label29.Size = new Size(227, 66);
            label29.TabIndex = 19;
            label29.Text = "Значения столбцов через запятую в порядке указанном  в предидущем поле";
            label29.TextAlign = ContentAlignment.MiddleRight;
            // 
            // add_TableNameField
            // 
            add_TableNameField.Anchor = AnchorStyles.None;
            add_TableNameField.Location = new Point(271, 101);
            add_TableNameField.Margin = new Padding(10);
            add_TableNameField.Name = "add_TableNameField";
            add_TableNameField.Size = new Size(308, 27);
            add_TableNameField.TabIndex = 4;
            // 
            // add_ColumnNameField
            // 
            add_ColumnNameField.Anchor = AnchorStyles.None;
            add_ColumnNameField.Location = new Point(271, 169);
            add_ColumnNameField.Margin = new Padding(10);
            add_ColumnNameField.Name = "add_ColumnNameField";
            add_ColumnNameField.Size = new Size(308, 27);
            add_ColumnNameField.TabIndex = 18;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.None;
            label30.Location = new Point(81, 106);
            label30.Margin = new Padding(10);
            label30.Name = "label30";
            label30.Size = new Size(155, 20);
            label30.TabIndex = 3;
            label30.Text = "Имя таблицы";
            label30.TextAlign = ContentAlignment.MiddleRight;
            // 
            // add_NameBDField
            // 
            add_NameBDField.Anchor = AnchorStyles.None;
            add_NameBDField.Location = new Point(271, 51);
            add_NameBDField.Margin = new Padding(10);
            add_NameBDField.Name = "add_NameBDField";
            add_NameBDField.Size = new Size(308, 27);
            add_NameBDField.TabIndex = 2;
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.None;
            label31.Location = new Point(81, 56);
            label31.Margin = new Padding(10);
            label31.Name = "label31";
            label31.Size = new Size(155, 20);
            label31.TabIndex = 0;
            label31.Text = "Имя базы данных";
            label31.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1924, 1023);
            Controls.Add(addPanel);
            Controls.Add(deletePanel);
            Controls.Add(updatePanel);
            Controls.Add(readPanel);
            Controls.Add(createPanel);
            Controls.Add(connectionPanel);
            Controls.Add(MenuPanel);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "InerfaceBD";
            MenuPanel.ResumeLayout(false);
            connectionPanel.ResumeLayout(false);
            connectionPanel.PerformLayout();
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            readPanel.ResumeLayout(false);
            readPanel.PerformLayout();
            updatePanel.ResumeLayout(false);
            updatePanel.PerformLayout();
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            ResumeLayout(false);
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
        private Button add;
        private Panel addPanel;
        private Label add_SuccesfullMassage;
        private Label label27;
        private Label add_ErrorMassage;
        private TextBox add_ColumnValues;
        private Button add_addEntry;
        private Label label29;
        private TextBox add_TableNameField;
        private TextBox add_ColumnNameField;
        private Label label30;
        private TextBox add_NameBDField;
        private Label label31;
    }
}