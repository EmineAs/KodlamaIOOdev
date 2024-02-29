using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CourseManager:BaseManager<Course>
{

    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        // business rules       
        return _courseDal.GetAll();
    }

    public List<Course> Delete(List<Course> list, int id)
    {
        return _courseDal.Delete(list,id);
    }

    public List<Course> Update(List<Course> list, int id)
    {
        return _courseDal.Update(list, id);
    }

    public List<Course> GetById(List<Category> categories, List<Instructor> instructors,int id1, int id2)
    {
        return _courseDal.GetById(categories, instructors, id1,id2);

    }
}
