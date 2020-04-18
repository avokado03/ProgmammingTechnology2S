Imports System.Drawing

Public Class PointPositionFinder

    Private Checks As New List(Of Func(Of Single, Single, Single, String))

    Public Sub New()
        Checks.Add(New Func(Of Single, Single, Single, String)(AddressOf IsTop))
        Checks.Add(New Func(Of Single, Single, Single, String)(AddressOf OnVector))
        Checks.Add(New Func(Of Single, Single, Single, String)(AddressOf DoesContainPoint))
    End Sub


    Public Function FindPosition(pointA As PointF, pointB As PointF, pointC As PointF, pointP As PointF) As String
        Dim ABxAP, BCxBP, CAxCP As Single
        ABxAP = GetSign(pointP, pointA, pointB)
        BCxBP = GetSign(pointP, pointB, pointC)
        CAxCP = GetSign(pointP, pointC, pointA)
        Return CheckPoint(ABxAP, BCxBP, CAxCP)
    End Function

    Private Function CheckPoint(ABxAP As Single, BCxBP As Single, CAxCP As Single) As String
        Dim result As String = String.Empty
        For Each method As Func(Of Single, Single, Single, String) In Checks
            If (result = String.Empty) Then
                result = method.Invoke(ABxAP, BCxBP, CAxCP)
            Else
                Exit For
            End If
        Next
        Return result
    End Function

    Private Function IsTop(ABxAP As Single, BCxBP As Single, CAxCP As Single) As String
        Dim status As String = String.Empty
        If (ABxAP = 0 And BCxBP = 0) Then status = PositionStatus.P_Is_B
        If (BCxBP = 0 And CAxCP = 0) Then status = PositionStatus.P_Is_C
        If (CAxCP = 0 And ABxAP = 0) Then status = PositionStatus.P_Is_A
        Return status
    End Function

    Private Function OnVector(ABxAP As Single, BCxBP As Single, CAxCP As Single) As String
        Dim status As String = String.Empty
        If (ABxAP = 0) Then status = PositionStatus.P_On_AB
        If (BCxBP = 0) Then status = PositionStatus.P_On_BC
        If (CAxCP = 0) Then status = PositionStatus.P_On_AC
        Return status
    End Function

    Private Function DoesContainPoint(ABxAP As Single, BCxBP As Single, CAxCP As Single) As String
        Dim has_neg, has_pos As Boolean
        has_neg = (ABxAP < 0) Or (BCxBP < 0) Or (CAxCP < 0)
        has_pos = (ABxAP > 0) Or (BCxBP > 0) Or (CAxCP > 0)
        Return If(Not (has_neg And has_pos), PositionStatus.OnTriangle, PositionStatus.OutOfTriangle)
    End Function

    Private Function GetSign(pointP As PointF, pointV1 As PointF, pointV2 As PointF) As Single
        Return (pointP.X - pointV2.X) * (pointV1.Y - pointV2.Y) - (pointV1.X - pointV2.X) * (pointP.Y - pointV2.Y)
    End Function

End Class
