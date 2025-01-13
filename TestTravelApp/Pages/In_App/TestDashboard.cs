using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TravelApp.Pages.In_App;

namespace TestTravelApp
{
	[Collection("TravelApp")]
	public class TestDashboard
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbListModule));
			var componentUnderTest = ctx.RenderComponent<Dashboard>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
