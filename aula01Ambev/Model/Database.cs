using System;

namespace aula01Ambev.Atualizar
{
    public static class Database
    {
        public static void Inserir<T>(T entidade)
        {
            Console.WriteLine($"Inseriu entidade {typeof(T).Name}");
        }

        public static void Atualizar<T>(T entidade)
        {
            Console.WriteLine($"Entidade {typeof(T).Name} atuzalizada");
        }
        
        public static void Deletar<T>(Guid id)
        {
            Console.WriteLine($"Entidade {typeof(T).Name} deletada");
        }

        public static Task<T> BuscarPorId<T>(Guid Id)
        {
            Console.WriteLine($"Buscou pelo id");
            return null;
        }

        public static Task<T> BuscarPorNome<T>(string nome)
        {
            Console.WriteLine($"Buscou pelo nome");
            return null;
        }
    }
}
