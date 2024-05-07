Imports System

Module Program
  Sub Main(args As String())
    Dim cislo As Integer

    For pocet = 1 To 5
      Console.Write("Zadej èíslo: ")
      cislo = Console.ReadLine
      Console.WriteLine($"{pocet}. zadané èíslo je {cislo}")
    Next

  End Sub
End Module
