Imports System

Module Program
  Sub Main(args As String())
    Dim cislo As Integer
    Dim soucet As Integer = 0

    Console.Write("Zadej ��slo: ")
    cislo = Console.ReadLine

    For x = 0 To cislo
      soucet = soucet + x
    Next

    Console.WriteLine($"Sou�et ��sel od 0 to {cislo} je {soucet}")

  End Sub
End Module
