namespace Touch.Storage
{
    /// <summary>
    /// IStorage container settings.
    /// </summary>
    public struct StorageSettings
    {
        /// <summary>
        /// Container name.
        /// </summary>
        public string ContainerName;

        /// <summary>
        /// Blob folder name (optional).
        /// </summary>
        public string FolderName;

        /// <summary>
        /// Container has read access for anonymous users.
        /// </summary>
        public bool IsPublic;

        /// <summary>
        /// Domain name, associated with the container.
        /// </summary>
        public string DomainName;

        /// <summary>
        /// Blobs should be stored in reduced redundancy storage.
        /// </summary>
        public bool UseReducedRedundancy;
    }
}
