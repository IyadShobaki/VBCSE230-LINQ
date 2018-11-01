Public Class Form1
    Dim ds As dsNorthwind = New dsNorthwind
    Dim taCustomers As dsNorthwindTableAdapters.CustomersTableAdapter = New dsNorthwindTableAdapters.CustomersTableAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taCustomers.Fill(ds.Customers)
        Dim qCountries = From cust In ds.Customers.AsEnumerable()
                         Order By cust.Country
                         Select cust.Country
        For Each cust In qCountries.Distinct
            ComboBox1.Items.Add(cust.ToString())
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim query = From customer In ds.Customers.AsEnumerable()
                    Where customer.Country = ComboBox1.SelectedItem.ToString
                    Select customer
        For Each cust In query
            ListBox1.Items.Add(cust.CompanyName)

        Next
    End Sub
End Class
