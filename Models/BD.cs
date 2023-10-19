using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace TP_Series;

public static class BD
{
    private static string _connectionString = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";

    public static List<SERIES> CargarSeries()
    {
        List<SERIES> ListaSeries = new List<SERIES>();
        using (SqlConnection DB = new SqlConnection(_connectionString))
        {
            string SQL = "SELECT * FROM Series";
            ListaSeries = DB.Query<SERIES>(SQL).ToList();
            return ListaSeries;
        }
    }
    public static List<ACTORES> CargarActores()
    {
        List<ACTORES> ListaActores = new List<ACTORES>();
        using (SqlConnection DB = new SqlConnection(_connectionString))
        {
            string SQL = "SELECT * FROM Actores";
            ListaActores = DB.Query<ACTORES>(SQL).ToList();
            return ListaActores;
        }
    }
    public static List<TEMPORADAS> CargarTemporadas()
    {
        List<TEMPORADAS> ListaTemporadas = new List<TEMPORADAS>();
        using (SqlConnection DB = new SqlConnection(_connectionString))
        {
            string SQL = "SELECT * FROM Temporadas";
            ListaTemporadas = DB.Query<TEMPORADAS>(SQL).ToList();
            return ListaTemporadas;
        }
    }
    public static List<TEMPORADAS> TraerTemporadas(int IdSerie){
        List<TEMPORADAS> ListaTemporadas = new List<TEMPORADAS>();
        using (SqlConnection DB = new SqlConnection(_connectionString))
        {
            string SQL = "SELECT * FROM Temporadas WHERE IdSerie = @pIdSerie";
            ListaTemporadas = DB.Query<TEMPORADAS>(SQL, new { @pIdSerie = IdSerie }).ToList();
            return ListaTemporadas;
        }
    }
    public static List<ACTORES> TraerActores(int IdSerie){
        List<ACTORES> ListaActores = new List<ACTORES>();
        using (SqlConnection DB = new SqlConnection(_connectionString))
        {
            string SQL = "SELECT * FROM Actores WHERE IdSerie = @pIdSerie";
            ListaActores = DB.Query<ACTORES>(SQL, new { @pIdSerie = IdSerie }).ToList();
            return ListaActores;
        }
    }
    public static List<SERIES> TraerInfoSerie(int IdSerie){
        List<SERIES> ListaSerie = new List<SERIES>();
        using (SqlConnection DB = new SqlConnection(_connectionString))
        {
            string SQL = "SELECT * FROM Series WHERE IdSerie = @pIdSerie";
            ListaSerie = DB.Query<SERIES>(SQL, new { @pIdSerie = IdSerie }).ToList();
            return ListaSerie;
        }
    }
}