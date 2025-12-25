Namespace Patterns

    Public Class LogFileReader

        Public Iterator Function ReadLog(logFileName As String) As IEnumerable(Of String)
            Using fs As New IO.FileStream(logFileName, IO.FileMode.Open), sr As New IO.StreamReader(fs)
                Do While (sr.Peek <> -1)
                    Dim line As String = sr.ReadLine()
                    Yield line
                Loop
            End Using
        End Function

    End Class

End Namespace