using System.Collections.Generic;

namespace EstruturaDados.Estruturas_de_Dados
{
    class MinhaPilha
    {
        public Stack<string> Pilha { get; set; } = new Stack<string>();

        public string Empilhar(string item)
        {
            if (string.IsNullOrWhiteSpace(item))
            {
                return "Preencher corretamente!";
            }
            Pilha.Push(item);
            return "Empilhado!";
        }

        public string Desempilhar()
        {
            if (Pilha.Count > 0)
            {
                return Pilha.Pop();
            }
            return "Pilha vazia!";
        }

        public string Topo()
        {
            if (Pilha.Count > 0)
            {
                return Pilha.Peek();
            }
            return "Pilha vazia";
            
        }

        public string Limpar()
        {
            if (Pilha.Count > 0)
            {
                Pilha.Clear();
                return "Pilha limpa";
            }
            return "Pilha já está vazia!";
        }
    }
}
