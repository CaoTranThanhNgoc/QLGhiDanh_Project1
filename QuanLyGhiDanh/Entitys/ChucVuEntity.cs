using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("ChucVu")]
    public class ChucVuEntity: Entity
    {
        [Key]
        public string maChucVu { get; set; }
        public string tenChucVu { get; set; }
        public virtual ICollection<NhanVienEntity>? NhanViens { get; set; }
        [ForeignKey("NguoiDung")]
        public string maNguoiDung { get; set; }
        public virtual NguoiDungEntity? NguoiDung { get; set; }
    }
}
