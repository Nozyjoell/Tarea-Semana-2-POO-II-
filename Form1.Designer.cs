namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Caja_texto = new TextBox();
            Btn_CE = new Button();
            Btn_div = new Button();
            Btn_multi = new Button();
            Btn_resta = new Button();
            Btn_7 = new Button();
            Btn_8 = new Button();
            Btn_9 = new Button();
            Btn_suma = new Button();
            Btn_4 = new Button();
            Btn_5 = new Button();
            Btn_6 = new Button();
            Btn_1 = new Button();
            Btn_2 = new Button();
            Btn_3 = new Button();
            Btn_igual = new Button();
            Btn_0 = new Button();
            Btn_punto = new Button();
            Btn_eliminar = new Button();
            SuspendLayout();
            // 
            // Caja_texto
            // 
            Caja_texto.BackColor = Color.DarkSeaGreen;
            Caja_texto.BorderStyle = BorderStyle.FixedSingle;
            Caja_texto.Font = new Font("Segoe UI", 15F);
            Caja_texto.Location = new Point(12, 28);
            Caja_texto.Name = "Caja_texto";
            Caja_texto.ReadOnly = true;
            Caja_texto.Size = new Size(375, 41);
            Caja_texto.TabIndex = 0;
            Caja_texto.TextAlign = HorizontalAlignment.Right;
            // 
            // Btn_CE
            // 
            Btn_CE.BackColor = Color.IndianRed;
            Btn_CE.FlatStyle = FlatStyle.Popup;
            Btn_CE.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_CE.Location = new Point(17, 75);
            Btn_CE.Name = "Btn_CE";
            Btn_CE.Size = new Size(80, 45);
            Btn_CE.TabIndex = 1;
            Btn_CE.Text = "CE";
            Btn_CE.UseVisualStyleBackColor = false;
            Btn_CE.Click += Btn_CE_Click;
            // 
            // Btn_div
            // 
            Btn_div.BackColor = Color.IndianRed;
            Btn_div.FlatStyle = FlatStyle.Popup;
            Btn_div.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_div.Location = new Point(210, 75);
            Btn_div.Name = "Btn_div";
            Btn_div.Size = new Size(80, 45);
            Btn_div.TabIndex = 2;
            Btn_div.Text = "/";
            Btn_div.UseVisualStyleBackColor = false;
            Btn_div.Click += Btn_div_Click;
            // 
            // Btn_multi
            // 
            Btn_multi.BackColor = Color.IndianRed;
            Btn_multi.FlatStyle = FlatStyle.Popup;
            Btn_multi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_multi.Location = new Point(307, 75);
            Btn_multi.Name = "Btn_multi";
            Btn_multi.Size = new Size(80, 45);
            Btn_multi.TabIndex = 3;
            Btn_multi.Text = "*";
            Btn_multi.UseVisualStyleBackColor = false;
            Btn_multi.Click += Btn_multi_Click;
            // 
            // Btn_resta
            // 
            Btn_resta.BackColor = Color.IndianRed;
            Btn_resta.FlatStyle = FlatStyle.Popup;
            Btn_resta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_resta.Location = new Point(307, 126);
            Btn_resta.Name = "Btn_resta";
            Btn_resta.Size = new Size(80, 45);
            Btn_resta.TabIndex = 4;
            Btn_resta.Text = "-";
            Btn_resta.UseVisualStyleBackColor = false;
            Btn_resta.Click += Btn_resta_Click;
            // 
            // Btn_7
            // 
            Btn_7.BackColor = Color.LightSteelBlue;
            Btn_7.FlatStyle = FlatStyle.Popup;
            Btn_7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_7.Location = new Point(17, 126);
            Btn_7.Name = "Btn_7";
            Btn_7.Size = new Size(80, 45);
            Btn_7.TabIndex = 5;
            Btn_7.Text = "7";
            Btn_7.UseVisualStyleBackColor = false;
            Btn_7.Click += Btn_7_Click;
            // 
            // Btn_8
            // 
            Btn_8.BackColor = Color.LightSteelBlue;
            Btn_8.FlatStyle = FlatStyle.Popup;
            Btn_8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_8.Location = new Point(117, 124);
            Btn_8.Name = "Btn_8";
            Btn_8.Size = new Size(80, 45);
            Btn_8.TabIndex = 6;
            Btn_8.Text = "8";
            Btn_8.UseVisualStyleBackColor = false;
            Btn_8.Click += Btn_8_Click;
            // 
            // Btn_9
            // 
            Btn_9.BackColor = Color.LightSteelBlue;
            Btn_9.FlatStyle = FlatStyle.Popup;
            Btn_9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_9.Location = new Point(210, 124);
            Btn_9.Name = "Btn_9";
            Btn_9.Size = new Size(80, 45);
            Btn_9.TabIndex = 7;
            Btn_9.Text = "9";
            Btn_9.UseVisualStyleBackColor = false;
            Btn_9.Click += Btn_9_Click;
            // 
            // Btn_suma
            // 
            Btn_suma.BackColor = Color.IndianRed;
            Btn_suma.FlatStyle = FlatStyle.Popup;
            Btn_suma.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_suma.Location = new Point(307, 177);
            Btn_suma.Name = "Btn_suma";
            Btn_suma.Size = new Size(80, 45);
            Btn_suma.TabIndex = 8;
            Btn_suma.Text = "+";
            Btn_suma.UseVisualStyleBackColor = false;
            Btn_suma.Click += Btn_suma_Click;
            // 
            // Btn_4
            // 
            Btn_4.BackColor = Color.LightSteelBlue;
            Btn_4.FlatStyle = FlatStyle.Popup;
            Btn_4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_4.Location = new Point(17, 177);
            Btn_4.Name = "Btn_4";
            Btn_4.Size = new Size(80, 45);
            Btn_4.TabIndex = 9;
            Btn_4.Text = "4";
            Btn_4.UseVisualStyleBackColor = false;
            Btn_4.Click += Btn_4_Click;
            // 
            // Btn_5
            // 
            Btn_5.BackColor = Color.LightSteelBlue;
            Btn_5.FlatStyle = FlatStyle.Popup;
            Btn_5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_5.Location = new Point(117, 175);
            Btn_5.Name = "Btn_5";
            Btn_5.Size = new Size(80, 45);
            Btn_5.TabIndex = 10;
            Btn_5.Text = "5";
            Btn_5.UseVisualStyleBackColor = false;
            Btn_5.Click += Btn_5_Click;
            // 
            // Btn_6
            // 
            Btn_6.BackColor = Color.LightSteelBlue;
            Btn_6.FlatStyle = FlatStyle.Popup;
            Btn_6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_6.Location = new Point(210, 175);
            Btn_6.Name = "Btn_6";
            Btn_6.Size = new Size(80, 45);
            Btn_6.TabIndex = 11;
            Btn_6.Text = "6";
            Btn_6.UseVisualStyleBackColor = false;
            Btn_6.Click += Btn_6_Click;
            // 
            // Btn_1
            // 
            Btn_1.BackColor = Color.LightSteelBlue;
            Btn_1.FlatStyle = FlatStyle.Popup;
            Btn_1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_1.Location = new Point(17, 228);
            Btn_1.Name = "Btn_1";
            Btn_1.Size = new Size(80, 45);
            Btn_1.TabIndex = 12;
            Btn_1.Text = "1";
            Btn_1.UseVisualStyleBackColor = false;
            Btn_1.Click += Btn_1_Click;
            // 
            // Btn_2
            // 
            Btn_2.BackColor = Color.LightSteelBlue;
            Btn_2.FlatStyle = FlatStyle.Popup;
            Btn_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_2.Location = new Point(117, 228);
            Btn_2.Name = "Btn_2";
            Btn_2.Size = new Size(80, 45);
            Btn_2.TabIndex = 13;
            Btn_2.Text = "2";
            Btn_2.UseVisualStyleBackColor = false;
            Btn_2.Click += Btn_2_Click;
            // 
            // Btn_3
            // 
            Btn_3.BackColor = Color.LightSteelBlue;
            Btn_3.FlatStyle = FlatStyle.Popup;
            Btn_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_3.Location = new Point(210, 228);
            Btn_3.Name = "Btn_3";
            Btn_3.Size = new Size(80, 45);
            Btn_3.TabIndex = 14;
            Btn_3.Text = "3";
            Btn_3.UseVisualStyleBackColor = false;
            Btn_3.Click += Btn_3_Click;
            // 
            // Btn_igual
            // 
            Btn_igual.BackColor = Color.LightSteelBlue;
            Btn_igual.FlatStyle = FlatStyle.Popup;
            Btn_igual.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_igual.Location = new Point(307, 228);
            Btn_igual.Name = "Btn_igual";
            Btn_igual.Size = new Size(80, 96);
            Btn_igual.TabIndex = 15;
            Btn_igual.Text = "=";
            Btn_igual.UseVisualStyleBackColor = false;
            Btn_igual.Click += Btn_igual_Click;
            // 
            // Btn_0
            // 
            Btn_0.BackColor = Color.LightSteelBlue;
            Btn_0.FlatStyle = FlatStyle.Popup;
            Btn_0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_0.Location = new Point(17, 279);
            Btn_0.Name = "Btn_0";
            Btn_0.Size = new Size(180, 45);
            Btn_0.TabIndex = 16;
            Btn_0.Text = "0";
            Btn_0.UseVisualStyleBackColor = false;
            Btn_0.Click += Btn_0_Click_1;
            // 
            // Btn_punto
            // 
            Btn_punto.BackColor = Color.LightSteelBlue;
            Btn_punto.FlatStyle = FlatStyle.Popup;
            Btn_punto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_punto.Location = new Point(210, 279);
            Btn_punto.Name = "Btn_punto";
            Btn_punto.Size = new Size(80, 45);
            Btn_punto.TabIndex = 17;
            Btn_punto.Text = ".";
            Btn_punto.UseVisualStyleBackColor = false;
            Btn_punto.Click += Btn_punto_Click;
            // 
            // Btn_eliminar
            // 
            Btn_eliminar.BackColor = Color.IndianRed;
            Btn_eliminar.FlatStyle = FlatStyle.Popup;
            Btn_eliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_eliminar.Location = new Point(117, 75);
            Btn_eliminar.Name = "Btn_eliminar";
            Btn_eliminar.Size = new Size(80, 45);
            Btn_eliminar.TabIndex = 18;
            Btn_eliminar.Text = "<---";
            Btn_eliminar.UseVisualStyleBackColor = false;
            Btn_eliminar.Click += Btn_eliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 342);
            Controls.Add(Btn_eliminar);
            Controls.Add(Btn_punto);
            Controls.Add(Btn_0);
            Controls.Add(Btn_igual);
            Controls.Add(Btn_3);
            Controls.Add(Btn_2);
            Controls.Add(Btn_1);
            Controls.Add(Btn_6);
            Controls.Add(Btn_5);
            Controls.Add(Btn_4);
            Controls.Add(Btn_suma);
            Controls.Add(Btn_9);
            Controls.Add(Btn_8);
            Controls.Add(Btn_7);
            Controls.Add(Btn_resta);
            Controls.Add(Btn_multi);
            Controls.Add(Btn_div);
            Controls.Add(Btn_CE);
            Controls.Add(Caja_texto);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Caja_texto;
        private Button Btn_CE;
        private Button Btn_div;
        private Button Btn_multi;
        private Button Btn_resta;
        private Button Btn_7;
        private Button Btn_8;
        private Button Btn_9;
        private Button Btn_suma;
        private Button Btn_4;
        private Button Btn_5;
        private Button Btn_6;
        private Button Btn_1;
        private Button Btn_2;
        private Button Btn_3;
        private Button Btn_igual;
        private Button Btn_0;
        private Button Btn_punto;
        private Button Btn_eliminar;
    }
}
