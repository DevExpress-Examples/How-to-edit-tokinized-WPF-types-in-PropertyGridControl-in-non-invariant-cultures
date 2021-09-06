<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/181028374/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830422)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.vb](./VB/MainWindow.xaml.vb))
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
<!-- default file list end -->
# How to edit tokinized WPF types in PropertyGridControl in non-invariant cultures


This example demonstrates how you can configure PropertyGridControl to edit tokenized WPF types (Thickness, CornerRadius etc.).
 
PropertyGridControl does not provide a special editor for editing tokenized WPF types (Thickness, CornerRadius etc.) While editing these types, PropertyGridControl use the default editor - TextEdit. To get an editable string in a generic way, TextEdit calls the ToString() method, which may return a string in the invariant culture. This may produce collisions since PropertyGridControl works with objects in the current culture.
 
There are two ways to resolve these collisions:
1) Set the [PropertyDefinition.UseTypeConverterToStringConversion](https://documentation.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.PropertyDefinition.UseTypeConverterToStringConversion.property) property to "True". When setting this property, PropetyGridControl uses the TypeConverter API to get an editable string before passing it to an editor.
2) Implement a custom TypeConverter with the required conversion logic. With this approach, you will be able to convert values in the invariant culture despite the fact what culture is currently used.
 
This example demonstrates both these approaches. 


