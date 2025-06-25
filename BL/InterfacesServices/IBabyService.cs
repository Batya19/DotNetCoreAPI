using DL.Entities;

namespace BL.InterfacesServices
{
    public interface IBabyService
    {
        void AddBaby(int id, string name, DateTime birthDate);
        Baby GetBabyById(int id);
        IEnumerable<Baby> GetAllBabies();
        void RemoveBaby(int id);
        void UpdateBaby(int id, string name, DateTime birthDate);
    }
}
