

using Day_4_BookProject.Data;
using System.Threading.Channels;

namespace Day_4_BookProject.Business;

public class CategoryService : ICategoryService

{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    //metodları alt alta yazma cleancode
    public void GetList()
    {
       _categoryRepository
            .GetAll()
            .ForEach(c => Console.WriteLine(c));
    }
}
