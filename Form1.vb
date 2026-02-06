Imports System.IO
Imports System.Linq

Public Class Form1

    Public Class Movie
        Public Property Title As String
        Public Property Rating As Decimal
        Public Property Status As String
        Public Property Review As String
    End Class

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSortBy.SelectedIndexChanged
        If cmbSortBy.SelectedItem.ToString() = "Title" Then
            movieList = movieList.OrderBy(Function(m) m.Title).ToList()
        ElseIf cmbSortBy.SelectedItem.ToString() = "Rating" Then
            movieList = movieList.OrderByDescending(Function(m) m.Rating).ToList()
        End If
        RefreshMovieDisplay()
    End Sub


    Dim movieList As New List(Of Movie)
    Dim filePath As String = "movies.txt"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMoviesFromFile()
        RefreshMovieDisplay()
    End Sub

    Private Sub numRating_ValueChanged(sender As Object, e As EventArgs) Handles numRating.ValueChanged
        numRating.Value = Math.Round(numRating.Value * 2) / 2
    End Sub

    Private Sub addMovieButton_Click(sender As Object, e As EventArgs) Handles addMovieButton.Click


        If String.IsNullOrWhiteSpace(txtJudul.Text) Then
            MessageBox.Show("Please enter a movie title!")
            txtJudul.Focus()
            Return
        End If

        If movieStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a status!")
            movieStatus.Focus()
            Return
        End If

        If numRating.Value <= 0 Then
            MessageBox.Show("Please select a rating greater than 0!")
            numRating.Focus()
            Return
        End If

        Dim newMovie As New Movie With {
            .Title = txtJudul.Text,
            .Rating = numRating.Value,
            .Status = movieStatus.SelectedItem.ToString(),
            .Review = txtReview.Text
        }




        movieList.Add(newMovie)
        RefreshMovieDisplay()


        txtJudul.Text = ""
        numRating.Value = 0
        movieStatus.SelectedIndex = 0
        txtReview.Text = ""
    End Sub


    Private Sub RefreshMovieDisplay()
        moviesList.Rows.Clear()
        For Each m As Movie In movieList
            moviesList.Rows.Add(m.Title, m.Rating, m.Status, m.Review)
        Next
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If movieList.Count = 0 Then
            MessageBox.Show("No movies to save!")
            Return
        End If

        Dim validMovies = movieList.Where(Function(m) Not String.IsNullOrWhiteSpace(m.Title) _
                                               AndAlso Not String.IsNullOrWhiteSpace(m.Status)).ToList()

        If validMovies.Count = 0 Then
            MessageBox.Show("No valid movies to save!")
            Return
        End If

        Using writer As New StreamWriter(filePath)
            For Each m As Movie In movieList
                writer.WriteLine($"{m.Title},{m.Rating},{m.Status},{m.Review}")
            Next
        End Using
        MessageBox.Show("Movies saved !")
    End Sub


    Private Sub LoadMoviesFromFile()
        If Not File.Exists(filePath) Then Return

        movieList.Clear()
        Dim lines() As String = File.ReadAllLines(filePath)
        For Each line As String In lines
            Dim parts() As String = line.Split(","c)
            If parts.Length >= 4 Then
                movieList.Add(New Movie With {
                    .Title = parts(0),
                    .Rating = Convert.ToDecimal(parts(1)),
                    .Status = parts(2),
                    .Review = parts(3)
                })
            End If
        Next
    End Sub


End Class
