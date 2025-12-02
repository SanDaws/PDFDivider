using System;

public class PdfManager
{

    //ruta de entrada del pdf
    public string FilePath { get; set; }
    public string OutputDirectory { get; set; }
    public int initialPage { get; set; }
    public int finalPage { get; set; }
    public

    //constructor
    public PdfManager(string filePath)
    {
        FilePath = filePath;
    }
    //verificadores
    //verificar si el archivo es un pdf
    public bool IsValidPdf()
    {
        // Verificar si el archivo tiene la extensión .pdf
        return FilePath.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase);
    }
    //vrificar si el archivo existe
    //crear runta de salida

    //setter
    //pagina inicial y final
    //output directory



}
