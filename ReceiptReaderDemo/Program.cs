using ReceiptReaderDemo;

string path = Environment.GetCommandLineArgs()[1];

if (!File.Exists(path))
    throw new FileNotFoundException($"File not found at {path}");

Console.WriteLine("Reading receipt...");
ReceiptReader receiptReader = new();
string content = await receiptReader.Read(path);
Console.WriteLine("\tSucceeded");


Console.WriteLine(content);