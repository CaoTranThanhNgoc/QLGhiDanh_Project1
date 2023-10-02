using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("BangDiem")]
    public class BangDiemEntity: Entity
    {
        [Key]
        public string maDiem { get; set; }
        public double diemTB { get; set; }
        public virtual ICollection<HocVien_LopHocEntity>? HocVien_LopHocs { get; set; }

    }
}
