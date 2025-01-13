using Microsoft.AspNetCore.Mvc;
using BL;
using DL.Entities;
using BL.InterfacesServices;

namespace Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NurseController : ControllerBase
    {
        private INurseService _nurseService;

        public NurseController(INurseService nurseService)
        {
            _nurseService = nurseService;
        }

        [HttpPost]
        public void CreateNurse([FromBody] Nurse nurse)
        {
            _nurseService.AddNurse(nurse);
        }

        [HttpGet("{id}")]
        public Nurse GetNurse(int id)
        {
            var nurse = _nurseService.GetNurseById(id);
            return nurse;
        }

        [HttpGet]
        public List<Nurse> GetAllNurses()
        {
            return _nurseService.GetAllNurses();
        }

        [HttpDelete("{id}")]
        public void RemoveNurse(int id)
        {
            _nurseService.RemoveNurse(id);
        }

        [HttpPut("{id}")]
        public void UpdateNurse(int id, [FromBody] Nurse updatedNurse)
        {
            _nurseService.UpdateNurse(id, updatedNurse.Name);
        }
    }
}