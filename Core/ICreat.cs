using System;
using System.Linq;

namespace Core
{
    public interface ICreat<T> where T : class
    {
        T Create(T data); // Veya doğrudan TEntity objesi alabiliriz
    }
}
