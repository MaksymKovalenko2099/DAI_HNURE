using System.Windows.Forms;

namespace DAI.Forms
{
    partial class TechOglyad
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
            monthCalendar1 = new MonthCalendar();
            listBox1 = new ListBox();
            bookBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            okButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            zapysButton = new Button();
            cancelZapysButton = new Button();
            bookBindingSource1 = new BindingSource(components);
            infocarlabel = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Top;
            monthCalendar1.Location = new Point(674, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(674, 285);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(192, 144);
            listBox1.TabIndex = 1;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Car);
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(58, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(478, 321);
            dataGridView1.TabIndex = 3;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Top;
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(641, 492);
            okButton.Name = "okButton";
            okButton.Size = new Size(104, 27);
            okButton.TabIndex = 4;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(762, 492);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(104, 27);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(674, 262);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 6;
            label1.Text = "Історія техогляду";
            // 
            // zapysButton
            // 
            zapysButton.Location = new Point(318, 378);
            zapysButton.Name = "zapysButton";
            zapysButton.Size = new Size(100, 29);
            zapysButton.TabIndex = 7;
            zapysButton.Text = "Записати";
            zapysButton.UseVisualStyleBackColor = true;
            zapysButton.Click += zapysButton_Click;
            // 
            // cancelZapysButton
            // 
            cancelZapysButton.Location = new Point(436, 378);
            cancelZapysButton.Name = "cancelZapysButton";
            cancelZapysButton.Size = new Size(100, 29);
            cancelZapysButton.TabIndex = 8;
            cancelZapysButton.Text = "Відмінити ";
            cancelZapysButton.UseVisualStyleBackColor = true;
            cancelZapysButton.Click += cancelZapysButton_Click;
            // 
            // bookBindingSource1
            // 
            bookBindingSource1.DataSource = typeof(Models.Car);
            // 
            // infocarlabel
            // 
            infocarlabel.AutoSize = true;
            infocarlabel.Location = new Point(334, 23);
            infocarlabel.Name = "infocarlabel";
            infocarlabel.Size = new Size(50, 20);
            infocarlabel.TabIndex = 9;
            infocarlabel.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 27);
            textBox1.TabIndex = 10;
            // 
            // TechOglyad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(892, 546);
            Controls.Add(textBox1);
            Controls.Add(infocarlabel);
            Controls.Add(cancelZapysButton);
            Controls.Add(zapysButton);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(monthCalendar1);
            Name = "TechOglyad";
            Text = "TechOglyad";
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private ListBox listBox1;
        private BindingSource bookBindingSource;
        private DataGridView dataGridView1;
        private Button okButton;
        private Button cancelButton;
        private Label label1;
        private Button zapysButton;
        private Button cancelZapysButton;
        private BindingSource bookBindingSource1;
        private Label infocarlabel;
        private TextBox textBox1;
    }
}