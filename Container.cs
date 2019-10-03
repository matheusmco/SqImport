using System;

namespace SqImport
{
    public class Container : IDisposable
    {
        public static Container Inicializar()
        {
            throw new System.NotImplementedException();          
        }

        public void Registrar<T>()
        {
            throw new System.NotImplementedException();          
        }

        public T ObterInstancia<T>()
        {
            throw new System.NotImplementedException();          
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}