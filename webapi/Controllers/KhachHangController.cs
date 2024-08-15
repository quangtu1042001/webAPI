using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using webapi.MyModels;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        MyDbContext dbc;
        public KhachHangController(MyDbContext dbc_in)
        {
            dbc = dbc_in;
        }
        [HttpGet]
        [Route("/Khachhang/GetList")]
        public ActionResult Read()
        {
            return Ok(new { data = dbc.Khachhangs.ToList() });
        }
        [HttpPost]
        [Route("/DonHang/SearchByKhachHangId")]
        public ActionResult TimKiemDonHangTheoKhachHangId([FromQuery] int khachHangId)
        {
            // Tìm tất cả các đơn hàng có KhachHangId trùng với khachHangId được truyền vào
            var donHangs = dbc.DonHangs
                              .Where(dh => dh.KhachhangId == khachHangId)
                              .ToList();

            // Nếu không tìm thấy đơn hàng nào, trả về mã 404
            if (donHangs == null || !donHangs.Any())
            {
                return NotFound(new { message = "Không tìm thấy đơn hàng nào cho khách hàng này." });
            }

            // Trả về danh sách đơn hàng tìm được
            return Ok(new { data = donHangs });
        }

    }

}

