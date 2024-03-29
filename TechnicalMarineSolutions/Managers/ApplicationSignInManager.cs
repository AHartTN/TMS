namespace TechnicalMarineSolutions.Managers
{
	#region Library Imports

	using System.Security.Claims;
	using System.Threading.Tasks;
	using Microsoft.AspNet.Identity.Owin;
	using Microsoft.Owin;
	using Microsoft.Owin.Security;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class ApplicationSignInManager : SignInManager<User, string>
	{
		public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
			: base(userManager, authenticationManager) {}

		public override Task<ClaimsIdentity> CreateUserIdentityAsync(User user)
		{
			return user.GenerateUserIdentityAsync((ApplicationUserManager) UserManager);
		}

		public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options,
													  IOwinContext context)
		{
			return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
		}
	}
}