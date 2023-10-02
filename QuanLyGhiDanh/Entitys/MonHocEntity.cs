using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("MonHoc")]
    public class MonHocEntity: Entity
    {
        [Key]
        public string maMonHoc { get; set; }
        public string tenMonHoc { get; set; }

        [ForeignKey("ToBoMon")]
        public string maBoMon { get; set; }
        public virtual ToBoMonEntity? ToBoMon { get; set; }

        //[ForeignKey("KhoaKhoi")]
        //public string maKhoa { get; set; }
        //public virtual KhoaKhoiEntity? KhoaKhoi { get; set; }

        //[ForeignKey("KhoaDaoTao")]
        //public string maKhoaDaoTao { get; set; }
        //public virtual KhoaDaoTaoEntity? KhoaDaoTao { get; set; }


        public virtual ICollection<MonHoc_KhoaDaoTaoEntity>? MonHoc_KhoaDaoTaos { get; set; }
        public virtual ICollection<MonHoc_LopHocEntity>? MonHoc_LopHocs { get; set; }
        public virtual ICollection<LoaiDiem_MonHocEntity>? LoaiDiem_MonHocs { get; set; }
        public virtual ICollection<PhanCongGiangDayEntity>? PhanCongGiangDays { get; set; }
        public virtual ICollection<GiangVien_MonHocEntity>? GiangVien_MonHocs { get; set; }

    }
}
