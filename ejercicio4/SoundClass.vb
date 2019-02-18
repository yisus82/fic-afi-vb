Public Class SoundClass
    Declare Auto Function PlaySound Lib "winmm.dll" (ByVal name _
       As String, ByVal hmod As Integer, ByVal flags As Integer) As Integer
    ' name specifies the sound file when the SND_FILENAME flag is set.
    ' hmod specifies an executable file handle.
    ' hmod must be Nothing if the SND_RESOURCE flag is not set.
    ' flags specifies which flags are set. 

    ' The PlaySound documentation lists all valid flags.
    Public Const SND_SYNC = &H0          ' play synchronously
    Public Const SND_ASYNC = &H1         ' play asynchronously
    Public Const SND_FILENAME = &H20000  ' name is file name
    Public Const SND_RESOURCE = &H40004  ' name is resource name or atom

    Public Sub PlaySoundFile(ByVal filename As String)
        ' Plays a sound from filename.
        PlaySound(filename, Nothing, SND_FILENAME Or SND_ASYNC)
    End Sub
End Class


