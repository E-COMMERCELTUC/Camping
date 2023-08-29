namespace Camping.Models.Interface
{
    public interface ICategory
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int Id);
    
    }
}
