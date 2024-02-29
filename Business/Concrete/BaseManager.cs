using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class BaseManager<T>:IGenericService<T> where T : class
{        
    public List<T> Add(List<T> list, T entity)
    {
        list.Add(entity);
        return list;
    }

  
   
    public void GetAll(List<T> list) 
    {
        for (int i = 0; i < list.Count(); i++)
        {
            
        }
    }

    public void Update(List<T> list, T entity)
    {
        throw new NotImplementedException();
    
    }

    public T GetById(List<T> list, int id)
    {
        throw new NotImplementedException();
    }

    public List<T> Delete(List<T> list, int id)
    {
        throw new NotImplementedException();
    }

    public List<T> Update(List<T> list, int id)
    {
        throw new NotImplementedException();
    }

    public List<T> GetById(int id1, int id2)
    {
        throw new NotImplementedException();
    }
}
 
