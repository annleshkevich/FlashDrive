namespace FlashDrive.Model.DatabaseModels
{
    public class Flash_Drive
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double MemoryCapacity { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
    }
}