namespace ProductStore.Helpers
{
    public class IdentitySeedSettings
    {
        public required string AdminEmail { get; set; }
        public required string AdminPassword { get; set; }
        public required string[] Roles { get; set; }
    }
}
