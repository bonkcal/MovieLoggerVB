<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.numRating = New System.Windows.Forms.NumericUpDown()
        Me.movieStatus = New System.Windows.Forms.ComboBox()
        Me.txtReview = New System.Windows.Forms.TextBox()
        Me.addMovieButton = New System.Windows.Forms.Button()
        Me.cmbSortBy = New System.Windows.Forms.ComboBox()
        Me.moviesList = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblReview = New System.Windows.Forms.Label()
        Me.lblSort = New System.Windows.Forms.Label()
        Me.colTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReview = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.numRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.moviesList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtJudul
        '
        Me.txtJudul.BackColor = System.Drawing.Color.Lavender
        Me.txtJudul.Location = New System.Drawing.Point(100, 34)
        Me.txtJudul.MaxLength = 100
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(120, 22)
        Me.txtJudul.TabIndex = 0
        '
        'numRating
        '
        Me.numRating.BackColor = System.Drawing.Color.Lavender
        Me.numRating.DecimalPlaces = 1
        Me.numRating.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numRating.Location = New System.Drawing.Point(100, 72)
        Me.numRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numRating.Name = "numRating"
        Me.numRating.Size = New System.Drawing.Size(120, 22)
        Me.numRating.TabIndex = 1
        '
        'movieStatus
        '
        Me.movieStatus.AllowDrop = True
        Me.movieStatus.BackColor = System.Drawing.Color.Lavender
        Me.movieStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.movieStatus.FormattingEnabled = True
        Me.movieStatus.Items.AddRange(New Object() {"Watched", "Plan to watch"})
        Me.movieStatus.Location = New System.Drawing.Point(100, 112)
        Me.movieStatus.Name = "movieStatus"
        Me.movieStatus.Size = New System.Drawing.Size(120, 21)
        Me.movieStatus.TabIndex = 2
        '
        'txtReview
        '
        Me.txtReview.BackColor = System.Drawing.Color.Lavender
        Me.txtReview.Location = New System.Drawing.Point(325, 34)
        Me.txtReview.MaxLength = 255
        Me.txtReview.Multiline = True
        Me.txtReview.Name = "txtReview"
        Me.txtReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReview.Size = New System.Drawing.Size(367, 77)
        Me.txtReview.TabIndex = 3
        '
        'addMovieButton
        '
        Me.addMovieButton.Location = New System.Drawing.Point(595, 117)
        Me.addMovieButton.Name = "addMovieButton"
        Me.addMovieButton.Size = New System.Drawing.Size(97, 32)
        Me.addMovieButton.TabIndex = 4
        Me.addMovieButton.Text = "ADD MOVIE"
        Me.addMovieButton.UseVisualStyleBackColor = True
        '
        'cmbSortBy
        '
        Me.cmbSortBy.BackColor = System.Drawing.Color.Lavender
        Me.cmbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSortBy.FormattingEnabled = True
        Me.cmbSortBy.Items.AddRange(New Object() {"Title", "Rating"})
        Me.cmbSortBy.Location = New System.Drawing.Point(25, 223)
        Me.cmbSortBy.Name = "cmbSortBy"
        Me.cmbSortBy.Size = New System.Drawing.Size(121, 21)
        Me.cmbSortBy.TabIndex = 5
        '
        'moviesList
        '
        Me.moviesList.AllowUserToAddRows = False
        Me.moviesList.AllowUserToResizeColumns = False
        Me.moviesList.AllowUserToResizeRows = False
        Me.moviesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.moviesList.BackgroundColor = System.Drawing.Color.Lavender
        Me.moviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.moviesList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTitle, Me.colRating, Me.colStatus, Me.colReview})
        Me.moviesList.Enabled = False
        Me.moviesList.GridColor = System.Drawing.Color.Lavender
        Me.moviesList.Location = New System.Drawing.Point(25, 281)
        Me.moviesList.Name = "moviesList"
        Me.moviesList.ReadOnly = True
        Me.moviesList.RowHeadersVisible = False
        Me.moviesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.moviesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.moviesList.Size = New System.Drawing.Size(667, 359)
        Me.moviesList.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(25, 666)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Location = New System.Drawing.Point(22, 37)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(70, 13)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "Movie Name"
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Location = New System.Drawing.Point(22, 74)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(41, 13)
        Me.lblRating.TabIndex = 9
        Me.lblRating.Text = "Rating"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(22, 115)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "Status"
        '
        'lblReview
        '
        Me.lblReview.AutoSize = True
        Me.lblReview.Location = New System.Drawing.Point(276, 37)
        Me.lblReview.Name = "lblReview"
        Me.lblReview.Size = New System.Drawing.Size(43, 13)
        Me.lblReview.TabIndex = 11
        Me.lblReview.Text = "Review"
        '
        'lblSort
        '
        Me.lblSort.AutoSize = True
        Me.lblSort.Location = New System.Drawing.Point(22, 207)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(46, 13)
        Me.lblSort.TabIndex = 12
        Me.lblSort.Text = "Sort by:"
        '
        'colTitle
        '
        Me.colTitle.HeaderText = "Title"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.ReadOnly = True
        Me.colTitle.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'colRating
        '
        Me.colRating.HeaderText = "Rating"
        Me.colRating.Name = "colRating"
        Me.colRating.ReadOnly = True
        Me.colRating.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colRating.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colReview
        '
        Me.colReview.HeaderText = "Review"
        Me.colReview.Name = "colReview"
        Me.colReview.ReadOnly = True
        Me.colReview.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colReview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(761, 741)
        Me.Controls.Add(Me.lblSort)
        Me.Controls.Add(Me.lblReview)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.moviesList)
        Me.Controls.Add(Me.cmbSortBy)
        Me.Controls.Add(Me.addMovieButton)
        Me.Controls.Add(Me.txtReview)
        Me.Controls.Add(Me.movieStatus)
        Me.Controls.Add(Me.numRating)
        Me.Controls.Add(Me.txtJudul)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOGGER (Movie Logger)"
        CType(Me.numRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.moviesList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtJudul As TextBox
    Friend WithEvents numRating As NumericUpDown
    Friend WithEvents movieStatus As ComboBox
    Friend WithEvents txtReview As TextBox
    Friend WithEvents addMovieButton As Button
    Friend WithEvents cmbSortBy As ComboBox
    Friend WithEvents moviesList As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblRating As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblReview As Label
    Friend WithEvents lblSort As Label
    Friend WithEvents colTitle As DataGridViewTextBoxColumn
    Friend WithEvents colRating As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colReview As DataGridViewTextBoxColumn
End Class
