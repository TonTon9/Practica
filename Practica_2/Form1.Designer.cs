
namespace Practica_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WorkersSelectButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.WorkerPostTextBox = new System.Windows.Forms.TextBox();
            this.WorkerAgeTextBox = new System.Windows.Forms.TextBox();
            this.WorkerNameTextBox = new System.Windows.Forms.TextBox();
            this.WorkerSurnameTextBox = new System.Windows.Forms.TextBox();
            this.WorkerSalaryTextBox = new System.Windows.Forms.TextBox();
            this.WorkerExpirienceTextBox = new System.Windows.Forms.TextBox();
            this.InsertWorker = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SQLReader_Test = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.InsertProduct = new System.Windows.Forms.Button();
            this.ProductCost = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.InsertClient = new System.Windows.Forms.Button();
            this.ClientPhone = new System.Windows.Forms.TextBox();
            this.ClientSurname = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.ClientAge = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.PartnerAttach = new System.Windows.Forms.TextBox();
            this.PartnerName = new System.Windows.Forms.TextBox();
            this.PartnerPhone = new System.Windows.Forms.TextBox();
            this.DataProduct = new System.Windows.Forms.DataGridView();
            this.DataGridClient = new System.Windows.Forms.DataGridView();
            this.DataGridPartnet = new System.Windows.Forms.DataGridView();
            this.ProductSelect = new System.Windows.Forms.Button();
            this.SelectClient = new System.Windows.Forms.Button();
            this.PartnerSelect = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SQLReader_Test.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPartnet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работники(Получить)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.WorkersSelectButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 285);
            this.dataGridView1.TabIndex = 1;
            // 
            // WorkersSelectButton
            // 
            this.WorkersSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WorkersSelectButton.Location = new System.Drawing.Point(3, 294);
            this.WorkersSelectButton.Name = "WorkersSelectButton";
            this.WorkersSelectButton.Size = new System.Drawing.Size(669, 46);
            this.WorkersSelectButton.TabIndex = 0;
            this.WorkersSelectButton.Text = "Вывести данные о сотрудниках";
            this.WorkersSelectButton.UseVisualStyleBackColor = true;
            this.WorkersSelectButton.Click += new System.EventHandler(this.WorkersSelectButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Label);
            this.tabPage1.Controls.Add(this.InsertWorker);
            this.tabPage1.Controls.Add(this.WorkerExpirienceTextBox);
            this.tabPage1.Controls.Add(this.WorkerSalaryTextBox);
            this.tabPage1.Controls.Add(this.WorkerSurnameTextBox);
            this.tabPage1.Controls.Add(this.WorkerNameTextBox);
            this.tabPage1.Controls.Add(this.WorkerAgeTextBox);
            this.tabPage1.Controls.Add(this.WorkerPostTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работники(Внести)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // WorkerPostTextBox
            // 
            this.WorkerPostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WorkerPostTextBox.Location = new System.Drawing.Point(6, 192);
            this.WorkerPostTextBox.Name = "WorkerPostTextBox";
            this.WorkerPostTextBox.Size = new System.Drawing.Size(270, 29);
            this.WorkerPostTextBox.TabIndex = 1;
            // 
            // WorkerAgeTextBox
            // 
            this.WorkerAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WorkerAgeTextBox.Location = new System.Drawing.Point(539, 32);
            this.WorkerAgeTextBox.Name = "WorkerAgeTextBox";
            this.WorkerAgeTextBox.Size = new System.Drawing.Size(47, 29);
            this.WorkerAgeTextBox.TabIndex = 3;
            // 
            // WorkerNameTextBox
            // 
            this.WorkerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WorkerNameTextBox.Location = new System.Drawing.Point(6, 32);
            this.WorkerNameTextBox.Name = "WorkerNameTextBox";
            this.WorkerNameTextBox.Size = new System.Drawing.Size(211, 29);
            this.WorkerNameTextBox.TabIndex = 0;
            // 
            // WorkerSurnameTextBox
            // 
            this.WorkerSurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WorkerSurnameTextBox.Location = new System.Drawing.Point(227, 32);
            this.WorkerSurnameTextBox.Name = "WorkerSurnameTextBox";
            this.WorkerSurnameTextBox.Size = new System.Drawing.Size(211, 29);
            this.WorkerSurnameTextBox.TabIndex = 4;
            // 
            // WorkerSalaryTextBox
            // 
            this.WorkerSalaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WorkerSalaryTextBox.Location = new System.Drawing.Point(6, 86);
            this.WorkerSalaryTextBox.Name = "WorkerSalaryTextBox";
            this.WorkerSalaryTextBox.Size = new System.Drawing.Size(211, 29);
            this.WorkerSalaryTextBox.TabIndex = 2;
            // 
            // WorkerExpirienceTextBox
            // 
            this.WorkerExpirienceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WorkerExpirienceTextBox.Location = new System.Drawing.Point(6, 137);
            this.WorkerExpirienceTextBox.Name = "WorkerExpirienceTextBox";
            this.WorkerExpirienceTextBox.Size = new System.Drawing.Size(67, 29);
            this.WorkerExpirienceTextBox.TabIndex = 5;
            // 
            // InsertWorker
            // 
            this.InsertWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.InsertWorker.Location = new System.Drawing.Point(6, 249);
            this.InsertWorker.Name = "InsertWorker";
            this.InsertWorker.Size = new System.Drawing.Size(142, 69);
            this.InsertWorker.TabIndex = 6;
            this.InsertWorker.Text = "Внести данные о работнике";
            this.InsertWorker.UseVisualStyleBackColor = true;
            this.InsertWorker.Click += new System.EventHandler(this.InsertWorker_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label.Location = new System.Drawing.Point(223, 92);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(84, 20);
            this.Label.TabIndex = 7;
            this.Label.Text = "Зарплата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(79, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Опыт работы(в годах)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(282, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(223, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(526, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Возраст";
            // 
            // SQLReader_Test
            // 
            this.SQLReader_Test.Controls.Add(this.tabPage1);
            this.SQLReader_Test.Controls.Add(this.tabPage2);
            this.SQLReader_Test.Controls.Add(this.tabPage3);
            this.SQLReader_Test.Controls.Add(this.tabPage4);
            this.SQLReader_Test.Controls.Add(this.tabPage5);
            this.SQLReader_Test.Controls.Add(this.tabPage6);
            this.SQLReader_Test.Controls.Add(this.tabPage7);
            this.SQLReader_Test.Controls.Add(this.tabPage8);
            this.SQLReader_Test.Location = new System.Drawing.Point(12, 12);
            this.SQLReader_Test.Name = "SQLReader_Test";
            this.SQLReader_Test.SelectedIndex = 0;
            this.SQLReader_Test.Size = new System.Drawing.Size(689, 375);
            this.SQLReader_Test.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.InsertProduct);
            this.tabPage3.Controls.Add(this.ProductCost);
            this.tabPage3.Controls.Add(this.ProductName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(681, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Продукт(в)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ProductSelect);
            this.tabPage4.Controls.Add(this.DataProduct);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(681, 349);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Продукт(П)";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.InsertClient);
            this.tabPage5.Controls.Add(this.ClientPhone);
            this.tabPage5.Controls.Add(this.ClientSurname);
            this.tabPage5.Controls.Add(this.ClientName);
            this.tabPage5.Controls.Add(this.ClientAge);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(681, 349);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Клиент(в)";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.SelectClient);
            this.tabPage6.Controls.Add(this.DataGridClient);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(681, 349);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Клиетн(П)";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label19);
            this.tabPage7.Controls.Add(this.label20);
            this.tabPage7.Controls.Add(this.label21);
            this.tabPage7.Controls.Add(this.button3);
            this.tabPage7.Controls.Add(this.PartnerAttach);
            this.tabPage7.Controls.Add(this.PartnerName);
            this.tabPage7.Controls.Add(this.PartnerPhone);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(681, 349);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Текст(в)";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.PartnerSelect);
            this.tabPage8.Controls.Add(this.DataGridPartnet);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(681, 349);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Спонсор(П)";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(13, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Название";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(230, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Стоимость";
            // 
            // InsertProduct
            // 
            this.InsertProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.InsertProduct.Location = new System.Drawing.Point(13, 131);
            this.InsertProduct.Name = "InsertProduct";
            this.InsertProduct.Size = new System.Drawing.Size(142, 69);
            this.InsertProduct.TabIndex = 19;
            this.InsertProduct.Text = "Внести данные о продукте";
            this.InsertProduct.UseVisualStyleBackColor = true;
            this.InsertProduct.Click += new System.EventHandler(this.InsertProduct_Click);
            // 
            // ProductCost
            // 
            this.ProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ProductCost.Location = new System.Drawing.Point(13, 85);
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.Size = new System.Drawing.Size(211, 29);
            this.ProductCost.TabIndex = 15;
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ProductName.Location = new System.Drawing.Point(13, 31);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(211, 29);
            this.ProductName.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(3, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Возраст";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(3, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Фамилия";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(3, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Имя";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(96, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Телефон";
            // 
            // InsertClient
            // 
            this.InsertClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.InsertClient.Location = new System.Drawing.Point(7, 253);
            this.InsertClient.Name = "InsertClient";
            this.InsertClient.Size = new System.Drawing.Size(142, 69);
            this.InsertClient.TabIndex = 19;
            this.InsertClient.Text = "Внести данные о клиенте";
            this.InsertClient.UseVisualStyleBackColor = true;
            this.InsertClient.Click += new System.EventHandler(this.InsertClient_Click);
            // 
            // ClientPhone
            // 
            this.ClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ClientPhone.Location = new System.Drawing.Point(100, 189);
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.Size = new System.Drawing.Size(194, 29);
            this.ClientPhone.TabIndex = 18;
            // 
            // ClientSurname
            // 
            this.ClientSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ClientSurname.Location = new System.Drawing.Point(3, 114);
            this.ClientSurname.Name = "ClientSurname";
            this.ClientSurname.Size = new System.Drawing.Size(211, 29);
            this.ClientSurname.TabIndex = 17;
            // 
            // ClientName
            // 
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ClientName.Location = new System.Drawing.Point(3, 35);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(211, 29);
            this.ClientName.TabIndex = 13;
            // 
            // ClientAge
            // 
            this.ClientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ClientAge.Location = new System.Drawing.Point(7, 189);
            this.ClientAge.Name = "ClientAge";
            this.ClientAge.Size = new System.Drawing.Size(47, 29);
            this.ClientAge.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.Location = new System.Drawing.Point(3, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 20);
            this.label19.TabIndex = 24;
            this.label19.Text = "Вклад";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(3, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 20);
            this.label20.TabIndex = 23;
            this.label20.Text = "Имя";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.Location = new System.Drawing.Point(3, 156);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 20);
            this.label21.TabIndex = 22;
            this.label21.Text = "Телефон";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button3.Location = new System.Drawing.Point(3, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 69);
            this.button3.TabIndex = 19;
            this.button3.Text = "Внести данные о партнере";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PartnerAttach
            // 
            this.PartnerAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PartnerAttach.Location = new System.Drawing.Point(3, 112);
            this.PartnerAttach.Name = "PartnerAttach";
            this.PartnerAttach.Size = new System.Drawing.Size(211, 29);
            this.PartnerAttach.TabIndex = 17;
            // 
            // PartnerName
            // 
            this.PartnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PartnerName.Location = new System.Drawing.Point(3, 33);
            this.PartnerName.Name = "PartnerName";
            this.PartnerName.Size = new System.Drawing.Size(211, 29);
            this.PartnerName.TabIndex = 13;
            // 
            // PartnerPhone
            // 
            this.PartnerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PartnerPhone.Location = new System.Drawing.Point(3, 193);
            this.PartnerPhone.Name = "PartnerPhone";
            this.PartnerPhone.Size = new System.Drawing.Size(270, 29);
            this.PartnerPhone.TabIndex = 14;
            // 
            // DataProduct
            // 
            this.DataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProduct.Location = new System.Drawing.Point(0, 0);
            this.DataProduct.Name = "DataProduct";
            this.DataProduct.Size = new System.Drawing.Size(681, 296);
            this.DataProduct.TabIndex = 0;
            // 
            // DataGridClient
            // 
            this.DataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClient.Location = new System.Drawing.Point(0, 0);
            this.DataGridClient.Name = "DataGridClient";
            this.DataGridClient.Size = new System.Drawing.Size(678, 292);
            this.DataGridClient.TabIndex = 0;
            // 
            // DataGridPartnet
            // 
            this.DataGridPartnet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPartnet.Location = new System.Drawing.Point(-4, 0);
            this.DataGridPartnet.Name = "DataGridPartnet";
            this.DataGridPartnet.Size = new System.Drawing.Size(685, 295);
            this.DataGridPartnet.TabIndex = 0;
            // 
            // ProductSelect
            // 
            this.ProductSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProductSelect.Location = new System.Drawing.Point(0, 300);
            this.ProductSelect.Name = "ProductSelect";
            this.ProductSelect.Size = new System.Drawing.Size(669, 46);
            this.ProductSelect.TabIndex = 1;
            this.ProductSelect.Text = "Вывести данные о продуктах";
            this.ProductSelect.UseVisualStyleBackColor = true;
            this.ProductSelect.Click += new System.EventHandler(this.ProductSelect_Click);
            // 
            // SelectClient
            // 
            this.SelectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SelectClient.Location = new System.Drawing.Point(3, 298);
            this.SelectClient.Name = "SelectClient";
            this.SelectClient.Size = new System.Drawing.Size(669, 46);
            this.SelectClient.TabIndex = 1;
            this.SelectClient.Text = "Вывести данные о клиентах";
            this.SelectClient.UseVisualStyleBackColor = true;
            this.SelectClient.Click += new System.EventHandler(this.SelectClient_Click);
            // 
            // PartnerSelect
            // 
            this.PartnerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PartnerSelect.Location = new System.Drawing.Point(0, 300);
            this.PartnerSelect.Name = "PartnerSelect";
            this.PartnerSelect.Size = new System.Drawing.Size(669, 46);
            this.PartnerSelect.TabIndex = 1;
            this.PartnerSelect.Text = "Вывести данные о партнерах";
            this.PartnerSelect.UseVisualStyleBackColor = true;
            this.PartnerSelect.Click += new System.EventHandler(this.PartnerSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 393);
            this.Controls.Add(this.SQLReader_Test);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Данные компании";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.SQLReader_Test.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPartnet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button WorkersSelectButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button InsertWorker;
        private System.Windows.Forms.TextBox WorkerExpirienceTextBox;
        private System.Windows.Forms.TextBox WorkerSalaryTextBox;
        private System.Windows.Forms.TextBox WorkerSurnameTextBox;
        private System.Windows.Forms.TextBox WorkerNameTextBox;
        private System.Windows.Forms.TextBox WorkerAgeTextBox;
        private System.Windows.Forms.TextBox WorkerPostTextBox;
        private System.Windows.Forms.TabControl SQLReader_Test;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button InsertProduct;
        private System.Windows.Forms.TextBox ProductCost;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ProductSelect;
        private System.Windows.Forms.DataGridView DataProduct;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button InsertClient;
        private System.Windows.Forms.TextBox ClientPhone;
        private System.Windows.Forms.TextBox ClientSurname;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox ClientAge;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button SelectClient;
        private System.Windows.Forms.DataGridView DataGridClient;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PartnerAttach;
        private System.Windows.Forms.TextBox PartnerName;
        private System.Windows.Forms.TextBox PartnerPhone;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button PartnerSelect;
        private System.Windows.Forms.DataGridView DataGridPartnet;
    }
}

