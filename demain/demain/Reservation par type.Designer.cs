
namespace demain
{
    partial class Reservation_par_type
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dg_res = new System.Windows.Forms.DataGridView();
            this.lb_nbr = new System.Windows.Forms.Label();
            this.codeR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_res)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type de séjour ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(292, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dg_res
            // 
            this.dg_res.BackgroundColor = System.Drawing.Color.Crimson;
            this.dg_res.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_res.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeR,
            this.DS});
            this.dg_res.Location = new System.Drawing.Point(256, 94);
            this.dg_res.Name = "dg_res";
            this.dg_res.Size = new System.Drawing.Size(244, 202);
            this.dg_res.TabIndex = 2;
            // 
            // lb_nbr
            // 
            this.lb_nbr.AutoSize = true;
            this.lb_nbr.Location = new System.Drawing.Point(340, 365);
            this.lb_nbr.Name = "lb_nbr";
            this.lb_nbr.Size = new System.Drawing.Size(0, 13);
            this.lb_nbr.TabIndex = 3;
            // 
            // codeR
            // 
            this.codeR.HeaderText = "Code réservation ";
            this.codeR.Name = "codeR";
            // 
            // DS
            // 
            this.DS.HeaderText = "durée de séjour";
            this.DS.Name = "DS";
            // 
            // Reservation_par_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_nbr);
            this.Controls.Add(this.dg_res);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Reservation_par_type";
            this.Text = "Reservation_par_type";
            ((System.ComponentModel.ISupportInitialize)(this.dg_res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dg_res;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS;
        private System.Windows.Forms.Label lb_nbr;
    }
}