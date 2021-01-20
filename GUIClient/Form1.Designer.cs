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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.blad = new System.Windows.Forms.Label();
            this.mapa = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.setNotification = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "TWOJA POGODYNKA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(852, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "SZUKAJ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(378, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj miasto:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(382, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 26);
            this.textBox1.TabIndex = 3;
            // 
            // koordynaty
            // 
            this.koordynaty.AutoSize = true;
            this.koordynaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koordynaty.Location = new System.Drawing.Point(12, 173);
            this.koordynaty.Name = "koordynaty";
            this.koordynaty.Size = new System.Drawing.Size(188, 20);
            this.koordynaty.TabIndex = 4;
            this.koordynaty.Text = "Koordynaty miejscowości:";
            // 
            // temperatura
            // 
            this.temperatura.AutoSize = true;
            this.temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.temperatura.Location = new System.Drawing.Point(12, 216);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(104, 20);
            this.temperatura.TabIndex = 5;
            this.temperatura.Text = "Temperatura:";
            // 
            // cisnienie
            // 
            this.cisnienie.AutoSize = true;
            this.cisnienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cisnienie.Location = new System.Drawing.Point(12, 259);
            this.cisnienie.Name = "cisnienie";
            this.cisnienie.Size = new System.Drawing.Size(77, 20);
            this.cisnienie.TabIndex = 6;
            this.cisnienie.Text = "Ciśnienie:";
            // 
            // wilgotnosc
            // 
            this.wilgotnosc.AutoSize = true;
            this.wilgotnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.wilgotnosc.Location = new System.Drawing.Point(12, 300);
            this.wilgotnosc.Name = "wilgotnosc";
            this.wilgotnosc.Size = new System.Drawing.Size(91, 20);
            this.wilgotnosc.TabIndex = 7;
            this.wilgotnosc.Text = "Wilgotność:";
            // 
            // wiatr
            // 
            this.wiatr.AutoSize = true;
            this.wiatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.wiatr.Location = new System.Drawing.Point(12, 341);
            this.wiatr.Name = "wiatr";
            this.wiatr.Size = new System.Drawing.Size(125, 20);
            this.wiatr.TabIndex = 8;
            this.wiatr.Text = "Prędkość wiatru:";
            // 
            // kraj
            // 
            this.kraj.AutoSize = true;
            this.kraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kraj.Location = new System.Drawing.Point(12, 379);
            this.kraj.Name = "kraj";
            this.kraj.Size = new System.Drawing.Size(40, 20);
            this.kraj.TabIndex = 9;
            this.kraj.Text = "Kraj:";
            // 
            // dane
            // 
            this.dane.AutoSize = true;
            this.dane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dane.Location = new System.Drawing.Point(244, 503);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(371, 20);
            this.dane.TabIndex = 10;
            this.dane.Text = "Dane pogodowe pochodzą z: openweathermap.org";
            this.dane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dane.Click += new System.EventHandler(this.dane_Click);
            // 
            // blad
            // 
            this.blad.AutoSize = true;
            this.blad.BackColor = System.Drawing.Color.Red;
            this.blad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blad.Location = new System.Drawing.Point(14, 128);
            this.blad.Name = "blad";
            this.blad.Size = new System.Drawing.Size(274, 25);
            this.blad.TabIndex = 11;
            this.blad.Text = "Podano niepoprawne miejsce!";
            this.blad.Visible = false;
            // 
            // mapa
            // 
            this.mapa.Location = new System.Drawing.Point(431, 114);
            this.mapa.Margin = new System.Windows.Forms.Padding(4);
            this.mapa.MinimumSize = new System.Drawing.Size(27, 25);
            this.mapa.Name = "mapa";
            this.mapa.Size = new System.Drawing.Size(564, 385);
            this.mapa.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 107);
            this.panel1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "15",
            "30",
            "60",
            "90",
            "120"});
            this.comboBox1.Location = new System.Drawing.Point(16, 444);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // setNotification
            // 
            this.setNotification.Location = new System.Drawing.Point(135, 444);
            this.setNotification.Name = "setNotification";
            this.setNotification.Size = new System.Drawing.Size(182, 28);
            this.setNotification.TabIndex = 15;
            this.setNotification.Text = "Ustaw powiadomienie";
            this.setNotification.UseVisualStyleBackColor = true;
            this.setNotification.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "sek";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Powiadomienie wyłaczone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1019, 532);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setNotification);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mapa);
            this.Controls.Add(this.blad);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.kraj);
            this.Controls.Add(this.wiatr);
            this.Controls.Add(this.wilgotnosc);
            this.Controls.Add(this.cisnienie);
            this.Controls.Add(this.temperatura);
            this.Controls.Add(this.koordynaty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Aplikacja Pogodowa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Resize += new System.EventHandler(this.Form1_Resize);

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
        private System.Windows.Forms.Label blad;
        private System.Windows.Forms.WebBrowser mapa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button setNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

