﻿namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class ComponentMap : EntityTypeConfiguration<Component>
	{
		public ComponentMap()
		{
			ToTable("Component", "Asset");

			//MapToStoredProcedures();
		}
	}
}