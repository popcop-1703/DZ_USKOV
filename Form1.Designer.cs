namespace DZ_USKOV
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
            this.buttonAdlai = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxPers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdlai
            // 
            this.buttonAdlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdlai.Location = new System.Drawing.Point(154, 253);
            this.buttonAdlai.Name = "buttonAdlai";
            this.buttonAdlai.Size = new System.Drawing.Size(135, 72);
            this.buttonAdlai.TabIndex = 0;
            this.buttonAdlai.Text = "Расчет по адлаю";
            this.buttonAdlai.UseVisualStyleBackColor = true;
            this.buttonAdlai.Click += new System.EventHandler(this.buttonAdlai_Click_1);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(154, 40);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(154, 85);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 2;
            // 
            // textBoxPers
            // 
            this.textBoxPers.Location = new System.Drawing.Point(154, 133);
            this.textBoxPers.Name = "textBoxPers";
            this.textBoxPers.Size = new System.Drawing.Size(100, 22);
            this.textBoxPers.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPers);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.buttonAdlai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdlai;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxPers;
    }
}

