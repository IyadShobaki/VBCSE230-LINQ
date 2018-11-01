Imports System.Data.Linq
Imports System.Data.Linq.Mapping

Public Class Form1
    Dim db As New DataContext(My.Settings.NorthwindConnectionString)
    Dim Customers As Table(Of Customer)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customers = db.GetTable(Of Customer)
        Dim qCountries = From cust In Customers Select cust.Country
                         Distinct
        For Each cust In qCountries
            ComboBox1.Items.Add(cust.ToString())

        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim query = From cust In Customers
                    Where cust.Country = ComboBox1.SelectedItem.ToString
                    Select cust
        DataGridView1.DataSource = query
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            db.SubmitChanges()
            MessageBox.Show("Save Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
<Table(Name:="Customers")>
Public Class Customer
    Private _CustomerID As String
    <Column(IsPrimaryKey:=True, Storage:="_CustomerID")>
    Public Property CustomerID() As String
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As String)
            _CustomerID = value

        End Set
    End Property
    Private _CompanyName As String
    <Column(Storage:="_CompanyName")>
    Public Property CompanyName() As String
        Get
            Return _CompanyName
        End Get
        Set(ByVal value As String)
            _CompanyName = value

        End Set

    End Property
    Private _Country As String
    <Column(Storage:="_Country")>
    Public Property Country() As String
        Get
            Return _Country

        End Get
        Set(ByVal value As String)
            _Country = value
        End Set
    End Property
End Class
