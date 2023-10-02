using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("GiangVien")]
    public class GiangVienEntity: Entity
    {
        [Key]
        public string maGiangVien { get; set; }
        public string matKhau { get; set; }

        [ForeignKey("NhanVien")]
        public string? maNhanVien { get; set; }
        public virtual NhanVienEntity? NhanVien { get; set; }
        public virtual ICollection<GiangVien_MonHocEntity>? GiangVien_MonHocs { get; set; }

    }
}
