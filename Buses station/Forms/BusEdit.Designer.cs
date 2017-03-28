namespace Buses_station.Forms
{
    partial class BusEdit
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberComboBox = new System.Windows.Forms.ComboBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 82);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 30);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Модель";
            // 
            // NumberComboBox
            // 
            this.NumberComboBox.FormattingEnabled = true;
            this.NumberComboBox.Location = new System.Drawing.Point(76, 16);
            this.NumberComboBox.Name = "NumberComboBox";
            this.NumberComboBox.Size = new System.Drawing.Size(194, 24);
            this.NumberComboBox.TabIndex = 5;
            this.NumberComboBox.SelectedIndexChanged += new System.EventHandler(this.NumberComboBox_SelectedIndexChanged);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(76, 54);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(195, 22);
            this.ModelTextBox.TabIndex = 6;
            this.ModelTextBox.TextChanged += new System.EventHandler(this.ModelTextBox_TextChanged);
            // 
            // BusEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 123);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.NumberComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusEdit";
            this.Text = "Довідник автобусів";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BusEdit_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NumberComboBox;
        private System.Windows.Forms.TextBox ModelTextBox;
    }
}