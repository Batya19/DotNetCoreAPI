using BL.InterfacesServices;
using BL.Validation;
using DL;
using DL.Entities;

namespace BL
{
    public class BabyService : IBabyService
    {
        private IDataContext _context;
        
        public BabyService(IDataContext context)
        {
            _context = context;
        }

        public void AddBaby(int id, string name, DateTime birthDate)
        {
            BabyValidation.ValidateBabyId(id);
            BabyValidation.ValidateBabyName(name);
            var baby = new Baby { Id = id, Name = name, BirthDate = birthDate };
            _context.Babies.Add(baby);
            _context.SaveChanges();
        }

        public Baby GetBabyById(int id)
        {
            BabyValidation.ValidateBabyId(id);

            return _context.Babies.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Baby> GetAllBabies()
        {
            return _context.Babies;
        }

        public void RemoveBaby(int id)
        {
            BabyValidation.ValidateBabyId(id);

            var baby = GetBabyById(id);
            if (baby != null)
                _context.Babies.Remove(baby);
            _context.SaveChanges();
        }

        public void UpdateBaby(int id, string name, DateTime birthDate)
        {
            BabyValidation.ValidateBabyId(id);
            BabyValidation.ValidateBabyName(name);

            var baby = GetBabyById(id);
            if (baby != null)
            {
                baby.Name = name;
                baby.BirthDate = birthDate;
            }
            _context.SaveChanges();
        }
    }
}
