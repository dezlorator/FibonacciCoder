namespace FibonacciCoder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseFilebtn = new System.Windows.Forms.Button();
            this.CodeFilebtn = new System.Windows.Forms.Button();
            this.DecodeFilebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseFilebtn
            // 
            this.ChooseFilebtn.Location = new System.Drawing.Point(77, 34);
            this.ChooseFilebtn.Name = "ChooseFilebtn";
            this.ChooseFilebtn.Size = new System.Drawing.Size(206, 89);
            this.ChooseFilebtn.TabIndex = 0;
            this.ChooseFilebtn.Text = "Choose file";
            this.ChooseFilebtn.UseVisualStyleBackColor = true;
            this.ChooseFilebtn.Click += new System.EventHandler(this.ChooseFilebtn_Click);
            // 
            // CodeFilebtn
            // 
            this.CodeFilebtn.Location = new System.Drawing.Point(322, 34);
            this.CodeFilebtn.Name = "CodeFilebtn";
            this.CodeFilebtn.Size = new System.Drawing.Size(186, 89);
            this.CodeFilebtn.TabIndex = 1;
            this.CodeFilebtn.Text = "Code file";
            this.CodeFilebtn.UseVisualStyleBackColor = true;
            this.CodeFilebtn.Click += new System.EventHandler(this.CodeFilebtn_Click);
            // 
            // DecodeFilebtn
            // 
            this.DecodeFilebtn.Enabled = false;
            this.DecodeFilebtn.Location = new System.Drawing.Point(558, 34);
            this.DecodeFilebtn.Name = "DecodeFilebtn";
            this.DecodeFilebtn.Size = new System.Drawing.Size(186, 89);
            this.DecodeFilebtn.TabIndex = 2;
            this.DecodeFilebtn.Text = "Decode file";
            this.DecodeFilebtn.UseVisualStyleBackColor = true;
            this.DecodeFilebtn.Click += new System.EventHandler(this.DecodeFilebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DecodeFilebtn);
            this.Controls.Add(this.CodeFilebtn);
            this.Controls.Add(this.ChooseFilebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChooseFilebtn;
        private System.Windows.Forms.Button CodeFilebtn;
        private System.Windows.Forms.Button DecodeFilebtn;
    }
}

