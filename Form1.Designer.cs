namespace TesteApiRefit
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.circProgress = new CircularProgressBar.CircularProgressBar();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(205, 94);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 33);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUser.Location = new System.Drawing.Point(187, 62);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(169, 26);
            this.txtUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.label1.Location = new System.Drawing.Point(155, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o login do usuário";
            // 
            // circProgress
            // 
            this.circProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circProgress.AnimationSpeed = 1000;
            this.circProgress.BackColor = System.Drawing.Color.Transparent;
            this.circProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circProgress.ForeColor = System.Drawing.Color.White;
            this.circProgress.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circProgress.InnerMargin = 2;
            this.circProgress.InnerWidth = -1;
            this.circProgress.Location = new System.Drawing.Point(142, 149);
            this.circProgress.MarqueeAnimationSpeed = 2000;
            this.circProgress.Name = "circProgress";
            this.circProgress.OuterColor = System.Drawing.Color.Black;
            this.circProgress.OuterMargin = -25;
            this.circProgress.OuterWidth = 26;
            this.circProgress.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.circProgress.ProgressWidth = 25;
            this.circProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circProgress.Size = new System.Drawing.Size(259, 254);
            this.circProgress.StartAngle = 270;
            this.circProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circProgress.SubscriptColor = System.Drawing.Color.White;
            this.circProgress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circProgress.SubscriptText = ".23";
            this.circProgress.SuperscriptColor = System.Drawing.Color.White;
            this.circProgress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circProgress.SuperscriptText = "°C";
            this.circProgress.TabIndex = 3;
            this.circProgress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circProgress.Value = 68;
            this.circProgress.Visible = false;
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(142, 149);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(259, 182);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 4;
            this.picUser.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.label2.Location = new System.Drawing.Point(139, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.label3.Location = new System.Drawing.Point(139, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Local: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.label4.Location = new System.Drawing.Point(139, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Link: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lblNome.Location = new System.Drawing.Point(208, 334);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 27);
            this.lblNome.TabIndex = 8;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lblLocal.Location = new System.Drawing.Point(200, 364);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(0, 27);
            this.lblLocal.TabIndex = 9;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lblLink.Location = new System.Drawing.Point(193, 395);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(0, 27);
            this.lblLink.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.circProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Form1";
            this.Text = "TESTE API GITHUB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar circProgress;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}

