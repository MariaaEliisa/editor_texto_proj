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
            panelEditor = new Panel();
            panelHistorico = new Panel();
            panelBotoes = new Panel();
            panelHeader = new Panel();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 120, 212);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(850, 70);
            panelHeader.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(500, 30);
            label1.TabIndex = 8;
            label1.Text = "Editor de Texto - Undo / Redo";
            // 
            // panelEditor
            // 
            panelEditor.BackColor = Color.White;
            panelEditor.Location = new Point(20, 90);
            panelEditor.Name = "panelEditor";
            panelEditor.Size = new Size(810, 200);
            panelEditor.TabIndex = 10;
            // 
            // lblTituloEditor
            // 
            lblTituloEditor.AutoSize = true;
            lblTituloEditor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloEditor.ForeColor = Color.FromArgb(31, 41, 55);
            lblTituloEditor.Location = new Point(10, 15);
            lblTituloEditor.Name = "lblTituloEditor";
            lblTituloEditor.Size = new Size(100, 20);
            lblTituloEditor.TabIndex = 5;
            lblTituloEditor.Text = "Área de Edição";
            // 
            // txtEditor
            // 
            txtEditor.BackColor = Color.FromArgb(249, 250, 251);
            txtEditor.BorderStyle = BorderStyle.FixedSingle;
            txtEditor.Font = new Font("Segoe UI", 11F);
            txtEditor.Location = new Point(10, 45);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.ScrollBars = ScrollBars.Vertical;
            txtEditor.Size = new Size(790, 140);
            txtEditor.TabIndex = 0;
            // 
            // panelBotoes
            // 
            panelBotoes.BackColor = Color.White;
            panelBotoes.Location = new Point(20, 300);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(810, 60);
            panelBotoes.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 120, 212);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(10, 15);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(140, 30);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar Estado";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnUndo
            // 
            btnUndo.BackColor = Color.FromArgb(107, 114, 128);
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Font = new Font("Segoe UI", 10F);
            btnUndo.ForeColor = Color.White;
            btnUndo.Location = new Point(160, 15);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(120, 30);
            btnUndo.TabIndex = 2;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.BackColor = Color.FromArgb(107, 114, 128);
            btnRedo.FlatStyle = FlatStyle.Flat;
            btnRedo.Font = new Font("Segoe UI", 10F);
            btnRedo.ForeColor = Color.White;
            btnRedo.Location = new Point(290, 15);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(120, 30);
            btnRedo.TabIndex = 3;
            btnRedo.Text = "Redo";
            btnRedo.UseVisualStyleBackColor = false;
            btnRedo.Click += btnRedo_Click;
            // 
            // panelHistorico
            // 
            panelHistorico.BackColor = Color.White;
            panelHistorico.Location = new Point(20, 370);
            panelHistorico.Name = "panelHistorico";
            panelHistorico.Size = new Size(810, 180);
            panelHistorico.TabIndex = 12;
            // 
            // lblHistorico
            // 
            lblHistorico.AutoSize = true;
            lblHistorico.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHistorico.ForeColor = Color.FromArgb(31, 41, 55);
            lblHistorico.Location = new Point(10, 15);
            lblHistorico.Name = "lblHistorico";
            lblHistorico.Size = new Size(150, 20);
            lblHistorico.TabIndex = 6;
            lblHistorico.Text = "Histórico de Estados";
            // 
            // lstHistorico
            // 
            lstHistorico.BackColor = Color.FromArgb(249, 250, 251);
            lstHistorico.BorderStyle = BorderStyle.FixedSingle;
            lstHistorico.Font = new Font("Segoe UI", 9.75F);
            lstHistorico.FormattingEnabled = true;
            lstHistorico.ItemHeight = 18;
            lstHistorico.Location = new Point(10, 45);
            lstHistorico.Name = "lstHistorico";
            lstHistorico.Size = new Size(790, 120);
            lstHistorico.TabIndex = 4;
            // 
            // lblEstadoAtual
            // 
            lblEstadoAtual.AutoSize = true;
            lblEstadoAtual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoAtual.ForeColor = Color.FromArgb(0, 120, 212);
            lblEstadoAtual.Location = new Point(20, 560);
            lblEstadoAtual.Name = "lblEstadoAtual";
            lblEstadoAtual.Size = new Size(150, 19);
            lblEstadoAtual.TabIndex = 7;
            lblEstadoAtual.Text = "Estado Atual: Vazio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(850, 590);
            Controls.Add(panelHeader);
            Controls.Add(panelEditor);
            Controls.Add(panelBotoes);
            Controls.Add(panelHistorico);
            Controls.Add(lblEstadoAtual);
            panelHeader.Controls.Add(label1);
            panelEditor.Controls.Add(lblTituloEditor);
            panelEditor.Controls.Add(txtEditor);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Controls.Add(btnUndo);
            panelBotoes.Controls.Add(btnRedo);
            panelHistorico.Controls.Add(lblHistorico);
            panelHistorico.Controls.Add(lstHistorico);
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
        private Panel panelEditor;
        private Panel panelHistorico;
        private Panel panelBotoes;
        private Panel panelHeader;
    }
}
