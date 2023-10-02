using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("KhoaDaoTao")]
    public class KhoaDaoTaoEntity: Entity
    {
        [Key]
        public string maKhoaDaoTao { get; set; }
        public string tenKhoaDaoTao { get; set; }
        public DateTimeOffset ngayBatDau { get; set; }
        public DateTimeOffset ngayKetThuc { get; set; }
        public virtual ICollection<MonHoc_KhoaDaoTaoEntity>? MonHoc_KhoaDaoTaos { get; set; }

        [ForeignKey("NhanVien")]
        public string? maNhanVien { get; set; }
        public virtual NhanVienEntity? NhanVien { get; set; }
    }
}
