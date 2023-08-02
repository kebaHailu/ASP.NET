using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordFrequency{

    public static Dictionary<string,int> WordFrequencyCount(string word){
        Dictionary<string,int> wordFrequency = new Dictionary<string,int>();
        string[] words = word.Split(' ');

        foreach(var wd in words){
            if (wordFrequency.ContainsKey(wd)){
                wordFrequency[wd]++;
            }
            else wordFrequency[wd] = 1;
            
        }
        
        return wordFrequency;



    }
    public static void Main(){
        Console.Write("Write words: ");
        string? word = Console.ReadLine();
        if (string.IsNullOrEmpty(word)){
            Console.WriteLine("Please Enter the valid input");
            return;
        }
        Dictionary<string,int> word_frequency =WordFrequencyCount(word);

        foreach(KeyValuePair<string,int>wrd in word_frequency){
            Console.WriteLine($"word-{wrd.Key}  occuerance-{wrd.Value}");

        }

    }
}
