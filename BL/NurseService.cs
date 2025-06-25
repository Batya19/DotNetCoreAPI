using DL.Entities;
using DL;
using BL.InterfacesServices;
using BL.Validation;

namespace BL
{
    public class NurseService : INurseService
    {
        private IDataContext _context;
        public NurseService(IDataContext context)
        {
            _context = context;
        }

        public Nurse GetNurseById(int nurseId)
        {
            NurseValidation.ValidateNurseId(nurseId);
            return _context.Nurses.FirstOrDefault(n => n.Id == nurseId);
        }

        public void AddNurse(Nurse newNurse)
        {
            NurseValidation.ValidateNurseId(newNurse.Id);
            NurseValidation.ValidateNurseName(newNurse.Name);

            _context.Nurses.Add(newNurse);
            _context.SaveChanges();
        }

        public IEnumerable<Nurse> GetAllNurses()
        {
            return _context.Nurses;
        }

        public void RemoveNurse(int id)
        {
            NurseValidation.ValidateNurseId(id);

            var nurse = GetNurseById(id);
            if (nurse != null)
                _context.Nurses.Remove(nurse);
            _context.SaveChanges();
        }

        public void UpdateNurse(int id, string name)
        {
            NurseValidation.ValidateNurseId(id);
            NurseValidation.ValidateNurseName(name);

            var nurse = GetNurseById(id);
            if (nurse != null)
                nurse.Name = name;
            _context.SaveChanges();
        }
    }
}