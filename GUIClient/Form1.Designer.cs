namespace GUIClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.koordynaty = new System.Windows.Forms.Label();
            this.temperatura = new System.Windows.Forms.Label();
            this.cisnienie = new System.Windows.Forms.Label();
            this.wilgotnosc = new System.Windows.Forms.Label();
            this.wiatr = new System.Windows.Forms.Label();
            this.kraj = new System.Windows.Forms.Label();
            this.dane = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPRAWDŹ POGODĘ NA ŚWIECIE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SPRAWDŹ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj miasto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 22);
            this.textBox1.TabIndex = 3;
            // 
            // koordynaty
            // 
            this.koordynaty.AutoSize = true;
            this.koordynaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koordynaty.Location = new System.Drawing.Point(18, 202);
            this.koordynaty.Name = "koordynaty";
            this.koordynaty.Size = new System.Drawing.Size(203, 20);
            this.koordynaty.TabIndex = 4;
            this.koordynaty.Text = "Koordynaty miejscowości:";
            // 
            // temperatura
            // 
            this.temperatura.AutoSize = true;
            this.temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperatura.Location = new System.Drawing.Point(14, 246);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(109, 20);
            this.temperatura.TabIndex = 5;
            this.temperatura.Text = "Temperatura:";
            // 
            // cisnienie
            // 
            this.cisnienie.AutoSize = true;
            this.cisnienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cisnienie.Location = new System.Drawing.Point(18, 293);
            this.cisnienie.Name = "cisnienie";
            this.cisnienie.Size = new System.Drawing.Size(83, 20);
            this.cisnienie.TabIndex = 6;
            this.cisnienie.Text = "Ciśnienie:";
            // 
            // wilgotnosc
            // 
            this.wilgotnosc.AutoSize = true;
            this.wilgotnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wilgotnosc.Location = new System.Drawing.Point(14, 345);
            this.wilgotnosc.Name = "wilgotnosc";
            this.wilgotnosc.Size = new System.Drawing.Size(97, 20);
            this.wilgotnosc.TabIndex = 7;
            this.wilgotnosc.Text = "Wilgotność:";
            // 
            // wiatr
            // 
            this.wiatr.AutoSize = true;
            this.wiatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wiatr.Location = new System.Drawing.Point(14, 394);
            this.wiatr.Name = "wiatr";
            this.wiatr.Size = new System.Drawing.Size(134, 20);
            this.wiatr.TabIndex = 8;
            this.wiatr.Text = "Prędkość wiatru:";
            // 
            // kraj
            // 
            this.kraj.AutoSize = true;
            this.kraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kraj.Location = new System.Drawing.Point(18, 439);
            this.kraj.Name = "kraj";
            this.kraj.Size = new System.Drawing.Size(44, 20);
            this.kraj.TabIndex = 9;
            this.kraj.Text = "Kraj:";
            // 
            // dane
            // 
            this.dane.AutoSize = true;
            this.dane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dane.Location = new System.Drawing.Point(173, 503);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(335, 20);
            this.dane.TabIndex = 10;
            this.dane.Text = "DANE POCHODZĄ Z: openweathermap.org";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 532);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.kraj);
            this.Controls.Add(this.wiatr);
            this.Controls.Add(this.wilgotnosc);
            this.Controls.Add(this.cisnienie);
            this.Controls.Add(this.temperatura);
            this.Controls.Add(this.koordynaty);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Aplikacja Pogodowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label koordynaty;
        private System.Windows.Forms.Label temperatura;
        private System.Windows.Forms.Label cisnienie;
        private System.Windows.Forms.Label wilgotnosc;
        private System.Windows.Forms.Label wiatr;
        private System.Windows.Forms.Label kraj;
        private System.Windows.Forms.Label dane;
    }
}

