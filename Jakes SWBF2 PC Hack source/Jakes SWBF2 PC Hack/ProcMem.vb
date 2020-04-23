Public Class ProcMem
#Region "Storage"
    Dim Proc As Process()
    Dim PName As String
    Public ProcActive As Boolean, TimerMade
    'Dim CodeCave As New List(Of IntPtr)
    'Dim OldScan As New List(Of String)
#End Region

#Region "API"
    Declare Function WriteProcessMemory Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpBaseAddress As Integer, ByVal buffer As Byte(), ByVal size As Integer, ByVal lpNumberOfBytesWritten As Integer) As Boolean
    Declare Function VirtualAllocEx Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpAddress As Integer, ByVal dwSize As Integer, ByVal flAllocationType As Integer, ByVal flProtect As Integer) As Integer
    Declare Function VirtualFreeEx Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpAddress As Integer, ByVal dwSize As Integer, ByVal dwFreeType As Integer) As Boolean
#End Region

#Region "Get Process"

    Public Sub GetProcess(ByVal ProcessName As String)
        If ProcessName <> String.Empty AndAlso Not TimerMade Then
            PName = If(ProcessName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase), ProcessName.Substring(0, ProcessName.Length - 4), ProcessName)
            MakeTimer(New EventHandler(AddressOf ProcTimer), 500)
            TimerMade = True
        End If
    End Sub

    Private Sub ProcTimer(ByVal sender As Object, ByVal e As EventArgs)
        If (Not ProcActive) Then
            Proc = Process.GetProcessesByName(PName)
            ProcActive = Proc.Length <> 0
        End If
        Try
            ProcActive = Not Proc(0).HasExited
        Catch
            ProcActive = False
        End Try
    End Sub

    Private Sub MakeTimer(ByVal Tmd As EventHandler, ByVal iIntervals As Integer)
        Dim tmr As New Timer
        tmr.Interval = iIntervals
        tmr.Start()
        AddHandler tmr.Tick, New EventHandler(AddressOf Tmd.Invoke)
    End Sub

#End Region

#Region "Allocate"

    Function Allocate() As Integer
        Return If(ProcActive, VirtualAllocEx(Proc(0).Handle, 0, &H200, &H1000, &H40), 0)
    End Function

#End Region

#Region "Deallocate"

    Function DeAllocate(ByVal Address As Integer) As Boolean
        If ProcActive AndAlso Address <> IntPtr.Zero Then
            Return VirtualFreeEx(Proc(0).Handle, Address, 0, &H8000)
        End If
        Return False
    End Function

#End Region

#Region "Write Memory"

    Function WriteBytes(ByVal Address As Integer, ByVal Bytes As Byte()) As Boolean
        Return If(ProcActive, WriteProcessMemory(Proc(0).Handle, Address, Bytes, Bytes.Length, 0), False)
    End Function

    Function WriteBytes(ByVal Address As Integer, ByVal Bytes As String) As Boolean
        Dim byts = HX2Bts(Bytes)
        Return If(ProcActive, WriteProcessMemory(Proc(0).Handle, Address, byts, byts.Length, 0), False)
    End Function

    Function Jmp(ByVal JumpFrom As Integer, ByVal Cave As Integer, ByVal Patched_Bts As String, ByVal DefaultLength As Integer) As Boolean
        If ProcActive Then
            If Cave = 0 Then Return False
            Patched_Bts = TrimSpace(Patched_Bts)
            If WriteBytes(Cave, Patched_Bts + JmpBack(Cave + (Patched_Bts.Length / 2), JumpFrom + DefaultLength)) Then
                WriteBytes(JumpFrom, JmpTo(Cave, JumpFrom, DefaultLength))
            Else
                DeAllocate(Cave)
            End If
        End If
        Return False
    End Function

#End Region

#Region "Misc"

    Private Function HX2Bts(ByVal HXS As String) As Byte()
        HXS = System.Text.RegularExpressions.Regex.Replace(HXS, "[^a-fA-F0-9]", "")
        If HXS.Length Mod 2 <> 0 Then HXS = HXS.Substring(0, HXS.Length - 1)
        Dim buf As Byte() = New Byte((HXS.Length / 2) - 1) {}
        For x = 0 To buf.Length - 1
            buf(x) = Byte.Parse(HXS.Substring(x * 2, 2), System.Globalization.NumberStyles.HexNumber)
        Next
        Return buf
    End Function

    Private Function JmpTo(ByVal Cave As IntPtr, ByVal JumpFrom As Integer, ByVal iLen As Integer) As String
        Dim Ins As String = GetIns(BitConverter.GetBytes(Cave.ToInt32 - JumpFrom - 5))
        For x = 5 To iLen - 1
            Ins += "90"
        Next
        Return "E9" & Ins
    End Function

    Private Function JmpBack(ByVal Cave As Integer, ByVal NextInstruc As Integer) As String
        Return "E9" & GetIns(BitConverter.GetBytes(NextInstruc - Cave - 5))
    End Function

    Private Function GetIns(ByVal BTS As Byte()) As String
        Dim tmp As String = String.Empty
        For x = 0 To BTS.Length - 1
            tmp += String.Format("{0:x2}", BTS(x))
        Next
        Return tmp
    End Function

    Private Function TrimSpace(ByVal txt As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(txt, "\s+", String.Empty)
    End Function

#End Region
End Class
