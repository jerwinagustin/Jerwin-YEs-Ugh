Public Class Form1
    Dim GrossSalary, WH, RR, OT, OTR, SSS, PI2, IT2, TD2, PH2, NP2 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Name1.Clear()
        Name2.Clear()
        DP1.Clear()
        WH1.Clear()
        RR1.Clear()
        OT1.Clear()
        OR1.Clear()
        GS.Clear()
        SS.Clear()
        PH.Clear()
        PI.Clear()
        IT.Clear()
        TD.Clear()
        NP.Clear()
        DP2.Clear()
        WH2.Clear()
        RR2.Clear()
        OT2.Clear()
        OR2.Clear()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Name1.Text = Name2.Text
        DP1.Text = DP2.Text

        RR1.Text = "₱" & Format(CDbl(RR2.Text), "#,##0.00")
        OT1.Text = OT2.Text & " HOURS"
        OR1.Text = "₱" & Format(CDbl(OR2.Text), "#,##0.00")
        WH1.Text = WH2.Text & " HOURS"

        WH = CDbl(WH2.Text)
        RR = CDbl(RR2.Text)
        OT = CDbl(OT2.Text)
        OTR = CDbl(OR2.Text)

        GrossSalary = (WH * RR) + (OT * OTR)

        GS.Text = Format(GrossSalary, "₱#,##")

        SSS = GrossSalary * 0.05
        SS.Text = Format(SSS, "₱#,##")

        PH2 = 150.0
        PH.Text = Format(PH2, "₱#,##")

        PI2 = GrossSalary * 0.03
        PI.Text = Format(PI2, "₱#,##")

        IT2 = GrossSalary * 0.08
        IT.Text = Format(IT2, "₱#,##")

        TD2 = SSS + PH2 + PI2 + IT2
        TD.Text = Format(TD2, "₱#,##")

        NP2 = GrossSalary - TD2

        NP.Text = Format(NP2, "₱#,##")
    End Sub
End Class

