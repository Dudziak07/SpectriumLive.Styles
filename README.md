# SpectriumLive.Styles

<p align="center">
  <a href="https://www.nuget.org/packages/SpectriumLive.Styles/"><img src="https://img.shields.io/nuget/v/SpectriumLive.Styles?style=flat-square&logo=nuget" alt="NuGet Version"></a>
  <a href="https://www.nuget.org/packages/SpectriumLive.Styles/"><img src="https://img.shields.io/nuget/dt/SpectriumLive.Styles?style=flat-square&logo=nuget" alt="NuGet Downloads"></a>
  <a href="https://dotnet.microsoft.com/"><img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet" alt=".NET 10.0"></a>
  <a href="https://github.com/Dudziak07/SpectriumLive.Styles/actions/workflows/publish.yml"><img src="https://img.shields.io/github/actions/workflow/status/Dudziak07/SpectriumLive.Styles/publish.yml?branch=main&style=flat-square&label=Publish" alt="Build Status"></a>
  <a href="https://github.com/Dudziak07/SpectriumLive.Styles/blob/main/LICENSE.txt"><img src="https://img.shields.io/badge/License-MIT-green?style=flat-square" alt="License"></a>
  <a href="https://github.com/Dudziak07"><img src="https://img.shields.io/badge/Author-Filip%20Dudziec-purple?style=flat-square&logo=github" alt="Author Profile"></a>
</p>

A sleek, lightweight, and modern WPF style library for .NET desktop applications. Originally crafted for the **SpectriumLive** application, these styles provide a consistent, dark/light themed, minimalist UI with zero external dependencies.

---

## ✨ Features

- 🎨 **Dual Themes:** Complete out-of-the-box support for both **Dark** and **Light** themes.
- ⚡ **Lightweight & Fast:** Pure XAML and native WPF styling without bulky third-party dependencies.
- 🔄 **Runtime Switching:** Seamlessly swap themes dynamically in code without restarting the application.
- 🧩 **Pre-styled Controls:**
  - **Buttons & RepeatButtons** (hover, pressed, and focus visual states)
  - **Menus & ContextMenus** (modern popups, submenus, checkmarks, separators, custom placement)
  - **ScrollBars & ScrollViewer** (thin, clean modern scrollbars and thumbs)
  - **Sliders** (custom track geometry and draggable thumb)
  - **ComboBoxes** (flat, consistent drop-down controls)
  - **Built-in Converters** (`BooleanToVisibilityConverter`, `MenuPlacementConverter`, `MenuArrowVisibilityConverter`)
- 🚀 **Targeting .NET 10:** Built and optimized for .NET 10 Windows Desktop (*.NET 9 is supported via versions `<= 1.11.0`*).

---

## 🚀 Installation

Install the package via NuGet:

### .NET CLI
```bash
dotnet add package SpectriumLive.Styles
```

### Package Manager Console
```powershell
Install-Package SpectriumLive.Styles
```

### PackageReference (csproj)
```xml
<PackageReference Include="SpectriumLive.Styles" Version="1.11.1" />
```

---

## ⚙️ Usage: How to Apply Styles

Merge the chosen theme and `GlobalStyles.xaml` in your `App.xaml`:

```xml
<Application x:Class="YourApp.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <!-- 1. Choose Theme: DarkTheme.xaml or LightTheme.xaml -->
                <ResourceDictionary Source="pack://application:,,,/SpectriumLive.Styles;component/Themes/DarkTheme.xaml" />
                <!-- 2. Global Styles: controls styling and templates -->
                <ResourceDictionary Source="pack://application:,,,/SpectriumLive.Styles;component/Styles/GlobalStyles.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

---

## 🌗 Switching Themes Dynamically in C#

You can easily switch between Light and Dark themes at runtime:

```csharp
public static void SetTheme(bool isDark)
{
    var themeUri = isDark
        ? new Uri("pack://application:,,,/SpectriumLive.Styles;component/Themes/DarkTheme.xaml")
        : new Uri("pack://application:,,,/SpectriumLive.Styles;component/Themes/LightTheme.xaml");

    var appResources = Application.Current.Resources.MergedDictionaries;
    var currentTheme = appResources.FirstOrDefault(d => 
        d.Source != null && (d.Source.OriginalString.Contains("DarkTheme.xaml") || d.Source.OriginalString.Contains("LightTheme.xaml")));

    if (currentTheme != null)
    {
        appResources.Remove(currentTheme);
    }

    appResources.Insert(0, new ResourceDictionary { Source = themeUri });
}
```

---

## 📋 Compatibility

| SpectriumLive.Styles Version | Target Framework | Windows OS |
| :--- | :--- | :--- |
| **`>= 1.11.1`** | **.NET 10.0** (`net10.0-windows`) | Windows 10+ (x64, arm64, x86) |
| **`1.11.0`** | **.NET 10.0** & **.NET 9.0** | Windows 10+ |
| **`1.10.x`** | **.NET 9.0** (`net9.0-windows`) | Windows 10+ |

---

## 🤝 Contributing

Contributions, issues, and feature requests are welcome! Feel free to check the [Issues Page](https://github.com/Dudziak07/SpectriumLive.Styles/issues).

---

## 📄 License

This project is licensed under the terms of the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

Copyright (c) 2025-2026 Filip Dudziec
