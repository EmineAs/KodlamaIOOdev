using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;

public interface ICategoryDal
{
    List<Category> GetAll();
    void Add(Category Category);
    List<Category> Delete(List<Category> list, int id);
    List<Category> Update(List<Category> list, int id);




}
