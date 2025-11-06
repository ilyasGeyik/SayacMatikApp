using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int KullaniciID {  get; set; }
        public int YetkiId { get; set; }

    }
}
