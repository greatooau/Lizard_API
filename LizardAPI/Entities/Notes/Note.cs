namespace LizardAPI.Entities.Notes; 

public class Note {
	public int? NoteId { get; set; }
	public string? Content { get; set; }
	public string? Color { get; set; }
	public int? UserId { get; set; }
}