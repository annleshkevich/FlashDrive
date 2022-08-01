using FlashDrive.Model.DatabaseModels;

namespace FlashDrive.BusinessLogic.Services.Interfaces
{
    public interface IFlashDriveService
    {
        IEnumerable<Flash_Drive> Get();
        Flash_Drive Get(int id);
        bool Create(Flash_Drive flashDrive);
        bool Update(Flash_Drive flashDrive);
        bool Delete(int id);
    }
}
