using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workaround;

namespace Business.Concrete;

public class InstructorManager : BaseManager<Instructor>
{

    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public List<Instructor> GetAll()
    {
        // business rules       
        return _instructorDal.GetAll();
    }

    public List<Instructor> Delete(List<Instructor> list, int id)
    {
        return _instructorDal.Delete(list, id);
    }

    public List<Instructor> Update(List<Instructor> list, int id)
    {
        return _instructorDal.Update(list, id);
    }

    
}
