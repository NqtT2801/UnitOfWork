using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkPattern.Core.IUnitOfWork;
using UnitOfWorkPattern.Model;

namespace UnitOfWorkPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            user.Id = Guid.NewGuid();
            await _unitOfWork.Users.Add(user);
            await _unitOfWork.CompleteAsync();
            return CreatedAtAction("GetItem", new {user.Id}, user);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(Guid id)
        {
            return Ok(await _unitOfWork.Users.GetById(id));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _unitOfWork.Users.All());
        }
    }
}
