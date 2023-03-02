using Lab1.Models;
using Lab1.Reponsitory;
using Microsoft.AspNetCore.Mvc;
namespace Lab1.Components
{
    public class LoaiSpMenuViewComponents: ViewComponent
    {
        private readonly ILoaiSPRespository _loaiSp;
        public LoaiSpMenuViewComponents(ILoaiSPRespository loaiSPRespository)
        {
            this._loaiSp = loaiSPRespository;

        }
        public IViewComponentResult Invoke()
        {
            var loaiSp = _loaiSp.getAllLoaiSp().OrderBy(x => x.Loai);
            return View(loaiSp);
        }
    }
}
