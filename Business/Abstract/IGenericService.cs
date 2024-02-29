using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IGenericService<T> where T : class
{
    List<T> Add(List<T> list, T entity);
    void GetAll(List<T> list);
    List<T> Delete(List<T> list, int id);
    List<T> Update(List<T> list, int id);
    List<T> GetById(int id1,int id2);




}
