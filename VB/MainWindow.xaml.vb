Imports System.Windows
Imports DevExpress.Mvvm
Imports System.Globalization
Imports System.Threading
Imports System.ComponentModel
Imports System

Namespace DXSample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			Thread.CurrentThread.CurrentCulture = New CultureInfo("de-De")
			Thread.CurrentThread.CurrentUICulture = New CultureInfo("de-De")

			InitializeComponent()
			DataContext = New SelectedObject() With {.BorderThickness = New Thickness()}
		End Sub
	End Class
	Public Class SelectedObject
		Inherits BindableBase

		<TypeConverter(GetType(CustomThicknessConverter))>
		Public Property BorderThickness() As Thickness
			Get
				Return GetProperty(Function() BorderThickness)
			End Get
			Set(ByVal value As Thickness)
				SetProperty(Function() BorderThickness, value)
			End Set
		End Property
		Public Property Radius() As CornerRadius
			Get
				Return GetProperty(Function() Radius)
			End Get
			Set(ByVal value As CornerRadius)
				SetProperty(Function() Radius, value)
			End Set
		End Property
	End Class

	Friend Class CustomThicknessConverter
		Inherits ThicknessConverter

        Public Overrides Function ConvertFrom(ByVal typeDescriptorContext As ITypeDescriptorContext, ByVal cultureInfo As CultureInfo, ByVal source As Object) As Object
            Return MyBase.ConvertFrom(typeDescriptorContext, CultureInfo.InvariantCulture, source)
        End Function

        Public Overrides Function ConvertTo(ByVal typeDescriptorContext As ITypeDescriptorContext, ByVal cultureInfo As CultureInfo, ByVal value As Object, ByVal destinationType As Type) As Object
            Return MyBase.ConvertTo(typeDescriptorContext, CultureInfo.InvariantCulture, value, destinationType)
        End Function
	End Class
End Namespace
