using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("GiangVien_MonHoc")]
    public class GiangVien_MonHocEntity: Entity
    {
        [ForeignKey("GiangVien")]
        public string maGiangVien { get; set; }
        public virtual GiangVienEntity? GiangVien { get; set; }


        [ForeignKey("MonHoc")]
        public string maMonHoc { get; set; }
        public virtual MonHocEntity? MonHoc { get; set; }
    }
}
