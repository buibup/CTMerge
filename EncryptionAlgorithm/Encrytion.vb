Public Class Encrytion

    Public Function ENCRYPTPWD(ByVal X) As String
        Dim xconst As Int16 = 37
        Dim xout As String = ""
        Dim xpiece As Int16 = 0
        Dim xchar As String
        Dim xnum As Decimal
        For xpiece = 0 To X.Length - 1
            xchar = X.Substring(xpiece, 1)
            If xchar = "D" Then xchar = Chr(2)
            If xchar = "p" Then xchar = Chr(3)
            If xchar = "d" Then xchar = Chr(4)
            If xchar = "t" Then xchar = Chr(5)
            xnum = Asc(xchar)
            xnum = (xnum - (xpiece + 1) + xconst) Mod 255
            If xnum > 127 Then xnum = (xnum + 128) Mod 255
            If xnum < 32 Then xnum = (xnum + 40) Mod 255
            If Chr(xnum) = "^" Then xnum = xnum + 1
            xout &= Chr(xnum Mod 255)
        Next
        ' Pad out the length
        Dim xlen As Int16 = xout.Length
        For xpiece = (xlen + 1) To 12
            xchar = xout.Substring(xpiece - 1 - xlen, 1)
            xnum = Asc(xchar)
            xnum = (xnum * 2.345 * xconst * (xconst - 7)) Mod 255
            xnum = xnum.Truncate(xnum)
            If xnum > 127 Then xnum = (xnum + 128) Mod 255
            If xnum < 32 Then xnum = (xnum + 40) Mod 255
            If Chr(xnum) = "^" Then xnum = xnum + 1
            xout &= Chr(xnum Mod 255)
        Next
        Return xout
    End Function

End Class
