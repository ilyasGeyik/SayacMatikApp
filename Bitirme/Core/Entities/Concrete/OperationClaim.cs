using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Concrete
{
    public class OperationClaim:IEntity
    {
        [Key]
        public string YetkiId { get; set; }
        public string YetkiAd { get; set; }

    }
}
