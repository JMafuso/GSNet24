using GSNet24.Model;

namespace GSNet24.Repositories.Interface
{
    public interface IAparelhoRepository
    {

        AparelhoModel Get(int id);

        AparelhoModel Add(AparelhoModel model);

        IEnumerable<AparelhoModel> List();

        AparelhoModel Update(AparelhoModel model);

        bool Delete(int id);
    }
}