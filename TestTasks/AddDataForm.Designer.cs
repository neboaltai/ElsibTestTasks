namespace TestTask
{
    partial class AddDataForm
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
            codeTextBox = new TextBox();
            materialTextBox = new TextBox();
            costTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // codeTextBox
            // 
            codeTextBox.BorderStyle = BorderStyle.FixedSingle;
            codeTextBox.Location = new Point(3, 18);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(160, 23);
            codeTextBox.TabIndex = 0;
            // 
            // materialTextBox
            // 
            materialTextBox.BorderStyle = BorderStyle.FixedSingle;
            materialTextBox.Location = new Point(3, 73);
            materialTextBox.Name = "materialTextBox";
            materialTextBox.Size = new Size(160, 23);
            materialTextBox.TabIndex = 1;
            // 
            // costTextBox
            // 
            costTextBox.BorderStyle = BorderStyle.FixedSingle;
            costTextBox.Location = new Point(3, 128);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(160, 23);
            costTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(3, 157);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 3;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(88, 157);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 5;
            label1.Text = "Код";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 6;
            label2.Text = "Наименование материала";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 110);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "Стоимость";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(codeTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(materialTextBox);
            panel1.Controls.Add(costTextBox);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(saveButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 180);
            panel1.TabIndex = 8;
            // 
            // AddMaterialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 206);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddMaterialForm";
            Text = "Добавление материала";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox codeTextBox;
        private TextBox materialTextBox;
        private TextBox costTextBox;
        private Button saveButton;
        private Button cancelButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
    }
}