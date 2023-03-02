using Lab1.Models;
namespace Lab1.Reponsitory
{
    public interface ILoaiSPRespository
    {
        TLoaiSp add(TLoaiSp loaiSp);
        TLoaiSp update(TLoaiSp loaiSp);
        TLoaiSp delete(String maLoaiSp);
        TLoaiSp getLoaiSp(String maLoaiSp);

        IEnumerable<TLoaiSp> getAllLoaiSp();

    }
}
