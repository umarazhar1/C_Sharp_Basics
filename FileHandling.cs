



//using System;

//namespace FileHandling
//{
//	class Program
//	{

//		static void Main(string[] args)
//		{
//			/*File Handling*/
//			Console.WriteLine("File Handling below:");

//			Console.WriteLine("Enter any random text below: (To be saved in file)");

//			string writeText = Console.ReadLine();  // Create a text string
//			File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

//			string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
//			Console.WriteLine(readText); // Output the content
//			Console.WriteLine(); // Leave one line








//			// Get the current directory where the program is running
//			string currentDirectory = Environment.CurrentDirectory;

//			// Prompt user to enter text
//			Console.WriteLine("Enter any random text to save in a file:");
//			string writeText = Console.ReadLine();

//			// Combine the current directory with the file name
//			string filePath = Path.Combine(currentDirectory, "filename.txt");

//			// Write the text to the file
//			File.WriteAllText(filePath, writeText);

//			// Read the text from the file
//			string readText = File.ReadAllText(filePath);

//			// Output the content
//			Console.WriteLine("Contents of the file:");
//			Console.WriteLine(readText);

//		}
//	}
//}