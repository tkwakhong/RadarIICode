Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim MysqlConn As MySqlConnection
    Dim ds As New DataSet
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RadarsitelocationDataSet11.radarlocation' table. You can move, or remove it, as needed.
        'Me.RadarlocationTableAdapter.Fill(Me.RadarsitelocationDataSet11.radarlocation)
        'TODO: This line of code loads data into the 'RadarsitelocationDataSet1.radarsitelocation' table. You can move, or remove it, as needed.
        'Me.RadarsitelocationTableAdapter.Fill(Me.RadarsitelocationDataSet1.radarsitelocation)

        ShowData()
        ReloadCombobox()
        LoginForm.Show()
    End Sub

    Private Sub ReloadCombobox()
        Try
            ds.Clear()
            ComboBox1.Items.Clear()
            DeleteRadarSiteNameComboBox.Items.Clear()
            MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=" + GlobalVariables.UserName + ";password=" + GlobalVariables.Password + ";database=radarsitelocation"
            }

            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation", MysqlConn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "radarlocation")
            Dim existIICodeList As New List(Of Integer)
            For Each row As DataRow In ds.Tables(0).Rows
                ComboBox1.Items.Add(row.Item("name"))
                DeleteRadarSiteNameComboBox.Items.Add(row.Item("name"))
            Next
            ComboBox1.Text = ComboBox1.Items(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=" + GlobalVariables.UserName + ";password=" + GlobalVariables.Password + ";database=radarsitelocation"
        }

        Try
            ds.Clear()
            MysqlConn.Open()
            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation WHERE name='" + SiteNameTextBox.Text + "'", MysqlConn)
            Using rder As MySqlDataReader = cmd.ExecuteReader()
                If rder.HasRows Then
                    MsgBox("Site Name Already Exist!", MsgBoxStyle.Exclamation, "Add New Site")
                    Exit Sub
                End If
            End Using

            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation WHERE name='THADMK'", MysqlConn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "radarlocation")

            Dim dmkLonDataset = ds.Tables(0).Rows(0).Item(2)
            Dim dmkLatDataset = ds.Tables(0).Rows(0).Item(3)
            Dim dmkLat As Double = dmkLatDataset
            Dim dmkLng As Double = dmkLonDataset
            Dim newSiteLat As Double = Double.Parse(LatitudeTextBox.Text)
            Dim newSiteLng As Double = Double.Parse(LongtitudeTextBox.Text)
            Dim distanceFromDMK = CalculateDistance(dmkLat, dmkLng, newSiteLat, newSiteLng)

            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation", MysqlConn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "radarlocation")
            Dim existIICodeList As New List(Of Integer)
            For Each row As DataRow In ds.Tables(0).Rows
                Dim existSiteLat As Double = row.Item("lat")
                Dim existSiteLng As Double = row.Item("lng")
                Dim existSiteIICode As Double = row.Item("iiCode")
                If (CalculateDistance(existSiteLat, existSiteLng, newSiteLat, newSiteLng) < GlobalVariables.DoubleRadarCoverage) Then
                    existIICodeList.Add(existSiteIICode)
                End If
            Next

            Dim newIICode As Integer
            For index As Integer = 2 To 15
                If (Not existIICodeList.Contains(index)) Then
                    newIICode = index
                    Exit For
                End If
            Next

            If (newIICode < 2 Or newIICode > 15) Then
                MsgBox("Cannot add more radar site. All of IICodes are allocated!", MsgBoxStyle.Exclamation, "Add New Site")
                Exit Sub
            End If

            Dim Query As String
            Query = "insert into radarsitelocation.radarlocation (name,lng,lat,x,y,distanceFromDMK,iiCode) 
                values('" & SiteNameTextBox.Text & "','" & LongtitudeTextBox.Text & "','" & LatitudeTextBox.Text &
                "','" & 0 & "','" & 0 & "','" & distanceFromDMK & "','" & newIICode & "');"

            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.ExecuteReader()
            MsgBox("Data Saved", MsgBoxStyle.Information, "Add New Site")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error")
        Catch ex2 As FormatException
            MessageBox.Show("Latitude and longtitude can only be number", "Error")
        Catch ex3 As Exception
            MessageBox.Show(ex3.Message, "Error")
        Finally
            MysqlConn.Dispose()
        End Try
        ShowData()
    End Sub

    Sub RefreshDataGridView()
        DataGridView1.DataSource = Nothing
        DataGridView1.ColumnCount = 0
        DataGridView1.AutoGenerateColumns = True
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=" + GlobalVariables.UserName + ";password=" + GlobalVariables.Password + ";database=radarsitelocation"
        }
        Dim CmdLoad As New MySqlCommand("SELECT * FROM radarlocation", MysqlConn)
        If CmdLoad.Connection.State = ConnectionState.Open Then CmdLoad.Connection.Close()
        CmdLoad.Connection.Open()
        Dim DsLoad As New DataSet
        Dim DaLoad As New MySqlDataAdapter(CmdLoad)
        DaLoad.Fill(DsLoad)
        DataGridView1.DataSource = DsLoad.Tables(0)
        CmdLoad.Connection.Close()
    End Sub

    Sub ShowData()
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=" + GlobalVariables.UserName + ";password=" + GlobalVariables.Password + ";database=radarsitelocation"
        }
        Try
            ds.Clear()
            MysqlConn.Open()

            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation WHERE name='THADMK'", MysqlConn)
            Using rder As MySqlDataReader = cmd.ExecuteReader()
                If Not rder.HasRows Then
                    MsgBox("Site THADMK Not Exist!", MsgBoxStyle.Exclamation, "Show Site")
                    Exit Sub
                End If
            End Using

            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "radarlocation")

            Dim selectedSiteLon = ds.Tables(0).Rows(0).Item(2)
            Dim selectedSiteLng = ds.Tables(0).Rows(0).Item(3)

            ds.Clear()
            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation", MysqlConn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "radarlocation")

            DataGridView1.DataSource = Nothing
            DataGridView1.ColumnCount = 0
            DataGridView1.ColumnCount = 3
            DataGridView1.Columns(0).HeaderText = "Site Name"
            DataGridView1.Columns(1).HeaderText = "Distance From THADMK (nm)"
            DataGridView1.Columns(2).HeaderText = "II Code"

            Dim siteList As New List(Of RadarSite)
            For Each dataRow As DataRow In ds.Tables(0).Rows

                Dim siteName = dataRow.Item(1)
                Dim siteLon = dataRow.Item(2)
                Dim siteLat = dataRow.Item(3)
                Dim siteIICode = dataRow.Item(7)
                Dim distance = CalculateDistance(selectedSiteLng, selectedSiteLon, siteLat, siteLon)
                Dim newRow As String() = New String() {siteName, distance, siteIICode}
                DataGridView1.Rows.Add(newRow)

            Next
            ReloadCombobox()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error")
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Function CalculateDistance(site1Lat As Decimal,
                               site1Lng As Decimal,
                               site2Lat As Decimal,
                               site2Lng As Decimal)
        ' Formula from "Distance" headline in https://www.movable-type.co.uk/scripts/latlong.html
        ' use THADMK as reference site
        Dim refLat As Double = 13.9257194444444
        Dim refLon As Double = 100.605683333333

        Dim x1 As Double = (site1Lng - refLon) * (Math.PI / 180) * 6371 * Math.Cos(refLat * (Math.PI / 180))
        Dim y1 As Double = (site1Lat - refLat) * (Math.PI / 180) * 6371
        Dim x2 As Double = (site2Lng - refLon) * (Math.PI / 180) * 6371 * Math.Cos(refLat * (Math.PI / 180))
        Dim y2 As Double = (site2Lat - refLat) * (Math.PI / 180) * 6371

        Dim x1nm As Double = x1 / 1.852
        Dim y1nm As Double = y1 / 1.852
        Dim x2nm As Double = x2 / 1.852
        Dim y2nm As Double = y2 / 1.852

        Dim distance As Double = Math.Sqrt(((x1nm - x2nm) ^ 2) + ((y1nm - y2nm) ^ 2))
        Return distance
    End Function

    Private Sub DeleteRadarSiteButton_Click(sender As Object, e As EventArgs) Handles DeleteRadarSiteButton.Click
        If DeleteRadarSiteNameComboBox.Text.Equals("THADMK") Then
            MsgBox("Cannot delete THADMK site!!", MsgBoxStyle.Exclamation, "Delete Radar Site")
            Exit Sub
        End If

        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=" + GlobalVariables.UserName + ";password=" + GlobalVariables.Password + ";database=radarsitelocation"
        }

        Try
            ds.Clear()
            MysqlConn.Open()

            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation", MysqlConn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "radarlocation")

            For Each row As DataRow In ds.Tables(0).Rows
                If DeleteRadarSiteNameComboBox.Text.Equals(row.Item(1)) Then
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete " + row.Item(1) + " ?",
                              "Delete Radar Site",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If (result = DialogResult.Yes) Then
                        Dim radarSiteID As String = row.Item(0)
                        cmd = New MySqlCommand("DELETE FROM radarlocation WHERE id=" + radarSiteID, MysqlConn)
                        cmd.ExecuteNonQuery()
                        ShowData()
                    End If
                    Exit Sub
                End If
            Next

            MsgBox("Radar site not found.", MsgBoxStyle.Exclamation, "Delete Radar Site")

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error")
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub ShowDataButton_Click(sender As Object, e As EventArgs) Handles ShowDataButton.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=" + GlobalVariables.UserName + ";password=" + GlobalVariables.Password + ";database=radarsitelocation"
        }
        Try
            ds.Clear()
            MysqlConn.Open()

            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation WHERE name='" + ComboBox1.Text + "'", MysqlConn)
            Using rder As MySqlDataReader = cmd.ExecuteReader()
                If Not rder.HasRows Then
                    MsgBox("Site Not Exist!", MsgBoxStyle.Exclamation, "Show Site")
                    Exit Sub
                End If
            End Using

            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "radarlocation")

            Dim selectedSiteLon = ds.Tables(0).Rows(0).Item(2)
            Dim selectedSiteLng = ds.Tables(0).Rows(0).Item(3)

            ds.Clear()
            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation", MysqlConn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "radarlocation")

            DataGridView1.DataSource = Nothing
            DataGridView1.ColumnCount = 0
            DataGridView1.ColumnCount = 3
            DataGridView1.Columns(0).HeaderText = "Site Name"
            DataGridView1.Columns(1).HeaderText = "Distance from " + ComboBox1.Text + "(nm)"
            DataGridView1.Columns(2).HeaderText = "II Code"

            Dim siteList As New List(Of RadarSite)
            For Each dataRow As DataRow In ds.Tables(0).Rows

                Dim siteName = dataRow.Item(1)
                Dim siteLon = dataRow.Item(2)
                Dim siteLat = dataRow.Item(3)
                Dim siteIICode = dataRow.Item(7)
                Dim distance = CalculateDistance(selectedSiteLng, selectedSiteLon, siteLat, siteLon)
                Dim newRow As String() = New String() {siteName, distance, siteIICode}
                DataGridView1.Rows.Add(newRow)

            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error")
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        LoginForm.Close()
    End Sub

    Private Sub CheckIICodeButton_Click(sender As Object, e As EventArgs) Handles CheckIICodeButton.Click
        Dim availableCode = "Available IICode : "
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=" + GlobalVariables.UserName + ";password=" + GlobalVariables.Password + ";database=radarsitelocation"
        }

        Try
            ds.Clear()
            MysqlConn.Open()
            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation WHERE name='" + SiteNameTextBox.Text + "'", MysqlConn)
            Using rder As MySqlDataReader = cmd.ExecuteReader()
                If rder.HasRows Then
                    MsgBox("Site Name Already Exist!", MsgBoxStyle.Exclamation, "Add New Site")
                    Exit Sub
                End If
            End Using

            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation WHERE name='THADMK'", MysqlConn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "radarlocation")

            Dim dmkLonDataset = ds.Tables(0).Rows(0).Item(2)
            Dim dmkLatDataset = ds.Tables(0).Rows(0).Item(3)
            Dim dmkLat As Double = dmkLatDataset
            Dim dmkLng As Double = dmkLonDataset
            Dim newSiteLat As Double = Double.Parse(LatitudeTextBox.Text)
            Dim newSiteLng As Double = Double.Parse(LongtitudeTextBox.Text)
            Dim distanceFromDMK = CalculateDistance(dmkLat, dmkLng, newSiteLat, newSiteLng)

            cmd = New MySqlCommand("select * from radarsitelocation.radarlocation", MysqlConn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "radarlocation")
            Dim existIICodeList As New List(Of Integer)
            For Each row As DataRow In ds.Tables(0).Rows
                Dim existSiteLat As Double = row.Item("lat")
                Dim existSiteLng As Double = row.Item("lng")
                Dim existSiteIICode As Double = row.Item("iiCode")
                If (CalculateDistance(existSiteLat, existSiteLng, newSiteLat, newSiteLng) < GlobalVariables.DoubleRadarCoverage) Then
                    existIICodeList.Add(existSiteIICode)
                End If
            Next

            Dim availableIICodeList As New List(Of Integer)
            For index As Integer = 2 To 15
                'For index As Integer = 2 To 17
                If (Not existIICodeList.Contains(index)) Then
                    availableIICodeList.Add(index)
                    'availableCode += index.ToString
                End If
            Next

            If availableIICodeList.Count = 0 Then
                MessageBox.Show("There is no available IICode", "Available IICode")
            Else
                For Each iiCode As Integer In availableIICodeList
                    availableCode += (iiCode.ToString + " ")
                Next
                MessageBox.Show(availableCode, "Available IICode")
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error")
        Catch ex2 As FormatException
            MessageBox.Show("Latitude and longtitude can only be number", "Error")
        Catch ex3 As Exception
            MessageBox.Show(ex3.Message, "Error")
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class
