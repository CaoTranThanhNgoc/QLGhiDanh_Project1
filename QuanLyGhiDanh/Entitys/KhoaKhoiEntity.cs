using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("KhoaKhoi")]
    public class KhoaKhoiEntity: Entity
    {
        [Key]
        public string maKhoa { get; set; }
        public string tenKhoa { get; set; }
        public virtual ICollection<ToBoMonEntity>? ToBoMons { get; set; }

    }
}
