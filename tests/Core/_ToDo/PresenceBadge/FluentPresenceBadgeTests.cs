using Bunit;
using Xunit;

namespace Microsoft.Fast.Components.FluentUI.Tests.PresenceBadge;
public class FluentPresenceBadgeTests : TestBase
{
    [Fact(Skip = "Need to figure out how to do this test")]
    public void FluentPresenceBadge_Default()
    {
        //Arrange
        //Services.AddSingleton<GlobalState,/*Add implementation for GlobalState*/>();
        string childContent = "<b>render me</b>";
        string title = default!;
        Microsoft.Fast.Components.FluentUI.PresenceStatus? status = default!;
        string statusTitle = default!;
        bool outOfOffice = default!;
        Microsoft.Fast.Components.FluentUI.PresenceBadgeSize size = default!;
        var cut = TestContext.RenderComponent<FluentPresenceBadge>(parameters => parameters
            .AddChildContent(childContent)
            .Add(p => p.Title, title)
            .Add(p => p.Status, status)
            .Add(p => p.StatusTitle, statusTitle)
            .Add(p => p.OutOfOffice, outOfOffice)
            .Add(p => p.Size, size)
        );
        //Act

        //Assert
		cut.Verify();
    }
}






