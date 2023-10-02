using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("LichNghi")]
    public class LichNghiEntity: Entity
    {
        [Key]
        public string maLich { get; set; }
        public string tenLich { get; set; }
        public string lyDo { get; set; }
        public DateTimeOffset ngayBatDau { get; set; }
        public DateTimeOffset ngayKetThuc { get; set; }
        public virtual ICollection<LopHocEntity>? LopHocs { get; set; }

    }
}
