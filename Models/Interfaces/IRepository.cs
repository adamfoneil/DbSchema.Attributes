﻿using System.Threading.Tasks;

namespace AO.Models.Interfaces
{
    public interface IRepository<TModel, TKey, TUser>
        where TModel : IModel<TKey>
        where TUser : IUserBase
    {
        Task<TModel> GetAsync(TUser user, TKey id);
        Task<TModel> SaveAsync(TUser user, TModel model);
        Task DeleteAsync(TUser user, TKey id);
    }
}
