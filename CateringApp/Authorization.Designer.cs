namespace CateringApp
{
    partial class Authorization
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
            this.components = new System.ComponentModel.Container();
            this.button_signin = new System.Windows.Forms.Button();
            this.label_error_status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cateringDataSet = new CateringApp.СateringDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autentTableAdapter1 = new CateringApp.СateringDataSetTableAdapters.AutentTableAdapter();
            this.autentTableAdapter2 = new CateringApp.СateringDataSetTableAdapters.AutentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cateringDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_signin
            // 
            this.button_signin.Font = new System.Drawing.Font("Times New Roman", 14.8F);
            this.button_signin.Location = new System.Drawing.Point(115, 334);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(151, 57);
            this.button_signin.TabIndex = 0;
            this.button_signin.Text = "Войти";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // label_error_status
            // 
            this.label_error_status.AutoSize = true;
            this.label_error_status.Location = new System.Drawing.Point(149, 463);
            this.label_error_status.Name = "label_error_status";
            this.label_error_status.Size = new System.Drawing.Size(104, 17);
            this.label_error_status.TabIndex = 1;
            this.label_error_status.Text = "____________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.8F);
            this.label2.Location = new System.Drawing.Point(70, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.8F);
            this.label3.Location = new System.Drawing.Point(70, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Times New Roman", 14.8F);
            this.textBox_login.Location = new System.Drawing.Point(72, 148);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(266, 36);
            this.textBox_login.TabIndex = 4;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Times New Roman", 14.8F);
            this.textBox_password.Location = new System.Drawing.Point(72, 261);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(266, 36);
            this.textBox_password.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Авторизация в системе";
            // 
            // cateringDataSet
            // 
            this.cateringDataSet.DataSetName = "СateringDataSet";
            this.cateringDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.cateringDataSet;
            this.bindingSource1.Position = 0;
            // 
            // autentTableAdapter1
            // 
            this.autentTableAdapter1.ClearBeforeFill = true;
            // 
            // autentTableAdapter2
            // 
            this.autentTableAdapter2.ClearBeforeFill = true;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 489);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_error_status);
            this.Controls.Add(this.button_signin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)(this.cateringDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.Label label_error_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label4;
        private СateringDataSet cateringDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private СateringDataSetTableAdapters.AutentTableAdapter autentTableAdapter1;
        private СateringDataSetTableAdapters.AutentTableAdapter autentTableAdapter2;
    }
}

