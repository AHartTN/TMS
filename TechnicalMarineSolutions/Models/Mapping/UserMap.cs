﻿namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class UserMap : EntityTypeConfiguration<User>
	{
		public UserMap()
		{
			ToTable("AspNetUsers", "dbo");

			MapToStoredProcedures();
		}
	}
}