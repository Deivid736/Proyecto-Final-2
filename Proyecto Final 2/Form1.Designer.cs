namespace Proyecto_Final_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtPregunta = new TextBox();
            btnEnviar = new Button();
            rtbConversacion = new RichTextBox();
            lstPreguntasFrecuentes = new ListBox();
            webViewMapa = new Microsoft.Web.WebView2.WinForms.WebView2();
            lstLugaresTramite = new ListBox();
            btnCerrarMapa = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)webViewMapa).BeginInit();
            SuspendLayout();
            // 
            // txtPregunta
            // 
            txtPregunta.BackColor = SystemColors.ActiveBorder;
            txtPregunta.Location = new Point(386, 64);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(415, 23);
            txtPregunta.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(496, 35);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // rtbConversacion
            // 
            rtbConversacion.BackColor = Color.White;
            rtbConversacion.Location = new Point(386, 93);
            rtbConversacion.Name = "rtbConversacion";
            rtbConversacion.Size = new Size(415, 191);
            rtbConversacion.TabIndex = 2;
            rtbConversacion.Text = "";
            // 
            // lstPreguntasFrecuentes
            // 
            lstPreguntasFrecuentes.BackColor = Color.Silver;
            lstPreguntasFrecuentes.FormattingEnabled = true;
            lstPreguntasFrecuentes.Location = new Point(12, 64);
            lstPreguntasFrecuentes.Name = "lstPreguntasFrecuentes";
            lstPreguntasFrecuentes.Size = new Size(339, 334);
            lstPreguntasFrecuentes.TabIndex = 3;
            lstPreguntasFrecuentes.SelectedIndexChanged += lstPreguntasFrecuentes_SelectedIndexChanged;
            // 
            // webViewMapa
            // 
            webViewMapa.AllowExternalDrop = true;
            webViewMapa.BackColor = Color.DarkGray;
            webViewMapa.CreationProperties = null;
            webViewMapa.DefaultBackgroundColor = Color.White;
            webViewMapa.Location = new Point(377, 300);
            webViewMapa.Name = "webViewMapa";
            webViewMapa.Size = new Size(817, 224);
            webViewMapa.TabIndex = 4;
            webViewMapa.ZoomFactor = 1D;
            // 
            // lstLugaresTramite
            // 
            lstLugaresTramite.BackColor = Color.DarkGray;
            lstLugaresTramite.FormattingEnabled = true;
            lstLugaresTramite.Location = new Point(832, 64);
            lstLugaresTramite.Name = "lstLugaresTramite";
            lstLugaresTramite.Size = new Size(239, 94);
            lstLugaresTramite.TabIndex = 5;
            lstLugaresTramite.SelectedIndexChanged += lstLugaresTramite_SelectedIndexChanged;
            // 
            // btnCerrarMapa
            // 
            btnCerrarMapa.Location = new Point(1088, 271);
            btnCerrarMapa.Name = "btnCerrarMapa";
            btnCerrarMapa.Size = new Size(75, 23);
            btnCerrarMapa.TabIndex = 7;
            btnCerrarMapa.Text = "Cerrar";
            btnCerrarMapa.UseVisualStyleBackColor = true;
            btnCerrarMapa.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 8;
            label1.Text = "Preguntas frecuentes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(832, 46);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 9;
            label2.Text = "Ubicaciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1194, 518);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrarMapa);
            Controls.Add(lstLugaresTramite);
            Controls.Add(webViewMapa);
            Controls.Add(lstPreguntasFrecuentes);
            Controls.Add(rtbConversacion);
            Controls.Add(btnEnviar);
            Controls.Add(txtPregunta);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webViewMapa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPregunta;
        private Button btnEnviar;
        private RichTextBox rtbConversacion;
        private ListBox lstPreguntasFrecuentes;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMapa;
        private ListBox lstLugaresTramite;
        private Button btnCerrarMapa;
        private Label label1;
        private Label label2;
    }
}
