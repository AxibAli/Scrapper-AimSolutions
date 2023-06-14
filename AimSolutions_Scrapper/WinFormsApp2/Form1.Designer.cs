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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter URL:";
            // 
            // Url_field
            // 
            Url_field.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Url_field.Location = new Point(100, 26);
            Url_field.Name = "Url_field";
            Url_field.Size = new Size(460, 27);
            Url_field.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(364, 149);
            button1.Name = "button1";
            button1.Size = new Size(196, 30);
            button1.TabIndex = 2;
            button1.Text = "Create and Download CSV";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Brand_RadioButton
            // 
            Brand_RadioButton.AutoSize = true;
            Brand_RadioButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Brand_RadioButton.Location = new Point(100, 70);
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
            Model_RadioButton.Location = new Point(100, 95);
            Model_RadioButton.Name = "Model_RadioButton";
            Model_RadioButton.Size = new Size(135, 21);
            Model_RadioButton.TabIndex = 4;
            Model_RadioButton.TabStop = true;
            Model_RadioButton.Text = "Check For Models";
            Model_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Defect_RadioButton
            // 
            Defect_RadioButton.AutoSize = true;
            Defect_RadioButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Defect_RadioButton.Location = new Point(100, 120);
            Defect_RadioButton.Name = "Defect_RadioButton";
            Defect_RadioButton.Size = new Size(130, 21);
            Defect_RadioButton.TabIndex = 5;
            Defect_RadioButton.TabStop = true;
            Defect_RadioButton.Text = "Check For Defect";
            Defect_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 191);
            Controls.Add(Defect_RadioButton);
            Controls.Add(Model_RadioButton);
            Controls.Add(Brand_RadioButton);
            Controls.Add(button1);
            Controls.Add(Url_field);
            Controls.Add(label1);
            MaximumSize = new Size(586, 230);
            MinimumSize = new Size(586, 230);
            Name = "Form1";
            Text = "Aimsolutions Scrapper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Url_field;
        private Button button1;
        private RadioButton Brand_RadioButton;
        private RadioButton Model_RadioButton;
        private RadioButton Defect_RadioButton;
    }
}