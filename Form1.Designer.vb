<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt_reg = New TextBox()
        txt_name = New TextBox()
        cmb_gender = New ComboBox()
        cmb_course = New ComboBox()
        cmb_club = New ComboBox()
        btn_save = New Button()
        btn_edit = New Button()
        btn_delete = New Button()
        btn_clear = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        txt_search = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_reg
        ' 
        txt_reg.Location = New Point(15, 85)
        txt_reg.Name = "txt_reg"
        txt_reg.Size = New Size(204, 23)
        txt_reg.TabIndex = 0
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(14, 129)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(204, 23)
        txt_name.TabIndex = 0
        ' 
        ' cmb_gender
        ' 
        cmb_gender.FormattingEnabled = True
        cmb_gender.Items.AddRange(New Object() {"MALE", "FEMALE", "OTHER"})
        cmb_gender.Location = New Point(14, 178)
        cmb_gender.Name = "cmb_gender"
        cmb_gender.Size = New Size(121, 23)
        cmb_gender.TabIndex = 1
        ' 
        ' cmb_course
        ' 
        cmb_course.FormattingEnabled = True
        cmb_course.Items.AddRange(New Object() {"COMPUTER SCIENCE", "IT", "TELECOMMUNICATION ENGINEERING", "ACTURIAL SCIENCE", "EDUCATION SCIENCE", "EDUCATION ARTS", "FINANCE", "ACCOUNTING", "BBIT", "BMIT", "NURSING", "CLINICAL MEDICINE", "LAW", "MUSIC"})
        cmb_course.Location = New Point(14, 233)
        cmb_course.Name = "cmb_course"
        cmb_course.Size = New Size(182, 23)
        cmb_course.TabIndex = 1
        ' 
        ' cmb_club
        ' 
        cmb_club.FormattingEnabled = True
        cmb_club.Items.AddRange(New Object() {"FORESTRY", "IOT", "AISEC", "ENVIRONMENTAL CLUB", "RED CROSS", "JOURNALISM CLUB", "MUSIC"})
        cmb_club.Location = New Point(14, 294)
        cmb_club.Name = "cmb_club"
        cmb_club.Size = New Size(182, 23)
        cmb_club.TabIndex = 1
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.LimeGreen
        btn_save.Cursor = Cursors.Hand
        btn_save.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_save.ForeColor = Color.White
        btn_save.Location = New Point(14, 345)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(82, 42)
        btn_save.TabIndex = 2
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' btn_edit
        ' 
        btn_edit.BackColor = Color.DarkOrange
        btn_edit.Cursor = Cursors.Hand
        btn_edit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_edit.ForeColor = Color.White
        btn_edit.Location = New Point(114, 345)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(82, 42)
        btn_edit.TabIndex = 2
        btn_edit.Text = "Update"
        btn_edit.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btn_delete.Cursor = Cursors.Hand
        btn_delete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_delete.ForeColor = Color.White
        btn_delete.Location = New Point(14, 388)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(82, 42)
        btn_delete.TabIndex = 2
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' btn_clear
        ' 
        btn_clear.BackColor = Color.DarkSlateGray
        btn_clear.Cursor = Cursors.Hand
        btn_clear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_clear.ForeColor = Color.White
        btn_clear.Location = New Point(114, 393)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(82, 42)
        btn_clear.TabIndex = 2
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 15)
        Label1.TabIndex = 3
        Label1.Text = "Registration Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 4
        Label2.Text = "Full Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 5
        Label3.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 6
        Label4.Text = "Course"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 15)
        Label5.TabIndex = 7
        Label5.Text = "Your prefered club"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(239, 140)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(510, 329)
        DataGridView1.TabIndex = 8
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.Frozen = True
        Column1.HeaderText = "Reg No"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 71
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Gender"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Course"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 69
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Club"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 57
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(239, 85)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(318, 23)
        txt_search.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(243, 67)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 3
        Label6.Text = "Search"
        Label6.UseMnemonic = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.FlatStyle = FlatStyle.System
        Label7.Font = New Font("Cooper Black", 17F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(210, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 26)
        Label7.TabIndex = 9
        Label7.Text = "ClubHub"
        Label7.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(771, 522)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(btn_clear)
        Controls.Add(btn_delete)
        Controls.Add(btn_edit)
        Controls.Add(btn_save)
        Controls.Add(cmb_club)
        Controls.Add(cmb_course)
        Controls.Add(cmb_gender)
        Controls.Add(txt_search)
        Controls.Add(txt_name)
        Controls.Add(txt_reg)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Club_Info"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_reg As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents cmb_gender As ComboBox
    Friend WithEvents cmb_course As ComboBox
    Friend WithEvents cmb_club As ComboBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label

End Class
