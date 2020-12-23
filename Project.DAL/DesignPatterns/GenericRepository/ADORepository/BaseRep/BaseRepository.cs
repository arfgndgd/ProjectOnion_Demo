using Project.DAL.Context;
using Project.DAL.DesignPatterns.GenericRepository.IntRep;
using Project.DAL.DesignPatterns.SingletonPattern;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DesignPatterns.GenericRepository.ADORepository.BaseRep
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {

        MyContext _db;
        public BaseRepository()
        {
            _db = DBTool.DBInstance;
        }


        //Burada artık EntityFramework kodu yazamayız. Çünkü farklı bir teknoloji kullanımı söz konusu. ADO.net kodları kulllanmak gerekir.
        public List<T> GetActives()
        {
            /*
                SqlConnection scc=new SqlConnection();
                scc.Command = "select * from Products";
                List<T> bilgiler = scc.CommandExecute();
                return bilgiler;

            */

            return null;
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
