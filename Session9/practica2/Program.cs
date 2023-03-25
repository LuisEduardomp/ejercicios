
Imports System
Namespace TextScreen
    Class CenteredText
        Inherits ScreenText
    End Class
End Namespace

Namespace TextScreen
    Class Program
        Private Shared Sub Main(ByVal args As String())
        End Sub
    End Class
End Namespace

Namespace TextScreen
    Class ScreenText
        Protected x, y As Integer
        Protected text As String

        Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal text As String)
            Me.x = x
            Me.y = y
            Me.text = text
        End Sub

        Public Sub SetX(ByVal x As Integer)
            Me.x = x
        End Sub

        Public Sub SetY(ByVal y As Integer)
            Me.y = y
        End Sub

        Public Sub SetText(ByVal text As String)
            Me.text = text
        End Sub

        Public Sub Display()
            Console.SetCursorPosition(x, y)
            Console.Write(text)
        End Sub
    End Class
End Namespace


