using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TravelApp.Shared;

namespace TestTravelApp
{
	[Collection("TravelApp")]
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
