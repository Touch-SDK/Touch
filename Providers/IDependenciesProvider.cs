namespace Touch.Providers
{
    /// <summary>
    /// Dependencies provider.
    /// </summary>
    public interface IDependenciesProvider
    {
        /// <summary>
        /// Resolve a dependency.
        /// </summary>
        T Resolve<T>() where T : class;
    }
}
