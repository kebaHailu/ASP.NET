using System;
using System.Collections.Generic;


class Palindrome{
    public static bool Check(string word){
       
        int i = 0;
        int j = word.Length-1;

        while (i < j){
            if (word[i] != word[j]){
                return false;
            } 
            i++;
            j--;
        }
        return true;


    }
    public static void Main(){

        Console.Write("please Enter a valid input :");
        string? word = Console.ReadLine();
        

         if (string.IsNullOrEmpty(word))
        {
            Console.WriteLine("Invalid input. Please enter a non-null string.");
            return; 
        }

        word = word.Trim();
        word = word.ToLower();
        string cleanedWord = new(word.Where(c =>  !char.IsPunctuation(c)).ToArray());
        
        bool value = Check(cleanedWord);
        Console.WriteLine(value);

    }
}
