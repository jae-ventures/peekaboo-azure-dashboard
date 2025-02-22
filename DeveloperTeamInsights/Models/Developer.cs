using System.ComponentModel.DataAnnotations;

namespace DeveloperTeamInsights.Models;

public class Developer
{
    public int Id { get; set; }
    public string? DeveloperName { get; set; }
    public int NumberTasksWorked { get; set; }
    public int NumberActivePRs { get; set; }
    public int NumberReviewsConducted { get; set; }
    public int NumberDocumentsGenerated { get; set; }
    public int NumberDocumentsReviewed { get; set; }
    
}