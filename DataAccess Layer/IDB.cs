using System;
using System.Linq;
using System.Collections.Generic;
using Business_Layer;
using System.Threading.Tasks;


namespace DataAccess_Layer
{
    public interface IDB<T, K>
    {
        void Create(T entity);

        T Read(K key, bool isReadOnly = true, bool useNavigationalProperties = false);

        List<T> ReadAll(bool isReadOnly = true, bool useNavigationalProperties = false);

        void Update(T entity, bool useNavigationalProperties = false);

        void Delete(K key);
    }
}
