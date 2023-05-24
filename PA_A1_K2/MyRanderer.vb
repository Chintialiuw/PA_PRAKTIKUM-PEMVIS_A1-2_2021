Public Class MyRenderer
    Inherits ToolStripProfessionalRenderer

    Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
        Dim rc As New Rectangle(Point.Empty, e.Item.Size)

        Dim c As Color
        c = IIf(e.Item.Selected, Color.LightSeaGreen, Color.SeaGreen)  'warna mouse hover dan warna backcolor


        Using brush As New SolidBrush(c)
            e.Graphics.FillRectangle(brush, rc)
        End Using

    End Sub

    Protected Overrides Sub OnRenderButtonBackground(e As ToolStripItemRenderEventArgs)
        Dim rc As New Rectangle(Point.Empty, e.Item.Size)

        Dim c As Color
        c = IIf(e.Item.Selected, Color.LightSeaGreen, Color.SeaGreen)  'warna mouse hover dan warna backcolor

        Using brush As New SolidBrush(c)
            e.Graphics.FillRectangle(brush, rc)
        End Using

    End Sub

End Class