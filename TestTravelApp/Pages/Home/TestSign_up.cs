using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TravelApp.Pages.Home;

namespace TestTravelApp
{
	[Collection("TravelApp")]
	public class TestSign_up
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbCheckboxModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Sign_up>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
