using DataAccess.Abstract;
using Entities.Concrete;
using System.Diagnostics;

namespace Workaround;


public class EfCourseDal : ICourseDal

{
    List<Course> courses;

    public EfCourseDal()
    {
        //Bu kısmın admin tarafından klavyeden girildiğini varsıyoruz
        Course course1 = new Course()
        {
            CourseID = 1,
            CourseName = "C#",
            CategoryId = 1,
            InstructorId = 1

        };


        Course course2 = new Course()
        {
            CourseID = 2,
            CourseName = "Java",
            CategoryId = 1,
            InstructorId = 1
        };


        Course course3 = new Course()
        {
            CourseID = 3,
            CourseName = "Phyton",
            CategoryId = 1,
            InstructorId = 2
        };

        courses = new List<Course> { course1, course2, course3 };


    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public List<Course> Delete(List<Course> list, int id)
    {
        foreach (var course in list)
        {
            if (course.CourseID == id)
            {
                list.Remove(course);
                courses = list;
                break;
            }
        }
        return list;
    }

    public List<Course> GetAll()
    {
        foreach (var course in courses)
        {
            Console.WriteLine(course.CourseID + " " + course.CourseName);
        }
        return courses;
    }

    public List<Course> GetById(List<Category> categories,List<Instructor> instructors, int id1,int id2)
    {
        List<Course> list = new List<Course>();

        foreach (var course in courses)
        {
            if(course.CategoryId == id1 && course.InstructorId==id2) 
            {
                list.Add(course);
            }        
        }
        return list;
    }

   


    public List<Course> Update(List<Course> list, int id)
    {
        foreach (var course in list)
        {
            if (course.CourseID == id)
            {
                Console.WriteLine("Yeni kurs adını girin...");
                string name = Console.ReadLine();
                course.CourseName = name;
                break;
            }
        }
        return list;
    }
}





