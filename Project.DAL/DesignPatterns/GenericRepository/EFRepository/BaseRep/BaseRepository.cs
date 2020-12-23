using Project.DAL.Context;
using Project.DAL.DesignPatterns.GenericRepository.IntRep;
using Project.DAL.DesignPatterns.SingletonPattern;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DesignPatterns.GenericRepository.EFRepository.BaseRep
{
    //Sadece Entity Framework kütüphanesi içinn kullanın. Çünkü EFRepository içinde.

    //Kesinlikle abstract olmamalı.BaseRepository kesinlikle abstract olmaması lazım yoksa kullanmak istediğimiz yerde constructor içinde instance alamayız.
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        //BaseRepository kullanmamız nedeni kod tekrarını önlemektir. Bu durum olmasaydı IRepositoryden miras alarak tüm repository sınıflarımız için aşağıdaki kodları implament ederdik.

        MyContext _db;

        public BaseRepository()
        {
            _db = DBTool.DBInstance;
        }

        public List<T> GetActives()
        {
            return _db.Set<T>().Where(x=>x.Status!=ENTITIES.Enums.DataStatus.Deleted).ToList();
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetModifieds()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetPassives()
        {
            return _db.Set<T>().ToList();
        }
    }
}
