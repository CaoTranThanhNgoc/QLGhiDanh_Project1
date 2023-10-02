using QuanLyGhiDanh.Entitys;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Models
{
    public class LichHocModel
    {
        public string maLichHoc { get; set; }
        public string tenLichHoc { get; set; }
        public string maLopHoc { get; set; }        
    }
}
