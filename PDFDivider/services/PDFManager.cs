using System;

public class PdfManager
{

    //ruta de entrada del pdf
    public string FilePath { get; set; }
    public string OutputDirectory { get; set; }
    public int initialPage { get; set; }
    public int finalPage { get; set; }
    public list<Ximages>

    //constructor
    public PdfManager(string filePath)
    {
        FilePath = filePath;
    }
    //verificadores
    //verificar si hay archivo pdf
    //verificar si el archivo es un pdf
    public bool IsValidPdf()
    {
        // Verificar si el archivo tiene la extensión .pdf
        return FilePath.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase);
    }
    //vrificar si el archivo existe
    public bool FileExists(string filePath)
    {
        return System.IO.File.Exists(filePath);
    }
    //verificar si la ruta de salida existe
    public bool OutputDirectoryExists(string outputDirectory)
    {
        //true si existe, false si no
        return System.IO.Directory.Exists(outputDirectory);
    }
    //crear runta de salida
    public string directoryCreate(string GeneralDirectory, string newDirectoryName)
    {

        if (!OutputDirectory(GeneralDirectory))
        {
         return null;
        }
        string newDirectoryPath = $"{GeneralDirectory}\\{newDirectoryName}";
        System.IO.Directory.CreateDirectory(newDirectoryName);
        return newDirectoryPath;


    }

    //setter
    public void SetOutputDirectory(string outputDirectory)
    {
        OutputDirectory = outputDirectory;
    }
    //pagina inicial y final
    public void rangePages(int initial, int final)
    {
        initialPage = initial;
        finalPage = final;
    }
    //output directory
    public bool safeoutputdirectory(string generalDirectory)
    {
        if (!OutputDirectoryExists(generalDirectory))
        {
            directoryCreate(generalDirectory, "PDFDividerOutput");
        }
        return true;
    }



}
