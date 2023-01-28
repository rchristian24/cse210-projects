using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
public class Journal
{
    public List<string> _prompts = new List<string>(){
    "Prompt: Who was the most interesting person I interacted with today?",
    "Prompt: What made me smile today?",
    "Prompt: How did I see the Lord's hand in my life today?",
    "Prompt: Who do I admire? ",
    "Prompt: What am I struggling with?",
    "Prompt: What am I grateful for today?",
    "Prompt: If I had one thing to do over, what would it be?",
    "Prompt: What was something beautiful I saw today?",
    "Prompt: If I were an animal, what animal would I be?",
    "Prompt: If I were a color what color would I be?",
    "Prompt: What is my favorite memory?",
    "Prompt: What makes me laugh?"
    };


    public int _counter = 0;
    public Random random = new Random();

    public List<Entry> _entryList = new List<Entry>();
    public List<UserEntry> _userEntryList = new List<UserEntry>();
    public void Shuffle()
    {
        int lastIndex = _prompts.Count() - 1;

        while (lastIndex > 0)
        {
            string tempValue = _prompts[lastIndex];
            int randomIndex = new Random().Next(0, lastIndex);
            _prompts[lastIndex] = _prompts[randomIndex];
            _prompts[randomIndex] = tempValue;
            lastIndex--;
        }
    }
    public void GeneratePrompt()
    {

        if (_counter > _prompts.Count)
        {
            _counter = 0;
        }

        Console.WriteLine($"{_prompts[_counter]}");
        Console.Write(">");

        string response = Console.ReadLine();
        string date = "1/24/2023";
        AddEntry(_prompts[_counter], date, response);
        _counter++;

    }


    public void AddEntry(string prompt, string date, string response)
    {
        Entry entry = new Entry();
        entry._date = date;
        entry._prompt = prompt;
        entry._response = response;
        _entryList.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entryList)
        {
            entry.DisplayEntry();
        }
    }
    public void Save()
    {

        Console.WriteLine("What name would you like to save this file under?");
        Console.Write(">");
        string userFilename = Console.ReadLine();
        string file = userFilename;

        using (StreamWriter outputFile = new StreamWriter(file))
        {


            foreach (Entry entry in _entryList)
            {

                outputFile.WriteLine($"{entry._date} - {entry._prompt}");
                outputFile.WriteLine($"{entry._response}");
                outputFile.WriteLine(" ");

            }

        }

    }


    public void Load()
    {
        Console.WriteLine("What file would you like to load?");
        Console.Write(">");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        Entry entry = new Entry();

        foreach (string line in lines)
        {

            string[] parts = line.Split(" - ");
            if (parts.Length == 2)
            {
                string date = parts[0];
                string prompt = parts[1];
                entry._date = date;
                entry._prompt = prompt;
            }
            else
            {
                string response = parts[0];
                entry._response = response;
                _entryList.Add(entry);
                entry = new Entry();
            }
        }
    }

    //UserEntries//
    public void UserPrompt()
    {
        Console.WriteLine("What is your prompt you would like to write about?");
        Console.Write(">");
        string _userPrompt = Console.ReadLine();
        Console.WriteLine("Write the response to your prompt here: ");
        Console.Write(">");
        string _userResponse = Console.ReadLine();
        string _userDate = "1/24/2023";
        AddUserEntry(_userPrompt, _userDate, _userResponse);
    }

    public void AddUserEntry(string userPrompt, string userDate, string userResponse)
    {
        UserEntry userEntry = new UserEntry();
        userEntry._userDate = userDate;
        userEntry._userPrompt = userPrompt;
        userEntry._userResponse = userResponse;
        _userEntryList.Add(userEntry);


    }
    public void UserDisplay()
    {
        foreach (UserEntry userEntry in _userEntryList)
        {
            userEntry.DisplayUserEntry();
        }
    }
    public void UserLoad()
    {

        Console.WriteLine("What personal prompt file would you like to load?");
        Console.Write(">");
        string filename = Console.ReadLine();
        UserEntry userEntry = new UserEntry();
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        
        foreach (string line in lines)

        {
            string[] parts = line.Split(" - ");
            if (parts.Length == 2)
            {

                string userDate = parts[0];
                string userPrompt = parts[1];

                userEntry._userDate = userDate;
                userEntry._userPrompt = userPrompt;
            }
            else
            {
                string userResponse = parts[0];
                userEntry._userResponse = userResponse;
                _userEntryList.Add(userEntry);
                userEntry = new UserEntry();
            }
        }

    }

    public void UserEntrySave()
    {
        Console.WriteLine("What name would you like to save this personal prompt file under?");
        Console.Write(">");
        string userFilename = Console.ReadLine();
        string file = userFilename;

        using (StreamWriter outputFile = new StreamWriter(file))
        {


            foreach (UserEntry userEntry in _userEntryList)
            {
                outputFile.WriteLine($"{userEntry._userDate} - {userEntry._userPrompt}");
                outputFile.WriteLine($"{userEntry._userResponse}");

            }
        }
    }
    // Combine computer-generated and user prompts|responses//
    public void DisplayAll()
    {
        Display();
        UserDisplay();
    }


    
    
}

