
namespace MyFirstTempConvertWinForm
{
    partial class TemperatureConverter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.btn_Fahrenheit = new System.Windows.Forms.Button();
            this.btn_Celcius = new System.Windows.Forms.Button();
            this.btn_Kelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(61, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celcius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(77, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFahrenheit.Location = new System.Drawing.Point(201, 49);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(160, 30);
            this.txtFahrenheit.TabIndex = 3;
            // 
            // txtCelcius
            // 
            this.txtCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCelcius.Location = new System.Drawing.Point(201, 114);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(160, 30);
            this.txtCelcius.TabIndex = 4;
            // 
            // txtKelvin
            // 
            this.txtKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtKelvin.Location = new System.Drawing.Point(201, 179);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(160, 30);
            this.txtKelvin.TabIndex = 5;
            // 
            // btn_Fahrenheit
            // 
            this.btn_Fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Fahrenheit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Fahrenheit.Location = new System.Drawing.Point(409, 49);
            this.btn_Fahrenheit.Name = "btn_Fahrenheit";
            this.btn_Fahrenheit.Size = new System.Drawing.Size(80, 30);
            this.btn_Fahrenheit.TabIndex = 6;
            this.btn_Fahrenheit.Text = "Convert";
            this.btn_Fahrenheit.UseVisualStyleBackColor = true;
            this.btn_Fahrenheit.Click += new System.EventHandler(this.btn_Fahrenheit_Click);
            // 
            // btn_Celcius
            // 
            this.btn_Celcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Celcius.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Celcius.Location = new System.Drawing.Point(409, 114);
            this.btn_Celcius.Name = "btn_Celcius";
            this.btn_Celcius.Size = new System.Drawing.Size(80, 30);
            this.btn_Celcius.TabIndex = 7;
            this.btn_Celcius.Text = "Convert";
            this.btn_Celcius.UseVisualStyleBackColor = true;
            this.btn_Celcius.Click += new System.EventHandler(this.btn_Celcius_Click);
            // 
            // btn_Kelvin
            // 
            this.btn_Kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Kelvin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Kelvin.Location = new System.Drawing.Point(409, 179);
            this.btn_Kelvin.Name = "btn_Kelvin";
            this.btn_Kelvin.Size = new System.Drawing.Size(80, 30);
            this.btn_Kelvin.TabIndex = 8;
            this.btn_Kelvin.Text = "Convert";
            this.btn_Kelvin.UseVisualStyleBackColor = true;
            this.btn_Kelvin.Click += new System.EventHandler(this.btn_Kelvin_Click);
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 265);
            this.Controls.Add(this.btn_Kelvin);
            this.Controls.Add(this.btn_Celcius);
            this.Controls.Add(this.btn_Fahrenheit);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TemperatureConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Button btn_Fahrenheit;
        private System.Windows.Forms.Button btn_Celcius;
        private System.Windows.Forms.Button btn_Kelvin;
    }
}

