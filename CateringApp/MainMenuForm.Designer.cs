namespace CateringApp
{
    partial class MainMenuForm
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
            this.buttonPricerWin = new System.Windows.Forms.Button();
            this.buttonCookerWin = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPricerWin
            // 
            this.buttonPricerWin.Location = new System.Drawing.Point(160, 65);
            this.buttonPricerWin.Name = "buttonPricerWin";
            this.buttonPricerWin.Size = new System.Drawing.Size(198, 62);
            this.buttonPricerWin.TabIndex = 0;
            this.buttonPricerWin.Text = "Окно кассира";
            this.buttonPricerWin.UseVisualStyleBackColor = true;
            this.buttonPricerWin.Click += new System.EventHandler(this.buttonPricerWin_Click);
            // 
            // buttonCookerWin
            // 
            this.buttonCookerWin.Location = new System.Drawing.Point(160, 151);
            this.buttonCookerWin.Name = "buttonCookerWin";
            this.buttonCookerWin.Size = new System.Drawing.Size(198, 62);
            this.buttonCookerWin.TabIndex = 1;
            this.buttonCookerWin.Text = "Окно повара";
            this.buttonCookerWin.UseVisualStyleBackColor = true;
            this.buttonCookerWin.Click += new System.EventHandler(this.buttonCookerWin_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(160, 237);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(198, 62);
            this.buttonAddProduct.TabIndex = 2;
            this.buttonAddProduct.Text = "Добавить позиции на продажу";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(436, 402);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(131, 35);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 441);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonCookerWin);
            this.Controls.Add(this.buttonPricerWin);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPricerWin;
        private System.Windows.Forms.Button buttonCookerWin;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonExit;
    }
}