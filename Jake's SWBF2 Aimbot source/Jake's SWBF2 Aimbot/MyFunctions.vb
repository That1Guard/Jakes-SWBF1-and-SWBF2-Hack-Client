Imports System.Net.NetworkInformation

Module MyFunctions
    Public Function AdjustLength(ByVal Text As String, ByVal RequiredLength As Integer)
        If Text.Length <> RequiredLength Then
            Dim textlength As Integer
            textlength = RequiredLength - Text.Length
            Dim num As Integer = 0
            Dim newtext As String = ""
            While num < textlength
                newtext = "0" & newtext
                num += 1
            End While
            Return Text & newtext
        End If
        Return Text
    End Function
    Public Function HReverseByteString(ByVal Bytes As String)
        Dim num As Integer = 0
        Dim length As Double = Bytes.Length
        length = length / 2
        Dim ipart As Decimal = Math.Truncate(length)
        Dim fpart As Double = length - ipart
        If fpart = 0 Then
            Dim newbytes As String = ""
            Dim length2 As Integer = Bytes.Length
            While num < length2
                newbytes = newbytes & StrReverse(Bytes.Substring(num, 2))
                num += 2
            End While
            newbytes = StrReverse(newbytes)
            Return "&H" & newbytes
        End If
        Return "Byte string not even!"
    End Function
    Public Function ReverseByteString(ByVal Bytes As String)
        Dim num As Integer = 0
        Dim length As Double = Bytes.Length
        length = length / 2
        Dim ipart As Decimal = Math.Truncate(length)
        Dim fpart As Double = length - ipart
        If fpart = 0 Then
            Dim newbytes As String = ""
            Dim length2 As Integer = Bytes.Length
            While num < length2
                newbytes = newbytes & StrReverse(Bytes.Substring(num, 2))
                num += 2
            End While
            newbytes = StrReverse(newbytes)
            Return newbytes
        End If
        Return "Byte string not even!"
    End Function
    Public Function IntegerPart(ByVal Value As Integer)
        Dim ipart As Decimal = Math.Truncate(Value)
        Return ipart
    End Function
    Public Function FractionalPart(ByVal Value As Integer)
        Dim ipart As Decimal = Math.Truncate(Value)
        Dim fpart As Double = Value - ipart
        Return fpart
    End Function
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Public Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short

    End Function
    Public Function ConvertHexToSingle(ByVal hexValue As String) As Single
        Try
            Dim iInputIndex As Integer = 0
            Dim iOutputIndex As Integer = 0
            Dim bArray(3) As Byte
            For iInputIndex = 0 To hexValue.Length - 1 Step 2
                bArray(iOutputIndex) = Byte.Parse(hexValue.Chars(iInputIndex) & hexValue.Chars(iInputIndex + 1), Globalization.NumberStyles.HexNumber)
                iOutputIndex += 1
            Next
            Array.Reverse(bArray)
            Return BitConverter.ToSingle(bArray, 0)
        Catch ex As Exception
            Throw New FormatException("The supplied hex value is either empty or in an incorrect format. Use the following format: 00000000", ex)
        End Try
    End Function
    Public Function ConvertSingleToHex(ByVal SngValue As Single) As String
        Dim tmpBytes() As Byte
        Dim tmpHex As String = ""
        tmpBytes = BitConverter.GetBytes(SngValue)
        For b As Integer = tmpBytes.GetUpperBound(0) To 0 Step -1
            If Hex(tmpBytes(b)).Length = 1 Then tmpHex += "0" '0..F -> 00..0F 
            tmpHex += Hex(tmpBytes(b))
        Next
        Return tmpHex
    End Function
End Module
