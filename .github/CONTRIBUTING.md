# Contributing to SpectriumLive.Styles

Thank you for your interest in contributing to **SpectriumLive.Styles**! We welcome contributions to make these WPF styles and themes even better.

## Ways to Contribute

- **Report Bugs**: If you find an issue with control styling, visual states, or theme switching, please [open a bug report](https://github.com/Dudziak07/SpectriumLive.Styles/issues/new?template=bug_report.yml).
- **Suggest Features**: Have an idea for a new control template, style, or theme enhancement? [Submit a feature request](https://github.com/Dudziak07/SpectriumLive.Styles/issues/new?template=feature_request.yml).
- **Submit Pull Requests**: Fixes, theme improvements, or new control styles are always welcome.

## Development Workflow

### Prerequisites
- Windows 10 or 11
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Visual Studio 2022+ / JetBrains Rider / VS Code

### Building Locally
1. Clone the repository:
   ```bash
   git clone https://github.com/Dudziak07/SpectriumLive.Styles.git
   cd SpectriumLive.Styles
   ```
2. Build the solution:
   ```bash
   dotnet build SpectriumLive.Styles.sln --configuration Release
   ```
3. Create the NuGet package locally:
   ```bash
   dotnet pack SpectriumLive.Styles/SpectriumLive.Styles.csproj --configuration Release
   ```

### Code Guidelines
- **Zero Warnings**: Builds must complete with 0 errors and 0 warnings.
- **Pure XAML & Native WPF**: Avoid adding external third-party library dependencies.
- **Dual-Theme Support**: Any new control style must support both **DarkTheme** and **LightTheme** resource keys seamlessly.
- **Conventional Commits**: Use conventional commits format for commit messages (`feat: ...`, `fix: ...`, `chore: ...`).

## Pull Request Process

1. Fork the repo and create your feature branch: `git checkout -b feat/my-new-style`.
2. Make your changes and verify that the build succeeds without warnings.
3. Commit using conventional commit format.
4. Push to your branch and submit a Pull Request targeting `main`.
