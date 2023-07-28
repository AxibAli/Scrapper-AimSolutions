namespace WinFormsApp2
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
            label1 = new Label();
            Url_field = new TextBox();
            button1 = new Button();
            Brand_RadioButton = new RadioButton();
            Model_RadioButton = new RadioButton();
            Defect_RadioButton = new RadioButton();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            copyData = new Button();
            genrateData = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 0;
            label1.Text = "Enter URL:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Url_field
            // 
            Url_field.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Url_field.Location = new Point(107, 3);
            Url_field.Name = "Url_field";
            Url_field.Size = new Size(446, 27);
            Url_field.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(271, 131);
            button1.Name = "button1";
            button1.Size = new Size(210, 28);
            button1.TabIndex = 2;
            button1.Text = "Create and Download CSV";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Brand_RadioButton
            // 
            Brand_RadioButton.AutoSize = true;
            Brand_RadioButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Brand_RadioButton.Location = new Point(3, 3);
            Brand_RadioButton.Name = "Brand_RadioButton";
            Brand_RadioButton.Size = new Size(132, 21);
            Brand_RadioButton.TabIndex = 3;
            Brand_RadioButton.TabStop = true;
            Brand_RadioButton.Text = "Check For Brands";
            Brand_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Model_RadioButton
            // 
            Model_RadioButton.AutoSize = true;
            Model_RadioButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Model_RadioButton.Location = new Point(3, 30);
            Model_RadioButton.Name = "Model_RadioButton";
            Model_RadioButton.Size = new Size(135, 21);
            Model_RadioButton.TabIndex = 4;
            Model_RadioButton.TabStop = true;
            Model_RadioButton.Text = "Check For Models";
            Model_RadioButton.UseVisualStyleBackColor = true;
            Model_RadioButton.CheckedChanged += Model_RadioButton_CheckedChanged;
            // 
            // Defect_RadioButton
            // 
            Defect_RadioButton.AutoSize = true;
            Defect_RadioButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Defect_RadioButton.Location = new Point(3, 57);
            Defect_RadioButton.Name = "Defect_RadioButton";
            Defect_RadioButton.Size = new Size(130, 21);
            Defect_RadioButton.TabIndex = 5;
            Defect_RadioButton.TabStop = true;
            Defect_RadioButton.Text = "Check For Defect";
            Defect_RadioButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(559, 472);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(1, 177);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(565, 478);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3421516F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.6578445F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(Url_field, 1, 0);
            tableLayoutPanel2.Location = new Point(1, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(567, 37);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(Model_RadioButton, 0, 1);
            tableLayoutPanel3.Controls.Add(Defect_RadioButton, 0, 2);
            tableLayoutPanel3.Controls.Add(Brand_RadioButton, 0, 0);
            tableLayoutPanel3.Location = new Point(12, 74);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(154, 81);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(copyData, 1, 0);
            tableLayoutPanel4.Controls.Add(genrateData, 0, 0);
            tableLayoutPanel4.Location = new Point(226, 89);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(305, 36);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // copyData
            // 
            copyData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            copyData.Location = new Point(155, 3);
            copyData.Name = "copyData";
            copyData.Size = new Size(147, 28);
            copyData.TabIndex = 4;
            copyData.Text = "Copy Data";
            copyData.UseVisualStyleBackColor = true;
            copyData.Click += copyData_Click;
            // 
            // genrateData
            // 
            genrateData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            genrateData.Location = new Point(3, 3);
            genrateData.Name = "genrateData";
            genrateData.Size = new Size(146, 28);
            genrateData.TabIndex = 3;
            genrateData.Text = "Genrate Data";
            genrateData.UseVisualStyleBackColor = true;
            genrateData.Click += genrateData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 657);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximumSize = new Size(586, 700);
            MinimumSize = new Size(586, 700);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aimsolutions Scrapper";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox Url_field;
        private Button button1;
        private RadioButton Brand_RadioButton;
        private RadioButton Model_RadioButton;
        private RadioButton Defect_RadioButton;
        private RichTextBox richTextBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button copyData;
        private Button genrateData;
    }
}