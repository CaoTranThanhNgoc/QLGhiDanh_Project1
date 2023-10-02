using QuanLyGhiDanh.Entitys;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Models
{
    public class LoaiDiem_MonHocModel
    {      
        public string maLoaiDiem { get; set; }
        public string maMonHoc { get; set; }
        public int soCotDiem { get; set; }
        public int soCotDiemBatBuoc { get; set; }
    }
}
