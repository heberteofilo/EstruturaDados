using System.Collections.Generic;

namespace EstruturaDados.Estruturas_de_Dados
{
    class MinhaFila
    {
        public Queue<string> Fila { get; set; } = new Queue<string>();

        public string Enfileirar(string item)
        {
            if (string.IsNullOrWhiteSpace(item))
            {
                return "Preencher corretamente!";
            }
            Fila.Enqueue(item);
            return "Enfileirado!";
        }

        public string Desenfileirar()
        {
            if (Fila.Count > 0)
            {
                return Fila.Dequeue();
            }
            return "Fila vazia!";
        }

        public string Topo()
        {
            if (Fila.Count > 0)
            {
                return Fila.Peek();
            }
            return "Fila vazia";

        }

        public string Limpar()
        {
            if (Fila.Count > 0)
            {
                Fila.Clear();
                return "Fila limpa";
            }
            return "Fila já está vazia!";
        }
    }
}
