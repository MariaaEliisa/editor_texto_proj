using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorTextoUndoRedo
{
    public class Node
    {
        public string Conteudo;
        public Node Anterior;
        public Node Proximo;

        public Node(string conteudo)
        {
            Conteudo = conteudo;
            Anterior = null;
            Proximo = null;
        }
    }
}