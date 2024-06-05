namespace DAI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            typeBox = new ComboBox();
            deleteButton = new Button();
            label4 = new Label();
            authorBox = new TextBox();
            label3 = new Label();
            titleBox = new TextBox();
            label2 = new Label();
            SearchButton = new Button();
            resultList = new ListBox();
            bookBindingSource = new BindingSource(components);
            addCarButton = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1033, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, toolStripSeparator, сохранитьToolStripMenuItem, toolStripSeparator1, toolStripSeparator2, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(216, 26);
            открытьToolStripMenuItem.Text = "&Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(213, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
            сохранитьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(216, 26);
            сохранитьToolStripMenuItem.Text = "&Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(213, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(213, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(216, 26);
            выходToolStripMenuItem.Text = "Вы&ход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(typeBox);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(authorBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(titleBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SearchButton);
            panel1.Location = new Point(177, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 263);
            panel1.TabIndex = 1;
            // 
            // typeBox
            // 
            typeBox.FormattingEnabled = true;
            typeBox.Items.AddRange(new object[] { "Легковий", "Мотоцикл", "Вантажівка" });
            typeBox.Location = new Point(176, 72);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(443, 28);
            typeBox.TabIndex = 10;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(425, 220);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 80);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 7;
            label4.Text = "Тип";
            // 
            // authorBox
            // 
            authorBox.Location = new Point(176, 43);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(443, 27);
            authorBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 50);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Власник";
            // 
            // titleBox
            // 
            titleBox.Location = new Point(176, 13);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(443, 27);
            titleBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 20);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 3;
            label2.Text = "Номерний знак";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(525, 220);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += searchButton_Click;
            // 
            // resultList
            // 
            resultList.Anchor = AnchorStyles.Top;
            resultList.DataSource = bookBindingSource;
            resultList.DisplayMember = "Nomera";
            resultList.FormattingEnabled = true;
            resultList.Location = new Point(237, 355);
            resultList.Name = "resultList";
            resultList.Size = new Size(551, 244);
            resultList.TabIndex = 2;
            resultList.ValueMember = "Id";
            resultList.DoubleClick += resultList_DoubleClick;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Car);
            // 
            // addCarButton
            // 
            addCarButton.Anchor = AnchorStyles.Top;
            addCarButton.Location = new Point(858, 87);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(136, 40);
            addCarButton.TabIndex = 3;
            addCarButton.Text = "Додати ТЗ";
            addCarButton.UseVisualStyleBackColor = true;
            addCarButton.Click += addCarButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1033, 611);
            Controls.Add(addCarButton);
            Controls.Add(resultList);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(648, 406);
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Panel panel1;
        private Button SearchButton;
        private TextBox authorBox;
        private Label label3;
        private TextBox titleBox;
        private Label label2;
        private ListBox resultList;
        private BindingSource bookBindingSource;
        private Label label4;
        private Button addCarButton;
        private Button deleteButton;
        private ComboBox typeBox;
    }
}