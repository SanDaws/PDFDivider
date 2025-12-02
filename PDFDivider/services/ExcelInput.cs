using System;

public class ExcelInput
{
	public excelpath { get; set; }
	public ExcelInput( string path)
	{
		excelpath = path;
}
//verificar archivo excel
	public bool VerifyExcelFile()
	{
		// Lógica para verificar si el archivo de Excel existe y es accesible
		return System.IO.File.Exists(excelpath);
}
//abrir archivo excel
	public void OpenExcelFile()
	{
		if (VerifyExcelFile())
		{
			// Lógica para abrir y leer el archivo de Excel
			Console.WriteLine("Archivo de Excel abierto correctamente.");
		}
		else
		{
			Console.WriteLine("El archivo de Excel no existe o no es accesible.");
		}
}
}
