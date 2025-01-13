using BL;
using BL.InterfacesServices;
using DL.Entities;
using Microsoft.AspNetCore.Mvc;


namespace Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BabyController : ControllerBase
    {
        private readonly IBabyService _babyService;

        public BabyController(IBabyService babyService)
        {
            _babyService = babyService;
        }

        [HttpPost]
        public void CreateBaby([FromBody] Baby baby)
        {
            _babyService.AddBaby(baby.Id, baby.Name, baby.BirthDate);
        }

        [HttpGet("{id}")]
        public Baby GetBaby(int id)
        {
            return _babyService.GetBabyById(id);
        }

        [HttpGet]
        public List<Baby> GetAllBabies()
        {
            return _babyService.GetAllBabies();
        }

        [HttpDelete("{id}")]
        public void RemoveBaby(int id)
        {
            _babyService.RemoveBaby(id);
        }

        [HttpPut("{id}")]
        public void UpdateBaby(int id, [FromBody] Baby updatedBaby)
        {
            _babyService.UpdateBaby(id, updatedBaby.Name, updatedBaby.BirthDate);
        }
    }
}