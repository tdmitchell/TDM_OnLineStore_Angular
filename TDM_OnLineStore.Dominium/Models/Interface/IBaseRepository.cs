﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TDM_OnLineStore.Dominium.Models.Interface
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
