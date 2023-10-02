using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("MonHoc_LopHoc")]
    public class MonHoc_LopHocEntity: Entity
    {
        [ForeignKey("LopHoc")]
        public string maLopHoc { get; set; }
        public virtual LopHocEntity? LopHoc { get; set; }


        [ForeignKey("MonHoc")]
        public string maMonHoc { get; set; }
        public virtual MonHocEntity? MonHoc { get; set; }
    }
}
