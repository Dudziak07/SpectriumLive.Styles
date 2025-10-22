# SpectriumLive.Styles
<p align="center"> <a href="https://www.nuget.org/packages/SpectriumLive.Styles/"> <img src="https://img.shields.io/nuget/v/SpectriumLive.Styles?style=flat-square&logo=nuget" alt="NuGet Version"> </a> <a href="https://www.nuget.org/packages/SpectriumLive.Styles/"> <img src="https://img.shields.io/nuget/dt/SpectriumLive.Styles?style=flat-square&logo=nuget" alt="NuGet Downloads"> </a> <a href="https://github.com/Dudziak07/SpectriumLive.Styles/blob/main/LICENSE.txt"> <img src="https://img.shields.io/github/license/Dudziak07/SpectriumLive.Styles?style=flat-square" alt="License"> </a>

<a href="https://github.com/Dudziak07/SpectriumLive.Styles"> <img src="https://img.shields.io/badge/Repo-SpectriumLive.Styles-blue?style=flat-square&logo=github" alt="GitHub Repository"> </a> <a href="https://github.com/Dudziak07/SpectriumLive.Styles/stargazers"> <img src="https://img.shields.io/github/stars/Dudziak07/SpectriumLive.Styles?style=flat-square&logo=github" alt="GitHub Stars"> </a>

<a href="https://github.com/Dudziak07"> <img src="https://img.shields.io/badge/Author-Dudziak07-purple?style=flat-square&logo=github" alt="Author Profile"> </a> </p>

A sleek, modern, and reusable WPF style library. Originally developed for the SpectriumLive application, these styles are designed to be lightweight and easily integrated into any .NET WPF project to provide a clean and consistent look and feel.

## ✨ Features
Modern Design: A clean, minimalist aesthetic for common controls.

- **Themed:** Includes standard Light and Dark themes.
- **Reusable:** Drop them into any WPF application.
- **Lightweight:** Just pure XAML styles, no heavy dependencies.
- **Easy to Use:** Get up and running with just a few lines of XAML.

## 🚀 Installation
You can easily install this package from NuGet.org or (potentially) GitHub Packages.

### 1. NuGet (Recommended)
Use the .NET CLI or the NuGet Package Manager Console.

- .NET CLI
```
dotnet add package SpectriumLive.Styles
```
- Package Manager Console
```
Install-Package SpectriumLive.Styles
```

### 2. GitHub Packages
This package may also be available via [GitHub Packages](https://github.com/Dudziak07/SpectriumLive.Styles/pkgs/nuget/SpectriumLive.Styles). Follow the instructions there to configure your client.

## ⚙️ Usage: How to Apply Styles
To apply the styles, you must merge two resource dictionaries into your App.xaml:

- A Theme: Choose LightTheme.xaml or DarkTheme.xaml.
- Global Styles: Add GlobalStyles.xaml.

Merge them in your App.xaml file as shown below.
```
<Application x:Class="YourApp.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/SpectriumLive.Styles;component/Themes/DarkTheme.xaml"/>
                <ResourceDictionary Source="pack://application:,,,/SpectriumLive.Styles;component/Styles/GlobalStyles.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```
That's it! The chosen theme and global styles will now be applied to all standard controls in your application.

## 🤝 Contributing
Contributions, issues, and feature requests are welcome! Feel free to check the [Issues Page](https://github.com/Dudziak07/SpectriumLive.Styles/issues).

## 📄 License
This project is licensed under the terms of the license specified in [LICENSE.txt](LICENSE.txt).
