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
            this.connection_DataBaseNameField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.connection_IdField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.connection_PasswordField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.connection_ServerNameАшудв = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createPanel = new System.Windows.Forms.Panel();
            this.create_Table = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.create_DataBaseNameField = new System.Windows.Forms.TextBox();
            this.create_NewDB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.create_TableNameField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_DateBaseNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.readPanel = new System.Windows.Forms.Panel();
            this.read_readTableList = new System.Windows.Forms.Button();
            this.read_TableName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.read_NameBD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
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
            this.connection.Location = new System.Drawing.Point(12, 12);
            this.connection.Margin = new System.Windows.Forms.Padding(10);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(153, 32);
            this.connection.TabIndex = 3;
            this.connection.Text = "Подключение";
            this.connection.UseVisualStyleBackColor = true;
            this.connection.Click += new System.EventHandler(this.connection_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(12, 212);
            this.delete.Margin = new System.Windows.Forms.Padding(10);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(153, 32);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(12, 112);
            this.read.Margin = new System.Windows.Forms.Padding(10);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(153, 32);
            this.read.TabIndex = 1;
            this.read.Text = "Читать";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(12, 162);
            this.update.Margin = new System.Windows.Forms.Padding(10);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(153, 32);
            this.update.TabIndex = 1;
            this.update.Text = "Модифицировать";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(12, 62);
            this.Create.Margin = new System.Windows.Forms.Padding(10);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(153, 32);
            this.Create.TabIndex = 0;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // connectionPanel
            // 
            this.connectionPanel.Controls.Add(this.connection_DataBaseNameField);
            this.connectionPanel.Controls.Add(this.label12);
            this.connectionPanel.Controls.Add(this.label11);
            this.connectionPanel.Controls.Add(this.connection_IdField);
            this.connectionPanel.Controls.Add(this.label10);
            this.connectionPanel.Controls.Add(this.connection_PasswordField);
            this.connectionPanel.Controls.Add(this.label7);
            this.connectionPanel.Controls.Add(this.connection_ServerNameАшудв);
            this.connectionPanel.Controls.Add(this.label1);
            this.connectionPanel.Location = new System.Drawing.Point(186, 12);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(414, 481);
            this.connectionPanel.TabIndex = 1;
            this.connectionPanel.Visible = false;
            // 
            // connection_DataBaseNameField
            // 
            this.connection_DataBaseNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connection_DataBaseNameField.Location = new System.Drawing.Point(53, 174);
            this.connection_DataBaseNameField.Margin = new System.Windows.Forms.Padding(10);
            this.connection_DataBaseNameField.Name = "connection_DataBaseNameField";
            this.connection_DataBaseNameField.Size = new System.Drawing.Size(308, 27);
            this.connection_DataBaseNameField.TabIndex = 9;
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
            this.label11.Location = new System.Drawing.Point(53, 233);
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
            this.connection_IdField.Location = new System.Drawing.Point(53, 334);
            this.connection_IdField.Margin = new System.Windows.Forms.Padding(10);
            this.connection_IdField.Name = "connection_IdField";
            this.connection_IdField.Size = new System.Drawing.Size(308, 27);
            this.connection_IdField.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Location = new System.Drawing.Point(53, 301);
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
            this.connection_PasswordField.Location = new System.Drawing.Point(53, 421);
            this.connection_PasswordField.Margin = new System.Windows.Forms.Padding(10);
            this.connection_PasswordField.Name = "connection_PasswordField";
            this.connection_PasswordField.Size = new System.Drawing.Size(308, 27);
            this.connection_PasswordField.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Location = new System.Drawing.Point(53, 387);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Введите пароль";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connection_ServerNameАшудв
            // 
            this.connection_ServerNameАшудв.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connection_ServerNameАшудв.Location = new System.Drawing.Point(53, 88);
            this.connection_ServerNameАшудв.Margin = new System.Windows.Forms.Padding(10);
            this.connection_ServerNameАшудв.Name = "connection_ServerNameАшудв";
            this.connection_ServerNameАшудв.Size = new System.Drawing.Size(308, 27);
            this.connection_ServerNameАшудв.TabIndex = 2;
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
            this.createPanel.Controls.Add(this.create_Table);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.create_DataBaseNameField);
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
            // create_Table
            // 
            this.create_Table.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_Table.Location = new System.Drawing.Point(209, 397);
            this.create_Table.Margin = new System.Windows.Forms.Padding(10);
            this.create_Table.Name = "create_Table";
            this.create_Table.Size = new System.Drawing.Size(153, 32);
            this.create_Table.TabIndex = 10;
            this.create_Table.Text = "Создать таблицу";
            this.create_Table.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(28, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Имя базы данных";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // create_DataBaseNameField
            // 
            this.create_DataBaseNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_DataBaseNameField.Location = new System.Drawing.Point(209, 293);
            this.create_DataBaseNameField.Margin = new System.Windows.Forms.Padding(10);
            this.create_DataBaseNameField.Name = "create_DataBaseNameField";
            this.create_DataBaseNameField.Size = new System.Drawing.Size(308, 27);
            this.create_DataBaseNameField.TabIndex = 8;
            // 
            // create_NewDB
            // 
            this.create_NewDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_NewDB.Location = new System.Drawing.Point(209, 167);
            this.create_NewDB.Margin = new System.Windows.Forms.Padding(10);
            this.create_NewDB.Name = "create_NewDB";
            this.create_NewDB.Size = new System.Drawing.Size(153, 32);
            this.create_NewDB.TabIndex = 4;
            this.create_NewDB.Text = "Создать БД";
            this.create_NewDB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(28, 347);
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
            this.create_TableNameField.Location = new System.Drawing.Point(209, 344);
            this.create_TableNameField.Margin = new System.Windows.Forms.Padding(10);
            this.create_TableNameField.Name = "create_TableNameField";
            this.create_TableNameField.Size = new System.Drawing.Size(308, 27);
            this.create_TableNameField.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 258);
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
            this.label3.Location = new System.Drawing.Point(28, 123);
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
            this.create_DateBaseNameField.Location = new System.Drawing.Point(209, 120);
            this.create_DateBaseNameField.Margin = new System.Windows.Forms.Padding(10);
            this.create_DateBaseNameField.Name = "create_DateBaseNameField";
            this.create_DateBaseNameField.Size = new System.Drawing.Size(308, 27);
            this.create_DateBaseNameField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Создать базу данных";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readPanel
            // 
            this.readPanel.Controls.Add(this.read_readTableList);
            this.readPanel.Controls.Add(this.read_TableName);
            this.readPanel.Controls.Add(this.label8);
            this.readPanel.Controls.Add(this.read_NameBD);
            this.readPanel.Controls.Add(this.label9);
            this.readPanel.Location = new System.Drawing.Point(1207, 12);
            this.readPanel.Name = "readPanel";
            this.readPanel.Size = new System.Drawing.Size(718, 481);
            this.readPanel.TabIndex = 5;
            this.readPanel.Visible = false;
            // 
            // read_readTableList
            // 
            this.read_readTableList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.read_readTableList.Location = new System.Drawing.Point(259, 94);
            this.read_readTableList.Margin = new System.Windows.Forms.Padding(10);
            this.read_readTableList.Name = "read_readTableList";
            this.read_readTableList.Size = new System.Drawing.Size(308, 32);
            this.read_readTableList.TabIndex = 11;
            this.read_readTableList.Text = "Читать список таблиц из БД";
            this.read_readTableList.UseVisualStyleBackColor = true;
            // 
            // read_TableName
            // 
            this.read_TableName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.read_TableName.Location = new System.Drawing.Point(259, 171);
            this.read_TableName.Margin = new System.Windows.Forms.Padding(10);
            this.read_TableName.Name = "read_TableName";
            this.read_TableName.Size = new System.Drawing.Size(308, 27);
            this.read_TableName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Location = new System.Drawing.Point(86, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Имя таблицы";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // read_NameBD
            // 
            this.read_NameBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.read_NameBD.Location = new System.Drawing.Point(259, 47);
            this.read_NameBD.Margin = new System.Windows.Forms.Padding(10);
            this.read_NameBD.Name = "read_NameBD";
            this.read_NameBD.Size = new System.Drawing.Size(308, 27);
            this.read_NameBD.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Location = new System.Drawing.Point(86, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Имя базы данных";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.button2);
            this.updatePanel.Controls.Add(this.textBox8);
            this.updatePanel.Controls.Add(this.label13);
            this.updatePanel.Controls.Add(this.textBox9);
            this.updatePanel.Controls.Add(this.label14);
            this.updatePanel.Location = new System.Drawing.Point(186, 513);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(414, 481);
            this.updatePanel.TabIndex = 12;
            this.updatePanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(53, 121);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Читать список таблиц из БД";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.Location = new System.Drawing.Point(53, 211);
            this.textBox8.Margin = new System.Windows.Forms.Padding(10);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(308, 27);
            this.textBox8.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Location = new System.Drawing.Point(53, 176);
            this.label13.Margin = new System.Windows.Forms.Padding(10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(308, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Читать список таблиц из БД";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox9.Location = new System.Drawing.Point(53, 72);
            this.textBox9.Margin = new System.Windows.Forms.Padding(10);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(308, 27);
            this.textBox9.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.Location = new System.Drawing.Point(53, 37);
            this.label14.Margin = new System.Windows.Forms.Padding(10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(308, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Имя базы данных";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deletePanel
            // 
            this.deletePanel.Controls.Add(this.button1);
            this.deletePanel.Controls.Add(this.textBox1);
            this.deletePanel.Controls.Add(this.label15);
            this.deletePanel.Controls.Add(this.textBox2);
            this.deletePanel.Controls.Add(this.label16);
            this.deletePanel.Location = new System.Drawing.Point(620, 513);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(571, 481);
            this.deletePanel.TabIndex = 13;
            this.deletePanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(128, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Читать список таблиц из БД";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(128, 285);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.Location = new System.Drawing.Point(128, 250);
            this.label15.Margin = new System.Windows.Forms.Padding(10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(308, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Читать список таблиц из БД";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(128, 146);
            this.textBox2.Margin = new System.Windows.Forms.Padding(10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 27);
            this.textBox2.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.Location = new System.Drawing.Point(128, 111);
            this.label16.Margin = new System.Windows.Forms.Padding(10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(308, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Имя базы данных";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Text = "Form1";
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
        private TextBox connection_ServerNameАшудв;
        private Label label1;
        private Panel createPanel;
        private Label label6;
        private TextBox create_DataBaseNameField;
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
        private TextBox read_TableName;
        private Label label8;
        private Label label9;
        private TextBox read_NameBD;
        private Button read_readTableList;
        private TextBox connection_IdField;
        private Label label10;
        private Label label11;
        private TextBox connection_DataBaseNameField;
        private Label label12;
        private Panel updatePanel;
        private Button button2;
        private TextBox textBox8;
        private Label label13;
        private TextBox textBox9;
        private Label label14;
        private Panel deletePanel;
        private Button button1;
        private TextBox textBox1;
        private Label label15;
        private TextBox textBox2;
        private Label label16;
    }
}