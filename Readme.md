<!-- default file list -->
*Files to look at*:

* [MainWindow.cs](./CS/MainWindow.cs) (VB: [MainWindow.vb](./VB/MainWindow.vb))
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
<!-- default file list end -->
# How to edit WPF types in PropertyGridControl when in different cultures


This example demonstrates how you can configure PropertyGridControl to edit tokenized WPF types (Thickness, CornerRadius etc.).
 
PropertyGridControl does not provide a special editor for editing tokenized WPF types (Thickness, CornerRadius etc.) While editing these types, PropertyGridControl use the default editor - TextEdit. To get an editable string in a generic way, TextEdit calls the ToString() method, which may return a string in the invariant culture. This may produce collisions since PropertyGridControl works with objects in the current culture.
 
There are two ways to resolve these collisions:
1) Set the [PropertyDefinition.UseTypeConverterToStringConversion](https://documentation.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.PropertyDefinition.UseTypeConverterToStringConversion.property) property to "True". When setting this property, PropetyGridControl uses the TypeConverter API to get an editable string before passing it to an editor.
2) Implement a custom TypeConverter with the required conversion logic. With this approach, you will be able to convert values in the invariant culture despite the fact what culture is currently used.
 
This example demonstrates both these approaches. 


