
namespace QR_code_generator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbL = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.pbxQr = new System.Windows.Forms.PictureBox();
            this.rbQ = new System.Windows.Forms.RadioButton();
            this.rbH = new System.Windows.Forms.RadioButton();
            this.btnCopy = new System.Windows.Forms.Button();
            this.cbxLogo = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbM);
            this.panel1.Controls.Add(this.rbH);
            this.panel1.Controls.Add(this.rbQ);
            this.panel1.Controls.Add(this.rbL);
            this.panel1.Location = new System.Drawing.Point(526, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 100);
            this.panel1.TabIndex = 0;
            // 
            // rbL
            // 
            this.rbL.AutoSize = true;
            this.rbL.Checked = true;
            this.rbL.Location = new System.Drawing.Point(13, 19);
            this.rbL.Name = "rbL";
            this.rbL.Size = new System.Drawing.Size(71, 21);
            this.rbL.TabIndex = 0;
            this.rbL.TabStop = true;
            this.rbL.Text = "L (7%)";
            this.rbL.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 153);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(507, 125);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Сгенерировать код";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Checked = true;
            this.rbM.Location = new System.Drawing.Point(13, 62);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(82, 21);
            this.rbM.TabIndex = 0;
            this.rbM.TabStop = true;
            this.rbM.Text = "M (15%)";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 13);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(507, 134);
            this.tbInput.TabIndex = 2;
            // 
            // pbxQr
            // 
            this.pbxQr.BackColor = System.Drawing.SystemColors.Window;
            this.pbxQr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxQr.Location = new System.Drawing.Point(526, 13);
            this.pbxQr.Name = "pbxQr";
            this.pbxQr.Size = new System.Drawing.Size(262, 265);
            this.pbxQr.TabIndex = 3;
            this.pbxQr.TabStop = false;
            // 
            // rbQ
            // 
            this.rbQ.AutoSize = true;
            this.rbQ.Checked = true;
            this.rbQ.Location = new System.Drawing.Point(127, 18);
            this.rbQ.Name = "rbQ";
            this.rbQ.Size = new System.Drawing.Size(82, 21);
            this.rbQ.TabIndex = 0;
            this.rbQ.TabStop = true;
            this.rbQ.Text = "Q (25%)";
            this.rbQ.UseVisualStyleBackColor = true;
            // 
            // rbH
            // 
            this.rbH.AutoSize = true;
            this.rbH.Checked = true;
            this.rbH.Location = new System.Drawing.Point(127, 62);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(81, 21);
            this.rbH.TabIndex = 0;
            this.rbH.TabStop = true;
            this.rbH.Text = "H (30%)";
            this.rbH.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Location = new System.Drawing.Point(12, 284);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(507, 130);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Скопировать код";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cbxLogo
            // 
            this.cbxLogo.AutoSize = true;
            this.cbxLogo.Checked = true;
            this.cbxLogo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxLogo.Location = new System.Drawing.Point(525, 284);
            this.cbxLogo.Name = "cbxLogo";
            this.cbxLogo.Size = new System.Drawing.Size(137, 24);
            this.cbxLogo.TabIndex = 1;
            this.cbxLogo.Text = "Логотип TEL";
            this.cbxLogo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.cbxLogo);
            this.Controls.Add(this.pbxQr);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Generator TEL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbL;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton rbH;
        private System.Windows.Forms.RadioButton rbQ;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.PictureBox pbxQr;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox cbxLogo;
    }
}

