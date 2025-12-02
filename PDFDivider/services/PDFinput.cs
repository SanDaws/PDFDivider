using System;

public class PdfInput
{
	public list<Ximages> pages { get; set; }
    public string FilePath { get; set; }

	public PdfInput(string filePath)
	{
		FilePath = filePath;
    }

}
