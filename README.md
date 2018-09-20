# WindowsMarkupExtensions
Windows Markup Extensions for UWP apps

Get it on nuget:
```
   PM> Install-Package WindowsMarkupExtensions 
```

The **OnDevice** markup extension can be used for DeviceFamily specific property values. 
It is inspired on the OnPlatform/OnIdiom markup extensions from Xamarin.Forms 3.2, 
see https://github.com/xamarin/Xamarin.Forms/issues/2608

```
<Page
    x:Class="TestApp.MainPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d"
    xmlns:wme="using:ReflectionIT.WindowsMarkupExtensions"
    Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">

    <Grid>
        <TextBlock Text="{wme:OnDevice Desktop=Hello, Xbox=World}"
                   FontSize="{wme:OnDevice Team=42, Default=21}" 
                   HorizontalAlignment="Center" 
                   VerticalAlignment="Center"/>
    </Grid>
</Page>
```

Run the test app to see it in use.
