using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("NguoiDung")]
    public class NguoiDungEntity: Entity
    {
        [Key]
        public string maNguoiDung { get; set; }
        public string tenDangNhap { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public virtual ICollection<ChucVuEntity>? ChucVus { get; set; }

    }
}
