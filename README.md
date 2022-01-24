[![NuGet Version](https://img.shields.io/nuget/v/atc-azure-options.svg?logo=nuget&style=for-the-badge)](https://www.nuget.org/profiles/atc-net)

## Breaking changes

![](https://img.shields.io/static/v1?color=ff9900&style=for-the-badge&label=&message=Breaking%20changes%20From%20Version%201.x%20to%202.x)

```
    ConfigureKeyVault now requires a parameter of type DefaultAzureCredentialOptions:

    void ConfigureKeyVault(this IConfigurationBuilder config, DefaultAzureCredentialOptions defaultAzureCredentialOptions)
 ```

# ATC Azure Options

Common options library for API's, Functions etc.

# The workflow setup for this repository
[Read more on Git-Flow](https://github.com/atc-net/atc/tree/master/docs/GitFlow.md)

## How to contribute

[Contribution Guidelines](https://atc-net.github.io/introduction/about-atc#how-to-contribute)

[Coding Guidelines](https://atc-net.github.io/introduction/about-atc#coding-guidelines)
