using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    void Add(Instructor Instructor);
    List<Instructor> Delete(List<Instructor> list, int id);
    List<Instructor> Update(List<Instructor> list, int id);




}
