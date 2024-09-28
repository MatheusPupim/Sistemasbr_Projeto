﻿
namespace CadastroDeProdutosView.Features.Produto.Views
{
    partial class ConfigurarCaminhoDoBancoDeDadosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurarCaminhoDoBancoDeDadosView));
            this.caminhoDoBancoDeDadosLabelControl = new System.Windows.Forms.Label();
            this.bancoDeDadosTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.aplicarButton = new DevExpress.XtraEditors.SimpleButton();
            this.exploradorBandoDeDadosButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // caminhoDoBancoDeDadosLabelControl
            // 
            this.caminhoDoBancoDeDadosLabelControl.AutoSize = true;
            this.caminhoDoBancoDeDadosLabelControl.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caminhoDoBancoDeDadosLabelControl.Location = new System.Drawing.Point(12, 8);
            this.caminhoDoBancoDeDadosLabelControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caminhoDoBancoDeDadosLabelControl.Name = "caminhoDoBancoDeDadosLabelControl";
            this.caminhoDoBancoDeDadosLabelControl.Size = new System.Drawing.Size(341, 30);
            this.caminhoDoBancoDeDadosLabelControl.TabIndex = 0;
            this.caminhoDoBancoDeDadosLabelControl.Text = "Caminho do Banco de dados:";
            // 
            // bancoDeDadosTextEdit
            // 
            this.bancoDeDadosTextEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bancoDeDadosTextEdit.Location = new System.Drawing.Point(18, 45);
            this.bancoDeDadosTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bancoDeDadosTextEdit.Name = "bancoDeDadosTextEdit";
            this.bancoDeDadosTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.bancoDeDadosTextEdit.Size = new System.Drawing.Size(444, 28);
            this.bancoDeDadosTextEdit.TabIndex = 1;
            this.bancoDeDadosTextEdit.EditValueChanged += new System.EventHandler(this.bancoDeDadosTextEdit_EditValueChanged);
            // 
            // aplicarButton
            // 
            this.aplicarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aplicarButton.Location = new System.Drawing.Point(17, 92);
            this.aplicarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aplicarButton.Name = "aplicarButton";
            this.aplicarButton.Size = new System.Drawing.Size(65, 42);
            this.aplicarButton.TabIndex = 2;
            this.aplicarButton.Text = "Aplicar";
            this.aplicarButton.Click += new System.EventHandler(this.aplicarButton_Click);
            // 
            // exploradorBandoDeDadosButton
            // 
            this.exploradorBandoDeDadosButton.AutoSize = true;
            this.exploradorBandoDeDadosButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.exploradorBandoDeDadosButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.exploradorBandoDeDadosButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.exploradorBandoDeDadosButton.Location = new System.Drawing.Point(89, 81);
            this.exploradorBandoDeDadosButton.Name = "exploradorBandoDeDadosButton";
            this.exploradorBandoDeDadosButton.Size = new System.Drawing.Size(38, 38);
            this.exploradorBandoDeDadosButton.TabIndex = 3;
            this.exploradorBandoDeDadosButton.Click += new System.EventHandler(this.exploradorBandoDeDadosButton_Click);
            // 
            // ConfigurarCaminhoDoBancoDeDadosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 134);
            this.Controls.Add(this.exploradorBandoDeDadosButton);
            this.Controls.Add(this.aplicarButton);
            this.Controls.Add(this.bancoDeDadosTextEdit);
            this.Controls.Add(this.caminhoDoBancoDeDadosLabelControl);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfigurarCaminhoDoBancoDeDadosView";
            this.Text = "ConfigurarCaminhoDoBancoDeDadosView";
            this.Load += new System.EventHandler(this.ConfigurarCaminhoDoBancoDeDadosView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caminhoDoBancoDeDadosLabelControl;
        private DevExpress.XtraEditors.TextEdit bancoDeDadosTextEdit;
        private DevExpress.XtraEditors.SimpleButton aplicarButton;
        private DevExpress.XtraEditors.SimpleButton exploradorBandoDeDadosButton;
    }
}