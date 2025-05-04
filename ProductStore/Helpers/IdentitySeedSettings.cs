namespace ProductStore.Helpers
{
    /// <summary>
    /// Information used for identity seeding.
    /// </summary>
    public class IdentitySeedSettings
    {
        /// <summary>
        /// Admin email.
        /// </summary>
        public required string AdminEmail { get; set; }

        /// <summary>
        /// Admin password.
        /// </summary>
        public required string AdminPassword { get; set; }

        /// <summary>
        /// Possible users roles.
        /// </summary>
        public required string[] Roles { get; set; }
    }
}
