namespace EditorTextoUndoRedo
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
            txtEditor = new TextBox();
            btnSalvar = new Button();
            btnUndo = new Button();
            btnRedo = new Button();
            lstHistorico = new ListBox();
            lblTituloEditor = new Label();
            lblHistorico = new Label();
            lblEstadoAtual = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtEditor
            // 
            txtEditor.Font = new Font("Segoe UI", 11F);
            txtEditor.Location = new Point(193, 85);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.ScrollBars = ScrollBars.Vertical;
            txtEditor.Size = new Size(408, 156);
            txtEditor.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(193, 279);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 23);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar Estado";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(503, 279);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(98, 23);
            btnUndo.TabIndex = 2;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.Location = new Point(352, 279);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(98, 23);
            btnRedo.TabIndex = 3;
            btnRedo.Text = "Redo";
            btnRedo.UseVisualStyleBackColor = true;
            btnRedo.Click += btnRedo_Click;
            // 
            // lstHistorico
            // 
            lstHistorico.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstHistorico.FormattingEnabled = true;
            lstHistorico.ItemHeight = 15;
            lstHistorico.Location = new Point(193, 358);
            lstHistorico.Name = "lstHistorico";
            lstHistorico.Size = new Size(408, 109);
            lstHistorico.TabIndex = 4;
            // 
            // lblTituloEditor
            // 
            lblTituloEditor.AutoSize = true;
            lblTituloEditor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloEditor.Location = new Point(338, 61);
            lblTituloEditor.Name = "lblTituloEditor";
            lblTituloEditor.Size = new Size(112, 21);
            lblTituloEditor.TabIndex = 5;
            lblTituloEditor.Text = "Área de Edição";
            // 
            // lblHistorico
            // 
            lblHistorico.AutoSize = true;
            lblHistorico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistorico.Location = new Point(338, 334);
            lblHistorico.Name = "lblHistorico";
            lblHistorico.Size = new Size(150, 21);
            lblHistorico.TabIndex = 6;
            lblHistorico.Text = "Histórico de Estados";
            // 
            // lblEstadoAtual
            // 
            lblEstadoAtual.AutoSize = true;
            lblEstadoAtual.Font = new Font("Segoe UI", 10F);
            lblEstadoAtual.Location = new Point(193, 487);
            lblEstadoAtual.Name = "lblEstadoAtual";
            lblEstadoAtual.Size = new Size(125, 19);
            lblEstadoAtual.TabIndex = 7;
            lblEstadoAtual.Text = "Estado Atual: Vazio";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 9);
            label1.Name = "label1";
            label1.Size = new Size(476, 23);
            label1.TabIndex = 8;
            label1.Text = "EDITOR DE TEXTO COM LISTA ENCADEADA DUPLA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(label1);
            Controls.Add(lblEstadoAtual);
            Controls.Add(lblHistorico);
            Controls.Add(lblTituloEditor);
            Controls.Add(lstHistorico);
            Controls.Add(btnRedo);
            Controls.Add(btnUndo);
            Controls.Add(btnSalvar);
            Controls.Add(txtEditor);
            Name = "Form1";
            Text = "Editor de Texto - Undo / Redo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEditor;
        private Button btnSalvar;
        private Button btnUndo;
        private Button btnRedo;
        private ListBox lstHistorico;
        private Label lblTituloEditor;
        private Label lblHistorico;
        private Label lblEstadoAtual;
        private Label label1;
    }
}
