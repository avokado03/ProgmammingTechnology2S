Imports System.Drawing
Imports UtilsLibrary

Module PointInTriangle

    Sub Main()
        Dim A, B, C, P As PointF
        Dim result As String
        Dim finder As PointPositionFinder
        Console.WriteLine("Enter three points coordinates as (x y)")
        Try
            Console.WriteLine("Enter A:")
            A = Console.ReadLine().ToPointF()
            Console.WriteLine("Enter B:")
            B = Console.ReadLine().ToPointF()
            Console.WriteLine("Enter C:")
            C = Console.ReadLine().ToPointF()
            Console.WriteLine("Enter P point:")
            P = Console.ReadLine().ToPointF()
            Console.WriteLine("Enter end")
            finder = New PointPositionFinder
            result = finder.FindPosition(A, B, C, P)
            Console.WriteLine("Result: " + result)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
    End Sub

End Module
