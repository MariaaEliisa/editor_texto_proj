namespace EditorTextoUndoRedo
{
    public partial class Form1 : Form
    {
        private EditorService editor = new EditorService();

        public Form1()
        {
            InitializeComponent();

            this.Text = "Editor de Texto com Undo/Redo";

            SetupButtonHoverEffects();
        }

        private void SetupButtonHoverEffects()
        {
            btnSalvar.MouseEnter += (s, e) => btnSalvar.BackColor = Color.FromArgb(0, 100, 180);
            btnSalvar.MouseLeave += (s, e) => btnSalvar.BackColor = Color.FromArgb(0, 120, 212);

            btnUndo.MouseEnter += (s, e) => btnUndo.BackColor = Color.FromArgb(75, 85, 99);
            btnUndo.MouseLeave += (s, e) => btnUndo.BackColor = Color.FromArgb(107, 114, 128);

            btnRedo.MouseEnter += (s, e) => btnRedo.BackColor = Color.FromArgb(75, 85, 99);
            btnRedo.MouseLeave += (s, e) => btnRedo.BackColor = Color.FromArgb(107, 114, 128);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            editor.Salvar(txtEditor.Text);

            lstHistorico.Items.Add(txtEditor.Text);

            lblEstadoAtual.Text =
       "Estado Atual: " + txtEditor.Text;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtEditor.Text = editor.Undo();

            lblEstadoAtual.Text =
        "Estado Atual: " + txtEditor.Text;
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            txtEditor.Text = editor.Redo();

            lblEstadoAtual.Text =
        "Estado Atual: " + txtEditor.Text;
        }
    }
}
