namespace Selenium.WebDriver.Extensions.IntegrationTests.FirefoxTests
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using Selenium.WebDriver.Extensions.IntegrationTests.Fixtures;
    using Selenium.WebDriver.Extensions.IntegrationTests.Tests;
    using Xunit;

    [Trait("Category", "Integration")]
    [Trait("Browser", "Firefox")]
    [ExcludeFromCodeCoverage]
    [Collection("Integration")]
    public class WebDriverExtensionsJQueryLoadedSelectorFirefoxTests :
        WebDriverExtensionsJQuerySelectorTests, IClassFixture<FirefoxFixture>
    {
        public WebDriverExtensionsJQueryLoadedSelectorFirefoxTests(FixtureBase fixture)
        {
            Browser = fixture.Browser;
            Browser.Navigate().GoToUrl(new Uri($"{ServerUrl}/JQueryLoaded"));
        }
    }
}