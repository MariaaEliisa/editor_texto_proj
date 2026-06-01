using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorTextoUndoRedo
{
    public class EditorService
    {
        private HistoricoEditor historico;

        public EditorService()
        {
            historico = new HistoricoEditor();
        }

        public void Salvar(string texto)
        {
            historico.SalvarEstado(texto);
        }

        public string Undo()
        {
            return historico.Undo();
        }

        public string Redo()
        {
            return historico.Redo();
        }

        public string Atual()
        {
            return historico.Atual();
        }
    }
}
