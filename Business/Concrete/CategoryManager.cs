using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CategoryManager : BaseManager<Category>
{

    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public List<Category> GetAll()
    {
        // business rules       
        return _categoryDal.GetAll();
    }

    public List<Category> Delete(List<Category> list, int id)
    {
        return _categoryDal.Delete(list, id);
    }

    public List<Category> Update(List<Category> list, int id)
    {
        return _categoryDal.Update(list, id);
    }
}
