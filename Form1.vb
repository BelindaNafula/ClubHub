Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As New MySqlConnection("host=localhost;user=root;password=;database=club_info")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Load()
    End Sub

    Public Sub DGV_Load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM students", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("RegNo"), dr.Item("Name"), dr.Item("Gender"), dr.Item("Course"), dr.Item("Club"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try

    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        save()
        DGV_Load()
    End Sub
    Public Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `students`(`RegNo`, `Name`, `Gender`, `Course`, `Club`) VALUES (@RegNo,@Name,@Gender,@Course,@Club)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RegNo", txt_reg.Text)
            cmd.Parameters.AddWithValue("@Name", txt_name.Text)
            cmd.Parameters.AddWithValue("@Gender", cmb_gender.Text)
            cmd.Parameters.AddWithValue("@Course", cmb_course.Text)
            cmd.Parameters.AddWithValue("@Club", cmb_club.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Save Success !", "students", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Save Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()

        End Try
        Clear()
    End Sub

    Public Sub Clear()
        txt_reg.Clear()
        txt_name.Clear()
        cmb_gender.Text = ""
        cmb_course.Text = ""
        cmb_club.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txt_reg.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_name.Text = DataGridView1.CurrentRow.Cells(1).Value
        cmb_gender.Text = DataGridView1.CurrentRow.Cells(2).Value
        cmb_course.Text = DataGridView1.CurrentRow.Cells(3).Value
        cmb_club.Text = DataGridView1.CurrentRow.Cells(4).Value

        txt_reg.ReadOnly = True
        btn_save.Enabled = False
    End Sub

    Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `students` SET `RegNo`=@RegNo,`Naem`=@Name,`Gender`=@Gender,`Course`=@Course,`Club`=@Club WHERE `RegNo`=@RegNo", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RegNo", txt_reg.Text)
            cmd.Parameters.AddWithValue("@Name", txt_name.Text)
            cmd.Parameters.AddWithValue("@Gender", cmb_gender.Text)
            cmd.Parameters.AddWithValue("@Course", cmb_course.Text)
            cmd.Parameters.AddWithValue("@Club", cmb_club.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Update Success !", "students", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()

        End Try
        Clear()
        DGV_Load()

    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Edit()

    End Sub

    Public Sub delete()
        If MsgBox("Are You Sure You Want to delete this Record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE  FROM`students`  WHERE `RegNo`=@RegNo", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@RegNo", txt_reg.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Deleted succesfully !", "students", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Delete Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                conn.Close()

            End Try
            Clear()
            DGV_Load()

        Else
            Return
        End If
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        delete()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Clear()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM students WHERE Club like '%" & txt_search.Text & "%' OR Name like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("RegNo"), dr.Item("Name"), dr.Item("Gender"), dr.Item("Course"), dr.Item("Club"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try

    End Sub
End Class