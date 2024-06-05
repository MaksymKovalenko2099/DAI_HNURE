namespace DAI.Forms
{
    partial class AddCarForm
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
            eventDateTimeBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            colorBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            modelBox = new TextBox();
            markaBox = new TextBox();
            yearBox = new TextBox();
            label1 = new Label();
            authorBox = new TextBox();
            label5 = new Label();
            title1Box = new TextBox();
            label6 = new Label();
            addButton = new Button();
            typeBox = new ComboBox();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // eventDateTimeBox
            // 
            eventDateTimeBox.BackColor = Color.AliceBlue;
            eventDateTimeBox.Location = new Point(262, 343);
            eventDateTimeBox.Name = "eventDateTimeBox";
            eventDateTimeBox.Size = new Size(444, 27);
            eventDateTimeBox.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(108, 350);
            label9.Name = "label9";
            label9.Size = new Size(148, 20);
            label9.TabIndex = 38;
            label9.Text = "Дата останнього ТО";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 182);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 36;
            label8.Text = "Тип ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 306);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 35;
            label4.Text = "Колір";
            // 
            // colorBox
            // 
            colorBox.BackColor = Color.White;
            colorBox.Location = new Point(262, 299);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(444, 27);
            colorBox.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 263);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 33;
            label3.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 223);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 32;
            label2.Text = "Марка";
            // 
            // modelBox
            // 
            modelBox.Location = new Point(262, 256);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(444, 27);
            modelBox.TabIndex = 31;
            // 
            // markaBox
            // 
            markaBox.Location = new Point(262, 216);
            markaBox.Name = "markaBox";
            markaBox.Size = new Size(444, 27);
            markaBox.TabIndex = 30;
            // 
            // yearBox
            // 
            yearBox.Location = new Point(262, 139);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(444, 27);
            yearBox.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 142);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 28;
            label1.Text = "Рік випуску";
            // 
            // authorBox
            // 
            authorBox.Location = new Point(262, 100);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(444, 27);
            authorBox.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 107);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 26;
            label5.Text = "Власник";
            // 
            // title1Box
            // 
            title1Box.Location = new Point(262, 64);
            title1Box.Name = "title1Box";
            title1Box.Size = new Size(444, 27);
            title1Box.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 71);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 24;
            label6.Text = "Номерний знак";
            // 
            // addButton
            // 
            addButton.Location = new Point(467, 435);
            addButton.Name = "addButton";
            addButton.Size = new Size(141, 32);
            addButton.TabIndex = 40;
            addButton.Text = "OK";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // typeBox
            // 
            typeBox.FormattingEnabled = true;
            typeBox.Items.AddRange(new object[] { "Легковий", "Мотоцикл", "Вантажівка" });
            typeBox.Location = new Point(262, 179);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(444, 28);
            typeBox.TabIndex = 41;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(637, 437);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(137, 31);
            cancelButton.TabIndex = 42;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(813, 536);
            Controls.Add(cancelButton);
            Controls.Add(typeBox);
            Controls.Add(addButton);
            Controls.Add(eventDateTimeBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(colorBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(modelBox);
            Controls.Add(markaBox);
            Controls.Add(yearBox);
            Controls.Add(label1);
            Controls.Add(authorBox);
            Controls.Add(label5);
            Controls.Add(title1Box);
            Controls.Add(label6);
            Name = "AddCarForm";
            Text = "AddCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox eventDateTimeBox;
        private Label label9;
        private Label label8;
        private Label label4;
        public TextBox colorBox;
        private Label label3;
        private Label label2;
        public TextBox modelBox;
        public TextBox markaBox;
        private TextBox yearBox;
        private Label label1;
        private TextBox authorBox;
        private Label label5;
        public TextBox title1Box;
        private Label label6;
        private Button addButton;
        private ComboBox typeBox;
        private Button cancelButton;
    }
}