using DL.Entities;

namespace BL.InterfacesServices
{
    public interface INurseService
    {
        Nurse GetNurseById(int nurseId);       
        void AddNurse(Nurse newNurse);         
        List<Nurse> GetAllNurses();            
        void RemoveNurse(int id);              
        void UpdateNurse(int id, string name); 
    }
}
