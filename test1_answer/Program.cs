Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine();

string[] words = sentence.Split(' ');
string lastWord = words[words.Length - 1];

int length = lastWord.Length;
Console.WriteLine(length);
Console.ReadKey();