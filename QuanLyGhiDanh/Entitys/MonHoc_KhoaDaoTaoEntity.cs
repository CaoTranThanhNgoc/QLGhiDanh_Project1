using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("MonHoc_KhoaDaoTao")]
    public class MonHoc_KhoaDaoTaoEntity: Entity
    {
        [ForeignKey("KhoaDaoTao")]
        public string maKhoaDaoTao { get; set; }
        public virtual KhoaDaoTaoEntity? KhoaDaoTao { get; set; }

        [ForeignKey("MonHoc")]
        public string maMonHoc { get; set; }
        public virtual MonHocEntity? MonHoc { get; set; }
    }
}
