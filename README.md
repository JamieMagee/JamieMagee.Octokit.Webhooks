# JamieMagee.Octokit.Webhooks

[![GitHub Actions Status](https://github.com/JamieMagee/JamieMagee.Octokit.Webhooks/workflows/Build/badge.svg?branch=main)](https://github.com/JamieMagee/JamieMagee.Octokit.Webhooks/actions)
[![Octokit.Webhooks NuGet Package Downloads](https://img.shields.io/nuget/dt/JamieMagee.Octokit.Webhooks)](https://www.nuget.org/packages/JamieMagee.Octokit.Webhooks)

Libraries to handle GitHub Webhooks in .NET applications

## Usage in ASP.NET Core


1. `dotnet add package JamieMagee.Octokit.Webhooks.AspNetCore`
2. Create a class that derives from `WebhookEventProcessor` and override any of the virtual methods to handle webhooks from GitHub. For example, to handle Pull Request webhooks:

    ```C#
    public sealed class MyWebhookEventProcessor : WebhookEventProcessor
    {
        protected override void ProcessPullRequestMessage(WebhookPayload payload, PullRequestEvent pullRequestEvent, PullRequestAction action)
        {
            ...
        }
    }
    ```

3. Modify your `ConfigureServices()` method to register an implementation for `GitHubEventProcessor`:

    ```C#
    public void ConfigureServices(IServiceCollection services)
    {
        ...
        services.AddSingleton<GitHubEventProcessor, MyGitHubEventProcessor>();
        ...
    }
    ```
4. Modify your `Configure()` method to map the webhook end point:

    ```C#
    app.UseEndpoints(endpoints =>
    {
        ...
        endpoints.MapGitHubWebhook();
        ...
    });
    ```

`MapGitHubWebhook()` takes two optional parameters:

* `pattern`. Defaults to `/github-webhook`, the URL of the end point to use for
  GitHub.
* `secret`. The secret you have configured in GitHub, if you have set this up.

## Thanks

- [octokit/webhooks](https://github.com/octokit/webhooks)
- [terrajobst/Terrajobst.GitHubEvents](https://github.com/terrajobst/Terrajobst.GitHubEvents)

## License

All packages in this repository are licensed under [the MIT license](https://opensource.org/licenses/MIT).
