
namespace RagnarokPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // picMaximize
            // 
            this.picMaximize.BackColor = System.Drawing.Color.Transparent;
            this.picMaximize.BackgroundImage = global::RagnarokPlayer.Properties.Resources.sys_close_a;
            this.picMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMaximize.Location = new System.Drawing.Point(266, 3);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(11, 11);
            this.picMaximize.TabIndex = 3;
            this.picMaximize.TabStop = false;
            this.picMaximize.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.BackgroundImage = global::RagnarokPlayer.Properties.Resources.sys_mini_a;
            this.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMinimize.Location = new System.Drawing.Point(254, 3);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(11, 11);
            this.picMinimize.TabIndex = 4;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picAbout
            // 
            this.picAbout.BackColor = System.Drawing.Color.Transparent;
            this.picAbout.BackgroundImage = global::RagnarokPlayer.Properties.Resources.sys_base_off;
            this.picAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picAbout.Location = new System.Drawing.Point(3, 3);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(11, 11);
            this.picAbout.TabIndex = 5;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // webView21
            // 
            this.webView21.BackColor = System.Drawing.Color.White;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(1, 17);
            this.webView21.Margin = new System.Windows.Forms.Padding(0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(278, 100);
            this.webView21.Source = new System.Uri("http://kmc.rf.gd/Projetos/HTML_Player/", System.UriKind.Absolute);
            this.webView21.TabIndex = 2;
            this.webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RagnarokPlayer.Properties.Resources.Painel_copy_1;
            this.ClientSize = new System.Drawing.Size(280, 146);
            this.Controls.Add(this.picAbout);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picMaximize);
            this.Controls.Add(this.webView21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(280, 146);
            this.MinimumSize = new System.Drawing.Size(280, 146);
            this.Name = "Form1";
            this.Text = "Ragnarok Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picMaximize;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picAbout;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

