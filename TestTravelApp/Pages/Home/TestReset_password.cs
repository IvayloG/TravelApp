using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TravelApp.Pages.Home;

namespace TestTravelApp
{
	[Collection("TravelApp")]
	public class TestReset_password
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Reset_password>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
