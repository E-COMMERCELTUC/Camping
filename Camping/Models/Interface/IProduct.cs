using Camping.Models.DTO;

namespace Camping.Models.Interface
{
    public interface IProduct
    {
        Task<List<ProductDTO>> GetAll();
        Task<ProductDTO> GetById(int Id);
    }
}
