using DataAccess.Abstract;
using Entities.Concrete;
using System.Diagnostics;

namespace Workaround;


public class EfInstructorDal : IInstructorDal

{
    List<Instructor> instructors;

    public EfInstructorDal()
    {
        //Bu kısmın admin tarafından klavyeden girildiğini varsıyoruz
        Instructor instructor1 = new Instructor()
        {
            InstructorId = 1,
            InstructorName = "Engin DEMİROĞ"

        };


        Instructor instructor2 = new Instructor()
        {
            InstructorId = 2,
            InstructorName = "Halit Enes Kalaycı"
        };




        instructors = new List<Instructor> { instructor1, instructor2 };


    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }


    public List<Instructor> Delete(List<Instructor> list, int id)
    {
        foreach (var instructor in list)
        {
            if (instructor.InstructorId == id)
            {
                list.Remove(instructor);
                instructors = list;
                break;
            }
        }
        return list;
    }


    public List<Instructor> GetAll()
    {
        foreach (var instructor in instructors)
        {
            Console.WriteLine(instructor.InstructorId + " " + instructor.InstructorName);
        }
        return instructors;
    }

    

    public List<Instructor> Update(List<Instructor> list, int id)
    {
        foreach (var instructor in list)
        {
            if (instructor.InstructorId == id)
            {
                Console.WriteLine("Yeni kurs adını girin...");
                string name = Console.ReadLine();
                instructor.InstructorName = name;
                break;
            }
        }
        return list;
    }


}





