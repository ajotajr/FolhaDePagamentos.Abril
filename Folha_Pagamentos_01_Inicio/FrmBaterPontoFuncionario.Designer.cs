namespace Folha_Pagamentos_01_Inicio
{
    partial class FrmBaterPontoFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaterPontoFuncionario));
            this.text_relogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBaterPonto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_relogio
            // 
            this.text_relogio.AutoSize = true;
            this.text_relogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_relogio.Location = new System.Drawing.Point(203, 110);
            this.text_relogio.Name = "text_relogio";
            this.text_relogio.Size = new System.Drawing.Size(347, 91);
            this.text_relogio.TabIndex = 1;
            this.text_relogio.Text = "13:52:14";
            this.text_relogio.Click += new System.EventHandler(this.text_relogio_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBaterPonto
            // 
            this.btnBaterPonto.BackColor = System.Drawing.Color.Transparent;
            this.btnBaterPonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaterPonto.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnBaterPonto.FlatAppearance.BorderSize = 0;
            this.btnBaterPonto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnBaterPonto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBaterPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaterPonto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20F);
            this.btnBaterPonto.ForeColor = System.Drawing.Color.Black;
            this.btnBaterPonto.Image = ((System.Drawing.Image)(resources.GetObject("btnBaterPonto.Image")));
            this.btnBaterPonto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaterPonto.Location = new System.Drawing.Point(269, 215);
            this.btnBaterPonto.Name = "btnBaterPonto";
            this.btnBaterPonto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBaterPonto.Size = new System.Drawing.Size(224, 97);
            this.btnBaterPonto.TabIndex = 8;
            this.btnBaterPonto.Text = "Bater Ponto";
            this.btnBaterPonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaterPonto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaterPonto.UseVisualStyleBackColor = false;
            this.btnBaterPonto.Click += new System.EventHandler(this.btnBaterPonto_Click);
            // 
            // FrmBaterPontoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 618);
            this.Controls.Add(this.btnBaterPonto);
            this.Controls.Add(this.text_relogio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmBaterPontoFuncionario";
            this.Text = "FrmBaterPontoFuncionario";
            this.Load += new System.EventHandler(this.FrmBaterPontoFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_relogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBaterPonto;
    }
}