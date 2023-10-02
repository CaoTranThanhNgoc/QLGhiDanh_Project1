using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("LichHoc")]
    public class LichHocEntity: Entity
    {
        [Key]
        public string maLichHoc { get; set; }
        public string tenLichHoc { get; set; }

        [ForeignKey("LopHoc")]
        public string maLopHoc { get; set; }
        public virtual LopHocEntity? LopHoc { get; set; }
    }
}
