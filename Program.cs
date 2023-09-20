﻿using System.Collections.Generic;
using System.Collections;

//adds initialization of the topGames dictionary with 10 entries.
Dictionary<int, string> topGames = new Dictionary<int, string>();
topGames.Add(1, "tiny Tina's Wonderlands");
topGames.Add(2, "CS:GO");
topGames.Add(3, "Halo 3");
topGames.Add(4, "Elden Ring");
topGames.Add(5, "Sonic Adventure 2");
topGames.Add(6, "Kirby Airride");
topGames.Add(7, "Donkey Kong 64");
topGames.Add(8, "Runescape");
topGames.Add(9, "GTA: San Andress");
topGames.Add(10, "Valorant");

//adds a foreach loop to iterate through the topGames dictionary using KeyValuePair<int, string> and implemented console output to display keys and values for each KeyValuePair in the topGames dictionary.
foreach (KeyValuePair<int, string> kvp in topGames)
{
    Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
}

//adds conditional check to verify if the 'topGames' dictionary that contains a key with value '1' and implemented a console output statement to display the favorite game when key '1' is present in 'topGames'
if (topGames.ContainsKey(1))
{
    Console.WriteLine($"My favorite game is: {topGames[1]}");
}

//initialize an empty string variable named "result"
string result = "";

//implemented a call to 'TryGetValue' on 'topGames' dictionary with key 11, assigning the result to the 'result' variable.
topGames.TryGetValue(11, out result);

//adds a conditional check to verify if the "result" variable is not an empty string before displaying its contents using Console.WriteLine and Implemented an alternative message in case the "result" variable is empty, indicating the absence of a game in the eleventh position.
if (result != "")
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("There is no game in the eleventh position.");
}

//adds a conditional check to ensure the presence of a key "5" in the topGames dictionary before attempting to update its value and Updated the value associated with key "5" in the topGames dictionary to "Rocket League".
if (topGames.ContainsKey(5))
{
    topGames[5] = "rocket League";
}

//adds a console output to display the element at index 5 in 'topGames' array using WriteLine."
Console.WriteLine(topGames[5]);

//creates a hashTable called 'haskTable' and populate it with the elements from the 'topGames' collection.
Hashtable haskTable = new Hashtable(topGames);

//adds a type cast to explicitly convert the value retrieved from the 'haskTable' at index 1 to a string and assign it to the 'favGame' variable.
string favGame = (string)haskTable[1];

//adds a console output to display the favorite game using the variable favGame.
Console.WriteLine($"Favorite Game: {favGame}");

//adds a Hashtable named 'capitals' and initialized it with key-value pairs for Oklahoma, New York, Texas, and Ohio capitals.
Hashtable capitals = new Hashtable()
{
    { "Oklahoma", "Oklahoma city" },
    { "New york", "Albany" },
    { "Taxas", "Austin" },
    { "Ohio", "Colombus" }
};

//adds a foreach loop to iterate through the 'capitals' dictionary using 'DictionaryEntry' objects.
foreach (DictionaryEntry kvp in capitals)
{
    Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
}

//clear the 'capitals' collection, removing all elements.
capitals.Clear();
