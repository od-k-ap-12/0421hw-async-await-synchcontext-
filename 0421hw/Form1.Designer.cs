namespace _0421hw
{
    partial class Form1
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
            this.buttonV6 = new System.Windows.Forms.Button();
            this.buttonV7 = new System.Windows.Forms.Button();
            this.buttonV9 = new System.Windows.Forms.Button();
            this.buttonV8 = new System.Windows.Forms.Button();
            this.buttonV10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonV6
            // 
            this.buttonV6.Location = new System.Drawing.Point(43, 50);
            this.buttonV6.Name = "buttonV6";
            this.buttonV6.Size = new System.Drawing.Size(183, 38);
            this.buttonV6.TabIndex = 0;
            this.buttonV6.Text = "Сотрудники фирмы (в6)";
            this.buttonV6.UseVisualStyleBackColor = true;
            this.buttonV6.Click += new System.EventHandler(this.buttonV6_Click);
            // 
            // buttonV7
            // 
            this.buttonV7.Location = new System.Drawing.Point(43, 110);
            this.buttonV7.Name = "buttonV7";
            this.buttonV7.Size = new System.Drawing.Size(183, 38);
            this.buttonV7.TabIndex = 1;
            this.buttonV7.Text = "Сотрудники фирмы (в7)";
            this.buttonV7.UseVisualStyleBackColor = true;
            this.buttonV7.Click += new System.EventHandler(this.buttonV7_Click);
            // 
            // buttonV9
            // 
            this.buttonV9.Location = new System.Drawing.Point(42, 228);
            this.buttonV9.Name = "buttonV9";
            this.buttonV9.Size = new System.Drawing.Size(183, 38);
            this.buttonV9.TabIndex = 3;
            this.buttonV9.Text = "Библиотека ";
            this.buttonV9.UseVisualStyleBackColor = true;
            this.buttonV9.Click += new System.EventHandler(this.buttonV9_Click);
            // 
            // buttonV8
            // 
            this.buttonV8.Location = new System.Drawing.Point(42, 168);
            this.buttonV8.Name = "buttonV8";
            this.buttonV8.Size = new System.Drawing.Size(183, 38);
            this.buttonV8.TabIndex = 2;
            this.buttonV8.Text = "Студенты";
            this.buttonV8.UseVisualStyleBackColor = true;
            this.buttonV8.Click += new System.EventHandler(this.buttonV8_Click);
            // 
            // buttonV10
            // 
            this.buttonV10.Location = new System.Drawing.Point(43, 286);
            this.buttonV10.Name = "buttonV10";
            this.buttonV10.Size = new System.Drawing.Size(183, 38);
            this.buttonV10.TabIndex = 4;
            this.buttonV10.Text = "Магазин";
            this.buttonV10.UseVisualStyleBackColor = true;
            this.buttonV10.Click += new System.EventHandler(this.buttonV10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ввести информацию";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(43, 402);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(184, 38);
            this.textBoxInput.TabIndex = 6;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(274, 46);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(447, 394);
            this.listBoxResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 485);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonV10);
            this.Controls.Add(this.buttonV9);
            this.Controls.Add(this.buttonV8);
            this.Controls.Add(this.buttonV7);
            this.Controls.Add(this.buttonV6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonV6;
        private System.Windows.Forms.Button buttonV7;
        private System.Windows.Forms.Button buttonV9;
        private System.Windows.Forms.Button buttonV8;
        private System.Windows.Forms.Button buttonV10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}

