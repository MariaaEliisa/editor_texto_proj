using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorTextoUndoRedo
{
    public class HistoricoEditor
    {
        private Node atual;

        public HistoricoEditor()
        {
            atual = new Node("");
        }

        public void SalvarEstado(string texto)
        {
            atual.Proximo = null;

            Node novo = new Node(texto);

            novo.Anterior = atual;
            atual.Proximo = novo;

            atual = novo;
        }

        public string Undo()
        {
            if (atual.Anterior != null)
                atual = atual.Anterior;

            return atual.Conteudo;
        }

        public string Redo()
        {
            if (atual.Proximo != null)
                atual = atual.Proximo;

            return atual.Conteudo;
        }

        public string Atual()
        {
            return atual.Conteudo;
        }
    } 
    }
