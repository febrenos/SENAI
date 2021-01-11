namespace EstudoTaskool.Views
{
    partial class frmListaUsuario
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
            this.dgvListaAluno = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.filtroTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaAluno
            // 
            this.dgvListaAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAluno.Location = new System.Drawing.Point(11, 37);
            this.dgvListaAluno.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaAluno.Name = "dgvListaAluno";
            this.dgvListaAluno.RowHeadersWidth = 51;
            this.dgvListaAluno.RowTemplate.Height = 24;
            this.dgvListaAluno.Size = new System.Drawing.Size(765, 349);
            this.dgvListaAluno.TabIndex = 0;
            this.dgvListaAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAluno_CellClick);
            this.dgvListaAluno.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaAluno_CellMouseClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Location = new System.Drawing.Point(784, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // filtroTextbox
            // 
            this.filtroTextbox.Location = new System.Drawing.Point(46, 12);
            this.filtroTextbox.Name = "filtroTextbox";
            this.filtroTextbox.Size = new System.Drawing.Size(207, 20);
            this.filtroTextbox.TabIndex = 2;
            this.filtroTextbox.TextChanged += new System.EventHandler(this.filtroTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            // 
            // lblContador
            // 
            this.lblContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(781, 373);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(35, 13);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "label2";
            // 
            // frmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 397);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtroTextbox);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvListaAluno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListaUsuario";
            this.Text = "Listagem de Usuário";
            this.Load += new System.EventHandler(this.frmListaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaAluno;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox filtroTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContador;
    }
}