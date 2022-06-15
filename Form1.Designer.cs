
namespace TestAUTHH
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
            this.components = new System.ComponentModel.Container();
            this.LoginLab = new System.Windows.Forms.Label();
            this.PasswordLab = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LogINButton = new System.Windows.Forms.Button();
            this.errlab = new System.Windows.Forms.Label();
            this.capthPB = new System.Windows.Forms.PictureBox();
            this.capctchTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.capthPB)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLab
            // 
            this.LoginLab.AutoSize = true;
            this.LoginLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLab.Location = new System.Drawing.Point(121, 44);
            this.LoginLab.Name = "LoginLab";
            this.LoginLab.Size = new System.Drawing.Size(71, 25);
            this.LoginLab.TabIndex = 0;
            this.LoginLab.Text = "Логин";
            // 
            // PasswordLab
            // 
            this.PasswordLab.AutoSize = true;
            this.PasswordLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLab.Location = new System.Drawing.Point(121, 106);
            this.PasswordLab.Name = "PasswordLab";
            this.PasswordLab.Size = new System.Drawing.Size(86, 25);
            this.PasswordLab.TabIndex = 0;
            this.PasswordLab.Text = "Пароль";
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(236, 44);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(100, 31);
            this.LoginTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.Location = new System.Drawing.Point(236, 103);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(100, 31);
            this.PasswordTB.TabIndex = 1;
            // 
            // LogINButton
            // 
            this.LogINButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogINButton.Location = new System.Drawing.Point(126, 193);
            this.LogINButton.Name = "LogINButton";
            this.LogINButton.Size = new System.Drawing.Size(216, 86);
            this.LogINButton.TabIndex = 2;
            this.LogINButton.Text = "Войти";
            this.LogINButton.UseVisualStyleBackColor = true;
            this.LogINButton.Click += new System.EventHandler(this.LogINButton_Click);
            // 
            // errlab
            // 
            this.errlab.AutoSize = true;
            this.errlab.Location = new System.Drawing.Point(123, 153);
            this.errlab.Name = "errlab";
            this.errlab.Size = new System.Drawing.Size(35, 13);
            this.errlab.TabIndex = 3;
            this.errlab.Text = "label1";
            // 
            // capthPB
            // 
            this.capthPB.Location = new System.Drawing.Point(517, 45);
            this.capthPB.Name = "capthPB";
            this.capthPB.Size = new System.Drawing.Size(132, 73);
            this.capthPB.TabIndex = 4;
            this.capthPB.TabStop = false;
            this.capthPB.Visible = false;
            // 
            // capctchTB
            // 
            this.capctchTB.Location = new System.Drawing.Point(517, 136);
            this.capctchTB.Name = "capctchTB";
            this.capctchTB.Size = new System.Drawing.Size(132, 20);
            this.capctchTB.TabIndex = 6;
            this.capctchTB.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.capctchTB);
            this.Controls.Add(this.capthPB);
            this.Controls.Add(this.errlab);
            this.Controls.Add(this.LogINButton);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.PasswordLab);
            this.Controls.Add(this.LoginLab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capthPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLab;
        private System.Windows.Forms.Label PasswordLab;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button LogINButton;
        private System.Windows.Forms.Label errlab;
        private System.Windows.Forms.PictureBox capthPB;
        private System.Windows.Forms.TextBox capctchTB;
        private System.Windows.Forms.Timer timer1;
    }
}

