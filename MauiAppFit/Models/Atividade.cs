using SQLite;
using System.Data;

namespace MauiAppFit.Models
{
    public class Atividade
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public DataSetDateTime Data {  get; set; }
        public double? Peso { get; set; }
        public string? Observacoes { get; set; }
    }
}
