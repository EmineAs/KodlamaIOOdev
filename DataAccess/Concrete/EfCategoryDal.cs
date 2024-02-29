using DataAccess.Abstract;
using Entities.Concrete;
using System.Diagnostics;

namespace Workaround;


public class EfCategoryDal : ICategoryDal

{
    List<Category> categories;

    public EfCategoryDal()
    {
        //Bu kısmın admin tarafından klavyeden girildiğini varsıyoruz
        Category category1 = new Category()
        {
            CategoryId = 1,
            CategoryName="Programlama"

        };

        Category category2 = new Category()
        {
            CategoryId = 2,
            CategoryName = "Donanım"

        };

        categories = new List<Category> {category1,category2 };


    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public List<Category> Delete(List<Category> list, int id)
    {
        foreach (var category in list)
        {
            if (category.CategoryId == id)
            {
                list.Remove(category);
                categories = list;
                break;
            }
        }
        return list;
    }

    public List<Category> GetAll()
    {
        foreach (var category in categories)
        {
            Console.WriteLine(category.CategoryId + " " + category.CategoryName);
        }
        return categories;
    }


    public List<Category> Update(List<Category> list, int id)
    {
        foreach (var category in list)
        {
            if (category.CategoryId == id)
            {
                Console.WriteLine("Yeni kategori adını girin...");
                string name = Console.ReadLine();
                category.CategoryName = name;
                break;
            }
        }
        return list;
    }
}





