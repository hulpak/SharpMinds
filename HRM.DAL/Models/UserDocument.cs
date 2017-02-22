
namespace HRM.DAL.Models
{
    public class UserDocument : BaseModel
    {      
        public string DocumentLink { get; set; }
        public int UserId { set; get; }
        public virtual User User { get; set; }

    }
}
