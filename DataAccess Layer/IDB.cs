using System;
using System.Linq;
using System.Collections.Generic;
using Business_Layer;
using System.Threading.Tasks;


namespace DataAccess_Layer
{
    public interface IDB <T, K>
    {
        Task Create(T entity);

        Task<T> Read(K key, bool isReadOnly = true, bool useNavigationalProperties = false);

        Task<List<T>> ReadAll(bool isReadOnly = true, bool useNavigationalProperties = false);

        Task Update(T entity, bool useNavigationalProperties = false);

        Task Delete(K key);
    }
}
