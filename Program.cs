namespace SqImport
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var container = IoC.ObterContainer())
            {
                container.ObterInstancia<Sistema>().Executar();
            }
        }
    }
}
