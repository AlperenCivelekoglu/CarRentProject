using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
//using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //public abstract class EntityManager<TEntity> : IEntityService<TEntity>
    //where TEntity : class// TEntity'nin bir referans türü (class) olması gerektiğini belirtiyoruz.
    //{
    ////    IEntityRepository<TEntity> _entityRepository;

    ////    public  EntityManager(IEntityRepository<TEntity> entityRepository)
    ////    {
    ////        _entityRepository = entityRepository;
    ////    }

    ////    public virtual IResult Add(TEntity entity)
    ////    {
    ////        _entityRepository.Add(entity);
    ////        return new SuccessResult(Messages.CarAdded);
    ////    }

    ////    public virtual IResult Delete(TEntity entity)
    ////    {
    ////        _entityRepository.Delete(entity);
    ////        return new SuccessResult(Messages.CarAdded);
    ////    }

    ////    public virtual IResult Update(TEntity entity)
    ////    {
    ////        _entityRepository.Update(entity);
    ////        return new SuccessResult(Messages.CarAdded);
    ////    }

    ////    public virtual IDataResult<List<TEntity>> GetAll()
    ////    {
    ////        return new SuccessDataResult<List<TEntity>>(_entityRepository.GetAll());
    ////    }
    //}

}
