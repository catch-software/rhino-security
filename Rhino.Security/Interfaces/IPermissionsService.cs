using Rhino.Security.Model;

namespace Rhino.Security.Interfaces
{
	/// <summary>
	/// Allow to retrieve and remove permissions
	/// on users, user groups, entities groups and entities.
	/// </summary>
	public interface IPermissionsService
	{
		/// <summary>
		/// Gets the permissions for the specified user
		/// </summary>
		/// <param name="user">The user.</param>
		/// <returns></returns>
		Permission[] GetPermissionsFor(IUser user);

		/// <summary>
		/// Gets the permissions for the specified user and entity
		/// </summary>
		/// <typeparam name="TEntity">The type of the entity.</typeparam>
		/// <param name="user">The user.</param>
		/// <param name="entity">The entity.</param>
		/// <returns></returns>
		Permission[] GetPermissionsFor<TEntity>(IUser user, TEntity entity) where TEntity : class;

		/// <summary>
		/// Gets the permissions for the specified entity
		/// </summary>
		/// <param name="user">The user.</param>
		/// <param name="operationName">Name of the operation.</param>
		/// <returns></returns>
        Permission[] GetGlobalPermissionsFor(IUser user, string operationName);

        /// <summary>
        /// Gets the permissions for the specified operations
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="operationNames">Names of the operations.</param>
        /// <returns></returns>
        Permission[] GetGlobalPermissionsFor(IUser user, string[] operationNames);

		/// <summary>
		/// Gets all permissions for the specified operation
		/// </summary>
		/// <param name="operationName">Name of the operation.</param>
		/// <returns></returns>
        Permission[] GetPermissionsFor(string operationName);

        /// <summary>
        /// Gets all permissions for the specified operations
        /// </summary>
        /// <param name="operationNames">Names of the operations.</param>
        /// <returns></returns>
        Permission[] GetPermissionsFor(string[] operationNames);

		/// <summary>
		/// Gets the permissions for the specified entity
		/// </summary>
		/// <typeparam name="TEntity">The type of the entity.</typeparam>
		/// <param name="user">The user.</param>
		/// <param name="entity">The entity.</param>
		/// <param name="operationName">Name of the operation.</param>
		/// <returns></returns>
        Permission[] GetPermissionsFor<TEntity>(IUser user, TEntity entity, string operationName) where TEntity : class;

        /// <summary>
        /// Gets the permissions for the specified entity
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="user">The user.</param>
        /// <param name="entity">The entity.</param>
        /// <param name="operationNames">Names of the operations.</param>
        /// <returns></returns>
        Permission[] GetPermissionsFor<TEntity>(IUser user, TEntity entity, string[] operationNames) where TEntity : class;

		/// <summary>
		/// Gets the permissions for the specified entity
		/// </summary>
		/// <typeparam name="TEntity">The type of the entity.</typeparam>
		/// <param name="entity">The entity.</param>
		/// <returns></returns>
		Permission[] GetPermissionsFor<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        /// Gets the permissions for the specified user group
        /// </summary>
        /// <param name="usersGroup">The group.</param>
        /// <param name="operationName">The operation name.</param>
        /// <returns></returns>
	    Permission[] GetPermissionsFor(UsersGroup usersGroup, string operationName);
	}
}
