

Public Class LinqToObjectsForm
    Private Sub btnQuery1_Click(sender As Object, e As EventArgs) Handles btnQuery1.Click
        lstBoxResults.Items.Clear()
        Dim query As IEnumerable(Of Control) =
            From buttons As Control In Me.Controls
            Where TypeOf (buttons) Is Button Order By buttons.Text
            Select buttons
        Dim buttonCount As Integer = query.Count
        lblInfo.Text = "The following " + query.Count().ToString() + " buttons are on this form:"
        For Each b As Button In query
            lstBoxResults.Items.Add(b.Name)
        Next
    End Sub

    Private Sub btnQuery2_Click(sender As Object, e As EventArgs) Handles btnQuery2.Click
        Dim p1 As New Player With {.Name = "Alfreds Futterkiste", .Scores = New List(Of Integer)}
        p1.Scores.add(156)
        p1.Scores.add(187)
        p1.Scores.Add(207)

        Dim p2 As New Player With {.Name = "Eastern Connection", .Scores = New List(Of Integer)}
        p2.Scores.Add(127)
        p2.Scores.Add(156)
        p2.Scores.Add(198)

        Dim p3 As New Player With {.Name = "Hanari Carnes", .Scores = New List(Of Integer)}
        p3.Scores.Add(144)
        p3.Scores.Add(148)
        p3.Scores.Add(203)

        Dim p4 As New Player With {.Name = "Island Trading", .Scores = New List(Of Integer)}
        p4.Scores.Add(158)
        p4.Scores.Add(167)
        p4.Scores.Add(144)

        Dim p5 As New Player With {.Name = "Simons Bistro", .Scores = New List(Of Integer)}
        p5.Scores.Add(188)
        p5.Scores.Add(173)
        p5.Scores.Add(189)


        players.Clear()
        players.Add(p1)
        players.Add(p2)
        players.Add(p3)
        players.Add(p4)
        players.Add(p5)

        lstBoxResults.Items.Clear()

        Dim query = From p As Player In players
                    Where p.Scores.Average > 160
                    Select p
        lblInfo.Text = "The following players have score average over 160:"
        For Each plyr In query
            lstBoxResults.Items.Add(plyr.Name & ": avg=" & plyr.Scores.Average())
        Next
    End Sub
    Public players As List(Of Player) = New List(Of Player)
    Public Class Player
        Private _Name As String = ""
        Public Property Name() As String
            Get
                Return _Name
            End Get

            Set(ByVal value As String)
                _Name = value

            End Set
        End Property
        Private _Scores As List(Of Integer)
        Public Property Scores() As List(Of Integer)

            Get
                Return _Scores
            End Get

            Set(ByVal value As List(Of Integer))
                _Scores = value

            End Set
        End Property

    End Class

    Private Sub btnQuery3_Click(sender As Object, e As EventArgs) Handles btnQuery3.Click
        Dim p1 As New Player With {.Name = "Alfreds Futterkiste", .Scores = New List(Of Integer)}
        p1.Scores.Add(156)
        p1.Scores.Add(187)
        p1.Scores.Add(207)

        Dim p2 As New Player With {.Name = "Eastern Connection", .Scores = New List(Of Integer)}
        p2.Scores.Add(127)
        p2.Scores.Add(156)
        p2.Scores.Add(198)

        Dim p3 As New Player With {.Name = "Hanari Carnes", .Scores = New List(Of Integer)}
        p3.Scores.Add(144)
        p3.Scores.Add(148)
        p3.Scores.Add(203)

        Dim p4 As New Player With {.Name = "Island Trading", .Scores = New List(Of Integer)}
        p4.Scores.Add(158)
        p4.Scores.Add(167)
        p4.Scores.Add(144)

        Dim p5 As New Player With {.Name = "Simons Bistro", .Scores = New List(Of Integer)}
        p5.Scores.Add(188)
        p5.Scores.Add(173)
        p5.Scores.Add(189)


        players.Clear()
        players.Add(p1)
        players.Add(p2)
        players.Add(p3)
        players.Add(p4)
        players.Add(p5)

        lstBoxResults.Items.Clear()

        Dim query = From p As Player In players
                    Select p
                    Group By over200 = p.Scores.Max() > 200
                    Into Over200Group = Group
        lblInfo.Text = "Players have scores over 200:"
        For Each ovr200 In query
            lstBoxResults.Items.Add(ovr200.over200.ToString)
            For Each p In ovr200.Over200Group
                lstBoxResults.Items.Add(vbTab & p.Name)
            Next
        Next
    End Sub


End Class
