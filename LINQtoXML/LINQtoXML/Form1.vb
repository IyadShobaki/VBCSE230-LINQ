Imports System.Xml.Linq

Public Class LinqToXmlForm
    Private Sub btnLoadProducts_Click(sender As Object, e As EventArgs) Handles btnLoadProducts.Click
        Dim root As XElement = XElement.Load("NorthwindProducts.xml")
        Dim product As IEnumerable(Of XElement) = From el In root.Descendants("Products")
                                                  Order By (el.Element("ProductName").Value)
                                                  Select el
        For Each el In product
            resultListBox.Items.Add(el.Element("ProductName").Value)
        Next
        resultListBox.SelectedIndex = 0

    End Sub

    Private Sub btnGetProductInfo_Click(sender As Object, e As EventArgs) Handles btnGetProductInfo.Click
        Dim root As XElement = XElement.Load("NorthwindProducts.xml")
        Dim product As IEnumerable(Of XElement) = From el In root.Descendants("Products")
                                                  Where (el.Element("ProductName").Value = resultListBox.SelectedItem.ToString)
                                                  Select el

        For Each el In product
            txtQuantityPerUnit.Text = el.Element("QuantityPerUnit").Value
            txtUnitPrice.Text = el.Element("UnitPrice").Value
            txtUnitsInStock.Text = el.Element("UnitsInStock").Value
        Next
    End Sub
End Class
