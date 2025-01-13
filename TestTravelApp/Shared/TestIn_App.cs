using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TravelApp.Shared;

namespace TestTravelApp
{
	[Collection("TravelApp")]
	public class TestIn_App
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbAvatarModule),
				typeof(IgbNavDrawerModule));
			var componentUnderTest = ctx.RenderComponent<In_App>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
