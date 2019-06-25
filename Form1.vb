Imports EditShape
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1

    Private Sub Add(ByVal shape As shpShape)
        ShpCanvas1.Shapes.Add(shape)
        ShpCanvas1.Invalidate()
    End Sub

    Private Sub ShpCanvas1_SelectedShapeChanged(sender As Object, e As EventArgs) Handles ShpCanvas1.SelectedShapeChanged
        Dim s As shpShape = ShpCanvas1.SelectedShape
        propertyGrid1.SelectedObject = s
    End Sub

    Private Sub addEllipseButton_Click(sender As Object, e As EventArgs) Handles addEllipseButton.Click
        Me.Add(New shpCircle(Point.Empty))
    End Sub
End Class
