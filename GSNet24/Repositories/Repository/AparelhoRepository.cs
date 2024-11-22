using GSNet24.Context;
using GSNet24.Model;
using GSNet24.Repositories.Interface;

namespace GSNet24.Repositories.Repository
{
    public class AparelhoRepository : IAparelhoRepository
    {

        private readonly AppContextDb _context;

        public AparelhoRepository(AppContextDb context)
        {
            _context = context;
        }

        public AparelhoModel Add(AparelhoModel model)
        {
            _context.Aparelho.Add(model);
            _context.SaveChanges();
            return model;
        }

        public bool Delete(int id)
        {
            bool status = false;

            try
            {
                var ende = _context.Aparelho.Find(id);

                if (ende != null)
                {
                    _context.Aparelho.Remove(ende);
                    _context.SaveChanges();

                }
                status = true;
            }
            catch { }
            return status;
        }

        public AparelhoModel Get(int id)
        {
            var ende = _context.Aparelho.FirstOrDefault(m => m.AparelhoId == id);
            return ende;
        }

        public IEnumerable<AparelhoModel> List()
        {
            return _context.Aparelho.ToList();
        }

        public AparelhoModel Update(AparelhoModel model)
        {
            _context.Aparelho.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
