﻿namespace RobinsonSportApp.Data.Entities;

public class Event
{
    public long Id { get; set; }
    public string Opponent1 { get; set; }
    public string Opponent2 { get; set; }
    public float Score1 { get; set; }
    public float Score2 { get; set; }
    public string Place { get; set; }
    public SportCategory SportCategory { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public DateTime CreatedDate { get; set; }
}

public enum SportCategory
{
    Football,
    Basketball,
    Tennis,
    Rugby,
    Handball
}