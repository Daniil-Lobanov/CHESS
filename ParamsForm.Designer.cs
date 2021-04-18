namespace _5_с_
{
    partial class ParamsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите размерность доски";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(58, 100);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(77, 26);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 55);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(265, 22);
            this.Input.TabIndex = 0;
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(151, 100);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(77, 26);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 154);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ParamsForm";
            this.Text = "Ввод";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ParamsForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button CancelButton;
    }
}