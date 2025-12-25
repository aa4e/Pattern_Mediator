Module Module1

    ''' <summary>
    ''' Паттерн посредник (Mediator). Связывает несколько независимых классов между собой.
    ''' </summary>
    Sub Main()

        Dim imp As New Patterns.LogImporter()
        imp.ImportLog("TextFile1.txt")

        Console.ReadKey()

    End Sub

End Module