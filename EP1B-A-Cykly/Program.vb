Imports System

Module Program
  Sub Main(args As String())
    Dim cislo As Integer

    For pocet = 1 To 5
      Console.Write("Zadej ��slo: ")
      cislo = Console.ReadLine
      Console.WriteLine($"{pocet}. zadan� ��slo je {cislo}")
    Next

  End Sub
End Module
