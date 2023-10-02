using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("LoaiDiem")]
    public class LoaiDiemEntity: Entity
    {
        [Key]
        public string maLoaiDiem { get; set; }
        public string tenLoaiDiem { get; set; }
        public int heSo { get; set; }
        public virtual ICollection<LoaiDiem_MonHocEntity>? LoaiDiem_MonHocs { get; set; }
    }
}
