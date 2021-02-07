
namespace demain
{
    partial class Gestion_des_réservations
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
            this.btn_aj = new System.Windows.Forms.Button();
            this.btn_aff = new System.Windows.Forms.Button();
            this.txt_pEN = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimer = new System.Windows.Forms.DateTimePicker();
            this.cb_c = new System.Windows.Forms.ComboBox();
            this.lb_tel = new System.Windows.Forms.Label();
            this.lb_Nom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aj
            // 
            this.btn_aj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aj.Location = new System.Drawing.Point(580, 285);
            this.btn_aj.Name = "btn_aj";
            this.btn_aj.Size = new System.Drawing.Size(199, 77);
            this.btn_aj.TabIndex = 29;
            this.btn_aj.Text = "Ajouter";
            this.btn_aj.UseVisualStyleBackColor = true;
            this.btn_aj.Click += new System.EventHandler(this.btn_aj_Click);
            // 
            // btn_aff
            // 
            this.btn_aff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aff.Location = new System.Drawing.Point(580, 183);
            this.btn_aff.Name = "btn_aff";
            this.btn_aff.Size = new System.Drawing.Size(199, 77);
            this.btn_aff.TabIndex = 28;
            this.btn_aff.Text = "Afficher";
            this.btn_aff.UseVisualStyleBackColor = true;
            this.btn_aff.Click += new System.EventHandler(this.btn_aff_Click);
            // 
            // txt_pEN
            // 
            this.txt_pEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pEN.Location = new System.Drawing.Point(263, 320);
            this.txt_pEN.Name = "txt_pEN";
            this.txt_pEN.Size = new System.Drawing.Size(160, 29);
            this.txt_pEN.TabIndex = 21;
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(263, 81);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(160, 29);
            this.txt_code.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pension Compléte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Code";
            // 
            // dateTimer
            // 
            this.dateTimer.Location = new System.Drawing.Point(231, 267);
            this.dateTimer.Name = "dateTimer";
            this.dateTimer.Size = new System.Drawing.Size(200, 20);
            this.dateTimer.TabIndex = 32;
            // 
            // cb_c
            // 
            this.cb_c.FormattingEnabled = true;
            this.cb_c.Location = new System.Drawing.Point(263, 150);
            this.cb_c.Name = "cb_c";
            this.cb_c.Size = new System.Drawing.Size(160, 21);
            this.cb_c.TabIndex = 33;
            this.cb_c.SelectedIndexChanged += new System.EventHandler(this.cb_c_SelectedIndexChanged);
            // 
            // lb_tel
            // 
            this.lb_tel.AutoSize = true;
            this.lb_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tel.Location = new System.Drawing.Point(275, 209);
            this.lb_tel.Name = "lb_tel";
            this.lb_tel.Size = new System.Drawing.Size(0, 24);
            this.lb_tel.TabIndex = 34;
            // 
            // lb_Nom
            // 
            this.lb_Nom.AutoSize = true;
            this.lb_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nom.Location = new System.Drawing.Point(149, 209);
            this.lb_Nom.Name = "lb_Nom";
            this.lb_Nom.Size = new System.Drawing.Size(0, 24);
            this.lb_Nom.TabIndex = 35;
            // 
            // Gestion_des_réservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 509);
            this.Controls.Add(this.lb_Nom);
            this.Controls.Add(this.lb_tel);
            this.Controls.Add(this.cb_c);
            this.Controls.Add(this.dateTimer);
            this.Controls.Add(this.btn_aj);
            this.Controls.Add(this.btn_aff);
            this.Controls.Add(this.txt_pEN);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gestion_des_réservations";
            this.Text = "Gestion_des_réservations";
            this.Load += new System.EventHandler(this.Gestion_des_réservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_aj;
        private System.Windows.Forms.Button btn_aff;
        private System.Windows.Forms.TextBox txt_pEN;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimer;
        private System.Windows.Forms.ComboBox cb_c;
        private System.Windows.Forms.Label lb_tel;
        private System.Windows.Forms.Label lb_Nom;
    }
}