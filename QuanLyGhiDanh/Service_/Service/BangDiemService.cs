using AutoMapper;
using QuanLyGhiDanh.Entitys;
using QuanLyGhiDanh.Models;
using QuanLyGhiDanh.Repository_.Repository;
using QuanLyGhiDanh.Service_.Interface;

namespace QuanLyGhiDanh.Service_.Service
{
    //public interface IBangDiemService
    //{
    //    public Task<ICollection<BangDiemEntity>> GetAll();
    //    //public Task<BangDiemEntity> GetByMaBangDiem(string maMonAn);
    //    //public Task Create(BangDiemModel ma);
    //    //public Task Update(BangDiemModel ma);
    //    //public Task Delete(string ma);

    //}
    public class BangDiemService: IBangDiemService
    {
        private readonly BangDiemRepository _bangDiemRepository;
        private readonly IMapper _mapper;

        public BangDiemService(BangDiemRepository bangDiemRepository, IMapper mapper)
        {
            _bangDiemRepository = bangDiemRepository;
            _mapper = mapper;
        }
        public async Task<ICollection<BangDiemEntity>> GetAll()
        {
            var dsBangDiem = _bangDiemRepository.GetAll();
            return dsBangDiem.ToList();
        }
    }
}
