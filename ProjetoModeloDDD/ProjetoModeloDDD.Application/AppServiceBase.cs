using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _servieBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _servieBase = serviceBase;
        }

        void IAppServiceBase<TEntity>.Add(TEntity obj)
        {
            _servieBase.Add(obj);
        }

        IEnumerable<TEntity> IAppServiceBase<TEntity>.GetAll()
        {
            return _servieBase.GetAll();
        }

        TEntity IAppServiceBase<TEntity>.GetById(int id)
        {
            return _servieBase.GetById(id);
        }

        void IAppServiceBase<TEntity>.Remove(TEntity obj)
        {
            _servieBase.Remove(obj);
        }

        void IAppServiceBase<TEntity>.Update(TEntity obj)
        {
            _servieBase.Update(obj);
        }
        public void Dispose()
        {
            _servieBase.Dispose();
        }


    }
}
