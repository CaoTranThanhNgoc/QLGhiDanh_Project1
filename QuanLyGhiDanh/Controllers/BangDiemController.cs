using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuanLyGhiDanh.Service_.Interface;
//using QuanLyGhiDanh.Service_.Service;

namespace QuanLyGhiDanh.Controllers
{
    public class BangDiemController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly IBangDiemService _bangDiemService;
        private readonly IMapper _mapper;
        public BangDiemController(IBangDiemService bangDiemService, IMapper mapper)
        {
            _bangDiemService = bangDiemService;
            _mapper = mapper;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var ds = await _bangDiemService.GetAll();
            return Ok(ds);
        }
    }
}
