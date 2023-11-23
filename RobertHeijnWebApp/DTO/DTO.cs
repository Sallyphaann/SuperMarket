using BusinessLogic;
using BusinessLogic.Entities;
using RobertHeijnWebApp.DTO;

namespace RobertHeijnWebApp.Pages
{
    public class DTO
    {
        public static Member MemberDTO(MemberRegister dto)
        {

            string salt = Guid.NewGuid().ToString();
            string hashedPassword = PasswordHasher.sha256_hash(dto.Password + salt);
            return new Member(dto.Firstname, dto.Lastname, dto.Email, dto.Address, (dto.Username).ToLower(), hashedPassword, salt, dto.Biography);
        }
        public static Product productDTO(ProductDTO PDTO)
        {
            return new Product(PDTO.ID);
        }
        public static ProductDTO GetProductDTO(Product product)
        {
            return new ProductDTO(product.ID, product.Name, product.Price, product.Unit);
        }
    }
}
