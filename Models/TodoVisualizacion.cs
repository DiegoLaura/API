namespace TodoApi.Models;

public class Visualizacion
{
    public long Id { get; set; }
    public long id_user { get; set; }
    public long id_movie { get; set; }
    public TimeSpan time_visualization { get; set; }
    public bool like { get; set; }
}