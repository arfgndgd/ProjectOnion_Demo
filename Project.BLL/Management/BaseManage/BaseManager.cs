using Project.BLL.Management.IntManager;
using Project.DAL.DesignPatterns.GenericRepository.EFRepository.BaseRep; //Gidip buraya ADORepository yazarsak teknoloji değişmiş olur. Interface sayesinde başka hiçbir yerde değişiklik yapmaya gerek kalmaz. (standartlara uyduğumuz sürece(isimlendirme gibi))
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Management.BaseManage
{
    //bu abstract olabilir
    public abstract class BaseManager<T> : IManager<T> where T : BaseEntity
    {
        //Dikkat edersek burada üüzerinde işlem yapacağımız class belli değildir.

        BaseRepository<T> _baseRep;

        //farklı teknolojileri aynı anda kullanmak için usingleri başına yazmak gerekir.
        //Project.DAL.DesignPatterns.GenericRepository.ADORepository.BaseRep.BaseRepository<T> _baseRep;
        //Project.DAL.DesignPatterns.GenericRepository.EFRepository.BaseRep.BaseRepository<T> _efRep;

        //BaseRepository<T> _baseRep;
       
        public BaseManager()
        {  //bu işlemi yapabilmek için kesinlikle BaseRepositorynin "abstract" olmaması lazım yoksa aşağıdaki instance işlemini yapamayız.
            _baseRep = new BaseRepository<T>();

            //farklı teknolojileri aynı anda kullanmak için
            //Project.DAL.DesignPatterns.GenericRepository.ADORepository.BaseRep.BaseRepository<T>();
        }

        public List<T> GetActives()
        {
            //İş mantığı kodları(Kullanıcı vs veritabanında varsa ya da yoksa false ya da true döndür ki ben buna göre ekleme yapıp yapmayacağıma karar vereyim)
            
            //Yukarıdaki durum true dönüyorsa
            return _baseRep.GetActives();

            //True dönmüyorsa 
            //out parametresine false verki gideceğin UI bir sıkıntı olduğunu anlasınn ve hemen kullanıcıya uyarı versin
            //return null
        }

        public List<T> GetAll()
        {
            //İş mantığı 
            throw new NotImplementedException();
        }

        public List<T> GetModifieds()
        {
            //İş mantığı 
            throw new NotImplementedException();
        }

        public List<T> GetPassives()
        {
            //İş mantığı 
            throw new NotImplementedException();
        }
    }
}
