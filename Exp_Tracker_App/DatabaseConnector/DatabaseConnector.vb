﻿Imports MySql.Data.MySqlClient

Public Class DatabaseConnector
    Public command As New MySqlCommand
    Public dataTable As New DataTable
    Public dataAdapter As New MySqlDataAdapter
    Public query As String
    Public connect As New MySqlConnection("server=localhost;port=3307;user=root;database=exp_tracker_db")
    Public reader As MySqlDataReader
End Class
