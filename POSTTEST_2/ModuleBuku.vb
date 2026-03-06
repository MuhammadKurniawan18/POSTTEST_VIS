Module ModuleBuku

    Public daftarBuku(100) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByRef judul As String, ByRef genre As String)
        daftarBuku(jumlahBuku) = judul & " (" & genre & ")"
        jumlahBuku += 1
    End Sub

    Public Function CariBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i).ToLower.Contains(judul.ToLower) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub HapusBuku(ByVal judul As String)
        Dim index As Integer = CariBuku(judul)

        If index <> -1 Then
            For i As Integer = index To jumlahBuku - 2
                daftarBuku(i) = daftarBuku(i + 1)
            Next
            jumlahBuku -= 1
        End If
    End Sub

End Module