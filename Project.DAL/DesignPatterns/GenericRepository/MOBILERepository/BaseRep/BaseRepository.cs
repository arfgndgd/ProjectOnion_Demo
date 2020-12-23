using Project.DAL.Context;
using Project.DAL.DesignPatterns.GenericRepository.IntRep;
using Project.DAL.DesignPatterns.SingletonPattern;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DesignPatterns.GenericRepository.MOBILERepository.BaseRep
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext _db;
        public BaseRepository()
        {
            _db = DBTool.DBInstance;
        }

        public List<T> GetActives()
        {
            //mobile için kodlar
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetModifieds()
        {
            throw new NotImplementedException();
        }

        public List<T> GetPassives()
        {
            throw new NotImplementedException();
        }
    }
}
