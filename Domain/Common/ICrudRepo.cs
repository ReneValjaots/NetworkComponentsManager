﻿namespace Nc.Domain.Common;
public interface ICrudRepo<TEntity> where TEntity : class {
    string ErrorMessage { get; }
    Task<bool> AddAsync(TEntity obj);
    Task<bool> DeleteAsync(int id);
    Task<TEntity?> FindAsync(int? id);
    Task<IEnumerable<TEntity>> GetAsync();
    Task<TEntity?> GetAsync(int? id);
    Task<bool> UpdateAsync(TEntity obj);
}
