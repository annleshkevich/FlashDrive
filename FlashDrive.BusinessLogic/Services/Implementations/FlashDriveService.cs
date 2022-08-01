using FlashDrive.BusinessLogic.Services.Interfaces;
using FlashDrive.Model;
using FlashDrive.Model.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace FlashDrive.BusinessLogic.Services.Implementations
{
    public class FlashDriveService : IFlashDriveService
    {
        private readonly ApplicationContext _db;
        public FlashDriveService(ApplicationContext context) =>
            _db = context;
        public bool Create(Flash_Drive flashDrive)
        {
            _db.FlashDrives.Add(flashDrive);
            return Save();
        }
        public bool Delete(int id)
        {
            var flashDrive = _db.FlashDrives.FirstOrDefault(c => c.Id == id);
            if (flashDrive == null)
                return false;
            _db.FlashDrives.Remove(flashDrive);
            return Save();
        }
        public IEnumerable<Flash_Drive> Get() =>
            _db.FlashDrives.AsNoTracking().ToList();

        public Flash_Drive Get(int id) =>
            _db.FlashDrives.AsNoTracking().FirstOrDefault(c => c.Id == id);
        public bool Update(Flash_Drive flashDrive)
        {
            _db.Update(flashDrive);
            return Save();
        }
        public bool Save()
        {
            var saved = _db.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}