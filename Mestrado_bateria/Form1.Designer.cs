namespace Moura
{
    partial class f_moura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_moura));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_title = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.gb_con_ser = new System.Windows.Forms.GroupBox();
            this.bt_desconnect = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.bt_verify = new System.Windows.Forms.Button();
            this.cB_port = new System.Windows.Forms.ComboBox();
            this.label_port = new System.Windows.Forms.Label();
            this.serialport = new System.IO.Ports.SerialPort(this.components);
            this.gB_battery = new System.Windows.Forms.GroupBox();
            this.tB_temp_bat = new System.Windows.Forms.TextBox();
            this.bat_tem = new System.Windows.Forms.Label();
            this.tB_current = new System.Windows.Forms.TextBox();
            this.tB_ten = new System.Windows.Forms.TextBox();
            this.current_label = new System.Windows.Forms.Label();
            this.ten_label = new System.Windows.Forms.Label();
            this.bt_cadastro = new System.Windows.Forms.Button();
            this.bt_view = new System.Windows.Forms.Button();
            this.bt_ensaio = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.gb_con_ser.SuspendLayout();
            this.gB_battery.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_title,
            this.status_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(595, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_title
            // 
            this.status_title.Name = "status_title";
            this.status_title.Size = new System.Drawing.Size(72, 17);
            this.status_title.Text = "Porta Serial: ";
            // 
            // status_label
            // 
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(82, 17);
            this.status_label.Text = "Desconhecido";
            // 
            // gb_con_ser
            // 
            this.gb_con_ser.Controls.Add(this.bt_desconnect);
            this.gb_con_ser.Controls.Add(this.bt_connect);
            this.gb_con_ser.Controls.Add(this.bt_verify);
            this.gb_con_ser.Controls.Add(this.cB_port);
            this.gb_con_ser.Controls.Add(this.label_port);
            this.gb_con_ser.Location = new System.Drawing.Point(12, 12);
            this.gb_con_ser.Name = "gb_con_ser";
            this.gb_con_ser.Size = new System.Drawing.Size(308, 115);
            this.gb_con_ser.TabIndex = 1;
            this.gb_con_ser.TabStop = false;
            this.gb_con_ser.Text = "Conexão Serial";
            // 
            // bt_desconnect
            // 
            this.bt_desconnect.Location = new System.Drawing.Point(170, 76);
            this.bt_desconnect.Name = "bt_desconnect";
            this.bt_desconnect.Size = new System.Drawing.Size(132, 23);
            this.bt_desconnect.TabIndex = 4;
            this.bt_desconnect.Text = "Desconectar";
            this.bt_desconnect.UseVisualStyleBackColor = true;
            this.bt_desconnect.Click += new System.EventHandler(this.bt_desconnect_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(10, 76);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(132, 23);
            this.bt_connect.TabIndex = 3;
            this.bt_connect.Text = "Conectar";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // bt_verify
            // 
            this.bt_verify.Location = new System.Drawing.Point(90, 47);
            this.bt_verify.Name = "bt_verify";
            this.bt_verify.Size = new System.Drawing.Size(167, 23);
            this.bt_verify.TabIndex = 2;
            this.bt_verify.Text = "Verificar Portas";
            this.bt_verify.UseVisualStyleBackColor = true;
            this.bt_verify.Click += new System.EventHandler(this.bt_verify_Click);
            // 
            // cB_port
            // 
            this.cB_port.FormattingEnabled = true;
            this.cB_port.Location = new System.Drawing.Point(113, 20);
            this.cB_port.Name = "cB_port";
            this.cB_port.Size = new System.Drawing.Size(121, 21);
            this.cB_port.TabIndex = 1;
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(7, 20);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(99, 13);
            this.label_port.TabIndex = 0;
            this.label_port.Text = "Portas Disponíveis:";
            // 
            // serialport
            // 
            this.serialport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialport_DataReceived);
            // 
            // gB_battery
            // 
            this.gB_battery.Controls.Add(this.tB_temp_bat);
            this.gB_battery.Controls.Add(this.bat_tem);
            this.gB_battery.Controls.Add(this.tB_current);
            this.gB_battery.Controls.Add(this.tB_ten);
            this.gB_battery.Controls.Add(this.current_label);
            this.gB_battery.Controls.Add(this.ten_label);
            this.gB_battery.Location = new System.Drawing.Point(340, 12);
            this.gB_battery.Name = "gB_battery";
            this.gB_battery.Size = new System.Drawing.Size(242, 115);
            this.gB_battery.TabIndex = 2;
            this.gB_battery.TabStop = false;
            this.gB_battery.Text = "Dados da Bateria";
            // 
            // tB_temp_bat
            // 
            this.tB_temp_bat.Location = new System.Drawing.Point(118, 78);
            this.tB_temp_bat.Name = "tB_temp_bat";
            this.tB_temp_bat.Size = new System.Drawing.Size(100, 20);
            this.tB_temp_bat.TabIndex = 8;
            // 
            // bat_tem
            // 
            this.bat_tem.AutoSize = true;
            this.bat_tem.Location = new System.Drawing.Point(6, 81);
            this.bat_tem.Name = "bat_tem";
            this.bat_tem.Size = new System.Drawing.Size(106, 13);
            this.bat_tem.TabIndex = 7;
            this.bat_tem.Text = "Temperatura Bateria:";
            // 
            // tB_current
            // 
            this.tB_current.Location = new System.Drawing.Point(118, 51);
            this.tB_current.Name = "tB_current";
            this.tB_current.Size = new System.Drawing.Size(100, 20);
            this.tB_current.TabIndex = 6;
            // 
            // tB_ten
            // 
            this.tB_ten.Location = new System.Drawing.Point(118, 25);
            this.tB_ten.Name = "tB_ten";
            this.tB_ten.Size = new System.Drawing.Size(100, 20);
            this.tB_ten.TabIndex = 5;
            // 
            // current_label
            // 
            this.current_label.AutoSize = true;
            this.current_label.Location = new System.Drawing.Point(6, 57);
            this.current_label.Name = "current_label";
            this.current_label.Size = new System.Drawing.Size(50, 13);
            this.current_label.TabIndex = 4;
            this.current_label.Text = "Corrente:";
            // 
            // ten_label
            // 
            this.ten_label.AutoSize = true;
            this.ten_label.Location = new System.Drawing.Point(6, 28);
            this.ten_label.Name = "ten_label";
            this.ten_label.Size = new System.Drawing.Size(46, 13);
            this.ten_label.TabIndex = 3;
            this.ten_label.Text = "Tensão:";
            // 
            // bt_cadastro
            // 
            this.bt_cadastro.Location = new System.Drawing.Point(41, 157);
            this.bt_cadastro.Name = "bt_cadastro";
            this.bt_cadastro.Size = new System.Drawing.Size(113, 91);
            this.bt_cadastro.TabIndex = 3;
            this.bt_cadastro.Text = "Cadastro";
            this.bt_cadastro.UseVisualStyleBackColor = true;
            this.bt_cadastro.Click += new System.EventHandler(this.bt_cadastro_Click);
            // 
            // bt_view
            // 
            this.bt_view.Location = new System.Drawing.Point(228, 157);
            this.bt_view.Name = "bt_view";
            this.bt_view.Size = new System.Drawing.Size(113, 91);
            this.bt_view.TabIndex = 4;
            this.bt_view.Text = "Dados Salvos";
            this.bt_view.UseVisualStyleBackColor = true;
            // 
            // bt_ensaio
            // 
            this.bt_ensaio.Location = new System.Drawing.Point(423, 157);
            this.bt_ensaio.Name = "bt_ensaio";
            this.bt_ensaio.Size = new System.Drawing.Size(113, 91);
            this.bt_ensaio.TabIndex = 5;
            this.bt_ensaio.Text = "Ensaio";
            this.bt_ensaio.UseVisualStyleBackColor = true;
            // 
            // f_moura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 344);
            this.Controls.Add(this.bt_ensaio);
            this.Controls.Add(this.bt_view);
            this.Controls.Add(this.bt_cadastro);
            this.Controls.Add(this.gB_battery);
            this.Controls.Add(this.gb_con_ser);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_moura";
            this.Text = "Carga/Descarga Bateria";
            this.Load += new System.EventHandler(this.f_moura_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gb_con_ser.ResumeLayout(false);
            this.gb_con_ser.PerformLayout();
            this.gB_battery.ResumeLayout(false);
            this.gB_battery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_title;
        private System.Windows.Forms.ToolStripStatusLabel status_label;
        private System.Windows.Forms.GroupBox gb_con_ser;
        private System.Windows.Forms.Button bt_desconnect;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Button bt_verify;
        private System.Windows.Forms.ComboBox cB_port;
        private System.Windows.Forms.Label label_port;
        private System.IO.Ports.SerialPort serialport;
        private System.Windows.Forms.GroupBox gB_battery;
        private System.Windows.Forms.Label ten_label;
        private System.Windows.Forms.TextBox tB_temp_bat;
        private System.Windows.Forms.Label bat_tem;
        private System.Windows.Forms.TextBox tB_current;
        private System.Windows.Forms.TextBox tB_ten;
        private System.Windows.Forms.Label current_label;
        private System.Windows.Forms.Button bt_cadastro;
        private System.Windows.Forms.Button bt_view;
        private System.Windows.Forms.Button bt_ensaio;
    }
}

