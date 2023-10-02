using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("ToBoMon")]
    public class ToBoMonEntity: Entity
    {
        [Key]
        public string maBoMon { get; set; }
        public string tenBoMon { get; set; }

        public virtual ICollection<MonHocEntity>? MonHocs { get; set; }

        [ForeignKey("KhoaKhoi")]
        public string maKhoa { get; set; }
        public virtual KhoaKhoiEntity? KhoaKhoi { get; set; }
    }
}
