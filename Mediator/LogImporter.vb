Namespace Patterns

    ''' <summary>
    ''' Определяет интерфейс посредника.
    ''' Содержит логику взаимодействия независимых классов <see cref="LogFileReader"/> и <see cref="LogSaver"/>.
    ''' </summary>
    ''' <remarks>
    ''' Посредник также м/б неявным, когда независимые классы взаимодействуют с посредником через события.
    ''' </remarks>
    Public Class LogImporter

        'Это классы, которые надо связать. Они не знают о посреднике.
        Private ReadOnly Reader As New LogFileReader
        Private ReadOnly Saver As New LogSaver

        ''' <summary>
        ''' Логика обработки данных из независимых несвязанных классов.
        ''' </summary>
        Public Sub ImportLog(logFileName As String)
            For Each entry In Reader.ReadLog(logFileName)
                Saver.SaveLogEntry(entry)
            Next
        End Sub

    End Class

End Namespace