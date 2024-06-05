namespace DAI.Forms
{
    partial class CarEditDialog
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
            panel1 = new Panel();
            eventDateTimeBox = new TextBox();
            label9 = new Label();
            button1 = new Button();
            typeBox = new TextBox();
            label8 = new Label();
            label4 = new Label();
            colorBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            modelBox = new TextBox();
            markaBox = new TextBox();
            yearBox = new TextBox();
            label1 = new Label();
            CancelButton = new Button();
            authorBox = new TextBox();
            label5 = new Label();
            titleBox = new TextBox();
            label6 = new Label();
            OKButton = new Button();
            idBox = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(eventDateTimeBox);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(typeBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(colorBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(modelBox);
            panel1.Controls.Add(markaBox);
            panel1.Controls.Add(yearBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(authorBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(titleBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(OKButton);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(256, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 554);
            panel1.TabIndex = 4;
            // 
            // eventDateTimeBox
            // 
            eventDateTimeBox.BackColor = Color.AliceBlue;
            eventDateTimeBox.Location = new Point(157, 334);
            eventDateTimeBox.Name = "eventDateTimeBox";
            eventDateTimeBox.Size = new Size(444, 27);
            eventDateTimeBox.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 341);
            label9.Name = "label9";
            label9.Size = new Size(148, 20);
            label9.TabIndex = 20;
            label9.Text = "Дата останнього ТО";
            // 
            // button1
            // 
            button1.Location = new Point(45, 424);
            button1.Name = "button1";
            button1.Size = new Size(150, 39);
            button1.TabIndex = 19;
            button1.Text = "Історія техогляду";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // typeBox
            // 
            typeBox.Location = new Point(157, 166);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(444, 27);
            typeBox.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 173);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 17;
            label8.Text = "Тип ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 297);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 16;
            label4.Text = "Колір";
            // 
            // colorBox
            // 
            colorBox.BackColor = Color.White;
            colorBox.Location = new Point(157, 290);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(444, 27);
            colorBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 254);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 13;
            label3.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 214);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 12;
            label2.Text = "Марка";
            // 
            // modelBox
            // 
            modelBox.Location = new Point(157, 247);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(444, 27);
            modelBox.TabIndex = 11;
            // 
            // markaBox
            // 
            markaBox.Location = new Point(157, 207);
            markaBox.Name = "markaBox";
            markaBox.Size = new Size(444, 27);
            markaBox.TabIndex = 10;
            // 
            // yearBox
            // 
            yearBox.Location = new Point(157, 130);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(444, 27);
            yearBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 133);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 8;
            label1.Text = "Рік випуску";
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(545, 504);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(98, 30);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // authorBox
            // 
            authorBox.Location = new Point(157, 91);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(444, 27);
            authorBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 98);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 5;
            label5.Text = "Власник";
            // 
            // titleBox
            // 
            titleBox.Location = new Point(157, 55);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(444, 27);
            titleBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 62);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 3;
            label6.Text = "Номерний знак";
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.Location = new Point(433, 504);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(94, 29);
            OKButton.TabIndex = 2;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // idBox
            // 
            idBox.Enabled = false;
            idBox.Location = new Point(157, 19);
            idBox.Name = "idBox";
            idBox.Size = new Size(444, 27);
            idBox.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 26);
            label7.Name = "label7";
            label7.Size = new Size(22, 20);
            label7.TabIndex = 0;
            label7.Text = "Id";
            // 
            // CarEditDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1117, 684);
            Controls.Add(panel1);
            Name = "CarEditDialog";
            Text = "CarEditDialog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox authorBox;
        private Label label5;
        public TextBox titleBox;
        private Label label6;
        private Button OKButton;
        private TextBox idBox;
        private Label label7;
        private Button CancelButton;
        private TextBox yearBox;
        private Label label1;
        private Label label3;
        private Label label2;
        public TextBox modelBox;
        public TextBox markaBox;
        public TextBox colorBox;
        private Label label4;
        private TextBox typeBox;
        private Label label8;
        private Button button1;
        public TextBox eventDateTimeBox;
        private Label label9;
    }
}