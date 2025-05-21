using Integrity.AI.LangCore.Services;
using Xunit;

public class LangChainAgentTests
{
    [Fact]
    public async Task Validation_ReturnsEmpty_ByDefault()
    {
        var agent = new LangChainAgent();
        var result = await agent.RunValidation("{}");
        Assert.Empty(result);
    }
}
