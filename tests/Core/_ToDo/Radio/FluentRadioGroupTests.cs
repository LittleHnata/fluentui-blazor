using Bunit;
using Xunit;

namespace Microsoft.FluentUI.AspNetCore.Components.Tests.Radio;
using Bunit;
using Xunit;

public class FluentRadioGroupTests: TestBase
    {
    [Fact]
    public void FluentRadioGroup_Default()
    {
        //Arrange
        string childContent = "<b>render me</b>";
        Microsoft.FluentUI.AspNetCore.Components.Orientation? orientation = default!;
        
        var cut = TestContext.RenderComponent<FluentRadioGroup<bool>>(parameters => parameters
            .Add(p => p.Orientation, orientation)
            .AddChildContent(childContent)
        );
        //Act

        //Assert
		cut.Verify();
    }
}






