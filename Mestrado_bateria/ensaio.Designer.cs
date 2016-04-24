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
            this.bt_c10.Location = new System.Drawing.Point(12, 48);
            this.bt_c10.Name = "bt_c10";
            this.bt_c10.Size = new System.Drawing.Size(75, 23);
            this.bt_c10.TabIndex = 4;
            this.bt_c10.Text = "C10";
            this.bt_c10.UseVisualStyleBackColor = true;
            // 
            // bt_c20
            // 
            this.bt_c20.Location = new System.Drawing.Point(12, 77);
            this.bt_c20.Name = "bt_c20";
            this.bt_c20.Size = new System.Drawing.Size(75, 23);
            this.bt_c20.TabIndex = 5;
            this.bt_c20.Text = "C20";
            this.bt_c20.UseVisualStyleBackColor = true;
            // 
            // bt_c100
            // 
            this.bt_c100.Location = new System.Drawing.Point(12, 106);
            this.bt_c100.Name = "bt_c100";
            this.bt_c100.Size = new System.Drawing.Size(75, 23);
            this.bt_c100.TabIndex = 6;
            this.bt_c100.Text = "C100";
            this.bt_c100.UseVisualStyleBackColor = true;
            // 
            // f_ensaio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 400);
            this.Controls.Add(this.bt_c100);
            this.Controls.Add(this.bt_c20);
            this.Controls.Add(this.bt_c10);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.cB_ensaio);
            this.Controls.Add(this.label1);
            this.Name = "f_ensaio";
            this.Text = "Ensaio";
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
    }
}