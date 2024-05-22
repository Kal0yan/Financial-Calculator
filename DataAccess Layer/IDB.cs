using System;
using System.Linq;
using System.Collections.Generic;
using Business_Layer;
using System.Threading.Tasks;


namespace DataAccess_Layer
{
    public interface IDB <T, K>
    {
        Task CreateAsync(T entity);

        Task<T> ReadAsync(K key, bool isReadOnly = true, bool useNavigationalProperties = false);

        Task<List<T>> ReadAllAsync(bool isReadOnly = true, bool useNavigationalProperties = false);

        Task UpdateAsync(T entity, bool useNavigationalProperties = false);

        Task DeleteAsync(K key);
    }
}
