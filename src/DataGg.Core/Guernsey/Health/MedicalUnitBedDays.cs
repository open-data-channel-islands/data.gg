using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Health;

public class MedicalUnitBedDays
{
    [JsonPropertyName("Year")]
    public int Year { get; set; }
    [JsonPropertyName("General Medicine")]
    public int GeneralMedicine { get; set; }
    [JsonPropertyName("Mental health other than old age psychiatry")]
    public int MentalHealthOtherThanOldAgePsychiatry { get; set; }
    [JsonPropertyName("Rehabilitation")]
    public int Rehabilitation { get; set; }
    [JsonPropertyName("Old Age Pyschiatry")]
    public int OldAgePyschiatry { get; set; }
    [JsonPropertyName("Orthopaedics")]
    public int Orthopaedics { get; set; }
    [JsonPropertyName("General Surgery")]
    public int GeneralSurgery { get; set; }
    [JsonPropertyName("Geriatric Medicine")]
    public int GeriatricMedicine { get; set; }
    [JsonPropertyName("Baby Health & Paediatrics")]
    public int BabyHealthPaediatrics { get; set; }
    [JsonPropertyName("Medical Oncology")]
    public int MedicalOncology { get; set; }
    [JsonPropertyName("Obstetrics")]
    public int Obstetrics { get; set; }
    [JsonPropertyName("Cardiology")]
    public int Cardiology { get; set; }
    [JsonPropertyName("Critical Care Medicine")]
    public int CriticalCareMedicine { get; set; }
    [JsonPropertyName("Respite Care")]
    public int? RespiteCare { get; set; }
    [JsonPropertyName("Urology")]
    public int Urology { get; set; }
    [JsonPropertyName("Gynaecology")]
    public int Gynaecology { get; set; }
    [JsonPropertyName("ENT")]
    public int Ent { get; set; }
    [JsonPropertyName("Gastroenterology")]
    public int Gastroenterology { get; set; }
    [JsonPropertyName("Other areas")]
    public int OtherAreas { get; set; }
    [JsonPropertyName("Total")]
    public int Total { get; set; }
}