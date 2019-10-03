using System;

namespace SqImport
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var container = IoC.ObterContainer())
                {
                    container.ObterInstancia<Sistema>().Executar();
                }
            }
            catch (NotImplementedException)
            {

            }
        }
    }
}
