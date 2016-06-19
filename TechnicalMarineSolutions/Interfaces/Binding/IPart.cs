﻿namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface IPart
		: IBaseModel,
		  IManufacturerable,
		  ICategorizable,
		  IRetailItem,
		  ICost,
		  IQuantity,
		  IName,
		  ITitle,
		  IDescription,
		  INote,
		  IManyAppointmentable,
		  IManyComponentable,
		  IManyEngineable,
		  IManyImageable,
		  IManyInventoryable,
		  IManyPartOrderItemable,
		  IManyProjectable,
		  IManyStepable,
		  IManyVehicleable
	{ }
}