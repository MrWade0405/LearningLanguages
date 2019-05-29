﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetList(); 
        T GetItem(int id);
        void Create(T item); 
        void Update(T item); 
        void Delete(int id); 
        void Save();
    }
}
