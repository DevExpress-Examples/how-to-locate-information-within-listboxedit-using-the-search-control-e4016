Imports Microsoft.VisualBasic
Imports System.Windows.Controls

Namespace ListBoxFilteringUsingSearchPanel
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			listBox.ItemsSource = Stuff.GetStuff()
		End Sub
	End Class
End Namespace
