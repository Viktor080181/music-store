﻿using music_store.Models.Domains;
using music_store.Models.Entities;

namespace music_store.Services.Interfaces
{
	public interface IUserService
	{
		public bool AddUser(User user);

		public User? FindUser(User user);

		public bool DeleteUser(User user);

		/*! 
		 * @brief Hashes a password with SHA3-512 and appends a predefined salt, then hashes the resulting string.
		 * @param[in] password The plain text password to be hashed.
		 * @return The final hashed password as a hexadecimal string.
		 */
		public string HashString(string password);
        /*! 
		* @brief Buying a record, charging money from the user's balance.
		* @param[in] vinylRecord - purchasable record.
		* @param[in] user - record buyer.
		* @return True - record purchased; False - record not purchased.
		*/
        public bool BuyVinylRecord(User user, VinylRecord vinylRecord);

		/*! 
		* @brief Checking the presence of a user in the database.
		* @param[in] user - whose data is being verified.
		* @return True - user login matches; False - user login not matches.
		*/
		public bool IdentificationUser(DTOUser domainUser);

		public bool Registration(string login, string password);
	}
}