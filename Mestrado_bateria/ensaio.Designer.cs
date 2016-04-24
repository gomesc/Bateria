namespace Moura
{
    partial class f_ensaio
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
            this.cB_ensaio = new System.Windows.Forms.ComboBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_c10 = new System.Windows.Forms.Button();
            this.bt_c20 = new System.Windows.Forms.Button();
            this.bt_c100 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_tstart = new System.Windows.Forms.TextBox();
            this.tB_tstop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_trun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_ib = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_kvb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_tbref = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_ten_cont = new System.Windows.Forms.Button();
            this.bt_cor_cont = new System.Windows.Forms.Button();
            this.bt_pulse = new System.Windows.Forms.Button();
            this.progress_ensaio = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ensaio:";
            // 
            // cB_ensaio
            // 
            this.cB_ensaio.FormattingEnabled = true;
            this.cB_ensaio.Location = new System.Drawing.Point(61, 10);
            this.cB_ensaio.Name = "cB_ensaio";
            this.cB_ensaio.Size = new System.Drawing.Size(216, 21);
            this.cB_ensaio.TabIndex = 1;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(295, 10);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "Iniciar";
            this.bt_start.UseVisualStyleBackColor = true;
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(385, 10);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(75, 23);
            this.bt_stop.TabIndex = 3;
            this.bt_stop.Text = "Parar";
            this.bt_stop.UseVisualStyleBackColor = true;
            // 
            // bt_c10
            // 
            this.bt_c10.Location = new System.Drawing.Point(6, 19);
            this.bt_c10.Name = "bt_c10";
            this.bt_c10.Size = new System.Drawing.Size(75, 23);
            this.bt_c10.TabIndex = 4;
            this.bt_c10.Text = "C10";
            this.bt_c10.UseVisualStyleBackColor = true;
            this.bt_c10.Click += new System.EventHandler(this.bt_c10_Click);
            // 
            // bt_c20
            // 
            this.bt_c20.Location = new System.Drawing.Point(6, 48);
            this.bt_c20.Name = "bt_c20";
            this.bt_c20.Size = new System.Drawing.Size(75, 23);
            this.bt_c20.TabIndex = 5;
            this.bt_c20.Text = "C20";
            this.bt_c20.UseVisualStyleBackColor = true;
            this.bt_c20.Click += new System.EventHandler(this.bt_c20_Click);
            // 
            // bt_c100
            // 
            this.bt_c100.Location = new System.Drawing.Point(6, 77);
            this.bt_c100.Name = "bt_c100";
            this.bt_c100.Size = new System.Drawing.Size(75, 23);
            this.bt_c100.TabIndex = 6;
            this.bt_c100.Text = "C100";
            this.bt_c100.UseVisualStyleBackColor = true;
            this.bt_c100.Click += new System.EventHandler(this.bt_c100_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_c10);
            this.groupBox1.Controls.Add(this.bt_c100);
            this.groupBox1.Controls.Add(this.bt_c20);
            this.groupBox1.Location = new System.Drawing.Point(16, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 106);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capacidade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tB_tbref);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tB_kvb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tB_ib);
            this.groupBox2.Controls.Add(this.tB_trun);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tB_tstop);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tB_tstart);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(112, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TStart";
            // 
            // tB_tstart
            // 
            this.tB_tstart.Location = new System.Drawing.Point(49, 16);
            this.tB_tstart.Name = "tB_tstart";
            this.tB_tstart.Size = new System.Drawing.Size(100, 20);
            this.tB_tstart.TabIndex = 1;
            // 
            // tB_tstop
            // 
            this.tB_tstop.Location = new System.Drawing.Point(49, 45);
            this.tB_tstop.Name = "tB_tstop";
            this.tB_tstop.Size = new System.Drawing.Size(100, 20);
            this.tB_tstop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TStop";
            // 
            // tB_trun
            // 
            this.tB_trun.Location = new System.Drawing.Point(49, 74);
            this.tB_trun.Name = "tB_trun";
            this.tB_trun.Size = new System.Drawing.Size(100, 20);
            this.tB_trun.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TRun";
            // 
            // tB_ib
            // 
            this.tB_ib.Location = new System.Drawing.Point(206, 16);
            this.tB_ib.Name = "tB_ib";
            this.tB_ib.Size = new System.Drawing.Size(100, 20);
            this.tB_ib.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ib";
            // 
            // tB_kvb
            // 
            this.tB_kvb.Location = new System.Drawing.Point(206, 41);
            this.tB_kvb.Name = "tB_kvb";
            this.tB_kvb.Size = new System.Drawing.Size(100, 20);
            this.tB_kvb.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "KVb";
            // 
            // tB_tbref
            // 
            this.tB_tbref.Location = new System.Drawing.Point(206, 70);
            this.tB_tbref.Name = "tB_tbref";
            this.tB_tbref.Size = new System.Drawing.Size(100, 20);
            this.tB_tbref.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "TbRef";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_pulse);
            this.groupBox3.Controls.Add(this.bt_cor_cont);
            this.groupBox3.Controls.Add(this.bt_ten_cont);
            this.groupBox3.Location = new System.Drawing.Point(16, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 149);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo";
            // 
            // bt_ten_cont
            // 
            this.bt_ten_cont.Location = new System.Drawing.Point(6, 19);
            this.bt_ten_cont.Name = "bt_ten_cont";
            this.bt_ten_cont.Size = new System.Drawing.Size(75, 37);
            this.bt_ten_cont.TabIndex = 7;
            this.bt_ten_cont.Text = "Tensão Cont.";
            this.bt_ten_cont.UseVisualStyleBackColor = true;
            // 
            // bt_cor_cont
            // 
            this.bt_cor_cont.Location = new System.Drawing.Point(6, 62);
            this.bt_cor_cont.Name = "bt_cor_cont";
            this.bt_cor_cont.Size = new System.Drawing.Size(75, 37);
            this.bt_cor_cont.TabIndex = 8;
            this.bt_cor_cont.Text = "Corrente Cont.";
            this.bt_cor_cont.UseVisualStyleBackColor = true;
            // 
            // bt_pulse
            // 
            this.bt_pulse.Location = new System.Drawing.Point(6, 105);
            this.bt_pulse.Name = "bt_pulse";
            this.bt_pulse.Size = new System.Drawing.Size(75, 37);
            this.bt_pulse.TabIndex = 9;
            this.bt_pulse.Text = "Pulsada";
            this.bt_pulse.UseVisualStyleBackColor = true;
            // 
            // progress_ensaio
            // 
            this.progress_ensaio.Location = new System.Drawing.Point(112, 222);
            this.progress_ensaio.Name = "progress_ensaio";
            this.progress_ensaio.Size = new System.Drawing.Size(348, 23);
            this.progress_ensaio.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress_ensaio.TabIndex = 10;
            this.progress_ensaio.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Progresso do Ensaio";
            // 
            // f_ensaio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 321);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progress_ensaio);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.cB_ensaio);
            this.Controls.Add(this.label1);
            this.Name = "f_ensaio";
            this.Text = "Ensaio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_ensaio;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_c10;
        private System.Windows.Forms.Button bt_c20;
        private System.Windows.Forms.Button bt_c100;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tB_ib;
        private System.Windows.Forms.TextBox tB_trun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_tstop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_tstart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_kvb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_tbref;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_cor_cont;
        private System.Windows.Forms.Button bt_ten_cont;
        private System.Windows.Forms.Button bt_pulse;
        private System.Windows.Forms.ProgressBar progress_ensaio;
        private System.Windows.Forms.Label label8;
    }
}