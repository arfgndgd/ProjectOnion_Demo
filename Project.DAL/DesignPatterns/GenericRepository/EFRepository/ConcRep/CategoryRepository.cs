using Project.DAL.DesignPatterns.GenericRepository.EFRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DesignPatterns.GenericRepository.EFRepository.ConcRep
{

    //burada CategoryRepository'nin başına EF vermeye gerek kalmaz çünkü namespaceteki klasör ile bunu hallettik. Böylece başka bir repository kulllanırken PLde usinge örneğin ADORepository ekleyerek esnekliği sağlamış olacağız. Bu bi SOLİD'tir.
    public class CategoryRepository:BaseRepository<Category>
    {
    }
}
