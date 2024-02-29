using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
    List<Course> Delete(List<Course> list, int id);
    List<Course> Update(List<Course> list, int id);
    List<Course> GetById(List<Category> categories, List<Instructor> instructors,int id1, int id2);






}
