﻿#region Library Imports

using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IUserInfoable
	{
		long UserInfoId
		{
			get;
			set;
		}

		User UserInformation
		{
			get;
			set;
		}
	}
}