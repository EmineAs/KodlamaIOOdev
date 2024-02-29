
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Workaround;


public partial class Program
{
    //Aynı liste üzerinde işlem yapabilmek için global olarak tanımladım...


    public static CourseManager courseManager = new(new EfCourseDal());
    public static CategoryManager categoryManager = new(new EfCategoryDal());
    public static InstructorManager instructorManager = new(new EfInstructorDal());

    public static List<Course> courses;
    public static List<Category> categories;
    public static List<Instructor> instructors;



    private static void Main(string[] args)
    {
        GetCourse();
        DeleteCourse();
        UpdateCourse();

        GetCategory();
        DeleteCategory();
        UpdateCategory();

        GetInstructor();
        DeleteInstructor();
        UpdateInstructor();

        GetCourseById();

    }

   
    private static void GetCourseById()
    {
        string categoryname = " ";
        string instructorname = " ";
        
        List<Course> courselist = new List<Course>();

        GetCategory();
        Console.WriteLine("listelemek istediğiniz kursun kategorisinin idsini girin..");
        int id1 = Convert.ToInt32(Console.ReadLine());

        GetInstructor();
        Console.WriteLine("listelemek istediğiniz kursun kategorisinin idsini girin..");
        int id2 = Convert.ToInt32(Console.ReadLine());

        courselist = courseManager.GetById(categories, instructors, id1, id2);

        foreach (Course course in courselist)
        {
            foreach (var c in categories)
            {
                if (id1 == c.CategoryId)
                {
                    categoryname= c.CategoryName;
                    break;
                }
                
            }
            foreach (var i in instructors)
            {
                if(id2==i.InstructorId )
                {
                    instructorname= i.InstructorName;
                }

            }

            Console.WriteLine(course.CourseID+ " " +course.CourseName+" "+ categoryname+" "+ instructorname);

        }





        Console.WriteLine("-----------");
        Console.WriteLine("-----------");
    }

    private static void UpdateInstructor()
    {
        Console.WriteLine("değiştirmek istediğiniz kategorinin idsini girin seçin..");
        int id6 = Convert.ToInt32(Console.ReadLine());
        instructors = instructorManager.Update(instructors, id6);
        instructors = instructorManager.GetAll();
        Console.WriteLine("-----------");
        Console.WriteLine("-----------");
    }

    private static void DeleteInstructor()
    {
        Console.WriteLine("silmek istediğiniz kategorinin idsini girin seçin..");
        int id5 = Convert.ToInt32(Console.ReadLine());
        instructors = instructorManager.Delete(instructors, id5);
        instructors = instructorManager.GetAll();
        Console.WriteLine("-----------");
    }

    private static void GetInstructor()
    {
        Console.WriteLine("  Eğitmenler");
        Console.WriteLine("---------------");
        instructors = instructorManager.GetAll();
        Console.WriteLine("-----------");
    }

    private static void UpdateCategory()
    {
        Console.WriteLine("değiştirmek istediğiniz kategorinin idsini girin seçin..");
        int id4 = Convert.ToInt32(Console.ReadLine());
        categories = categoryManager.Update(categories, id4);
        categories = categoryManager.GetAll();
        Console.WriteLine("-----------");
        Console.WriteLine("-----------");
    }

    private static void DeleteCategory()
    {
        Console.WriteLine("silmek istediğiniz kategorinin idsini girin seçin..");
        int id3 = Convert.ToInt32(Console.ReadLine());
        categories = categoryManager.Delete(categories, id3);
        categories = categoryManager.GetAll();
        Console.WriteLine("-----------");
    }

    private static void GetCategory()
    {
        Console.WriteLine("  Kategoriler");
        Console.WriteLine("---------------");
        categories = categoryManager.GetAll();
        Console.WriteLine("-----------");
    }

    private static void UpdateCourse()
    {
        Console.WriteLine("değiştirmek istediğiniz kursun idsini girin seçin..");
        int id2 = Convert.ToInt32(Console.ReadLine());
        courses = courseManager.Update(courses, id2);
        courses = courseManager.GetAll();
        Console.WriteLine("-----------");
        Console.WriteLine("-----------");
    }

    private static void DeleteCourse()
    {
        Console.WriteLine("silmek istediğiniz kursun idsini girin seçin..");
        int id1 = Convert.ToInt32(Console.ReadLine());
        courses = courseManager.Delete(courses, id1);
        courses = courseManager.GetAll();
        Console.WriteLine("-----------");
    }

    private static void GetCourse()
    {
        Console.WriteLine("  Kurslar");
        Console.WriteLine("-----------");
        courses = courseManager.GetAll();
        Console.WriteLine("-----------");
    }



}


