namespace aula01Ambev.Database
{
    public static class DatabaseExtensions
    {
        public static void Inserir<T>(this List<T> entidades, T objeto)
        {
            Console.WriteLine($"Inseriu entidade {typeof(T).Name}");
            entidades.Add(objeto);
        }

        public static void Deletar<T>(this List<T> entidades, int id)
        {
            Console.WriteLine($"Entidade {typeof(T).Name} deletada");
            entidades.RemoveAt(id);
        }
    }
}
