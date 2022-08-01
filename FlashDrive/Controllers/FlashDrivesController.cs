using FlashDrive.BusinessLogic.Services.Interfaces;
using FlashDrive.Model.DatabaseModels;
using Microsoft.AspNetCore.Mvc;

namespace FlashDrive.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashDrivesController : ControllerBase
    {
        private readonly IFlashDriveService _flashDriveService;
        public FlashDrivesController(IFlashDriveService flashDriveService) => _flashDriveService = flashDriveService;
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _flashDriveService.Get(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post(Flash_Drive flashDrive) =>
            _flashDriveService.Create(flashDrive) ? Ok("Flash drive has been created") : BadRequest("Flash drive not created");

        [HttpPut]
        public IActionResult Put(Flash_Drive flashDrive) =>
            _flashDriveService.Update(flashDrive) ? Ok("Flash drive has been updated") : BadRequest("Flash drive not updated");

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>
            _flashDriveService.Delete(id) ? Ok("Flash drive has been removed") : BadRequest("Flash drive not deleted");
    }
}
