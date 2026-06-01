namespace EditorTextoUndoRedo
{
    public partial class Form1 : Form
    {
        private EditorService editor = new EditorService();

        public Form1()
        {
            InitializeComponent();

            this.Text = "Editor de Texto com Undo/Redo";
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
