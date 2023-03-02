using Lab1.Models;

namespace Lab1.Reponsitory
{
    public class LoaiSPRepository : ILoaiSPRespository
    {
        private readonly QlbanVaLiContext _context;
        public LoaiSPRepository(QlbanVaLiContext context )
        {
            this._context = context;
        }
        public TLoaiSp add(TLoaiSp loaiSp)
        {
            _context.TLoaiSps.Add(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }

        public TLoaiSp delete(string maLoaiSp)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<TLoaiSp> getAllLoaiSp()
        {
            return _context.TLoaiSps;
        }
        public TLoaiSp getLoaiSp(string maLoaiSp)
        {
            return _context.TLoaiSps.Find(maLoaiSp);
        }

        public TLoaiSp update(TLoaiSp loaiSp)
        {
            _context.Update(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }
    }
}
