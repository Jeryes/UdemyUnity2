using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game State
    int level;
    string password;

    enum Screen { MainMenu, Password, Win }
    Screen currentScreen;

    // Use this for initialization
    void Start () {
        ShowMainMenu();
    }

    void ShowMainMenu () {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack today?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for Snow White's Diary");
        Terminal.WriteLine("Press 2 for Gringotts Bank");
        Terminal.WriteLine("Press 3 for Athena");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu") {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = "bashful";
            StartGame();
            
        }
        else if (input == "2")
        {
            level = 2;
            password = "mandrake";
            StartGame();
        }
        else if (input == "69")
        {
            Terminal.WriteLine("You nasty boy!");
        }
        else if (input == "mario")
        {
            Terminal.WriteLine("▒▒▒▒▒▒▒▒▒▄▄▄▄▒▒▒▒▒▒▒");
            Terminal.WriteLine("▒▒▒▒▒▒▄▀▀▓▓▓▓█▒▒▒▒▒▒");
            Terminal.WriteLine("▒▒▒▒▄▀▓▓▄▄██████▄▒▒▒");
            Terminal.WriteLine("▒▒▒▄█▄▄█▀░░▄░█▀▀▒▒▒▒");
            Terminal.WriteLine("▒▒▒█░░██▄░░▀░▀▀▀▄▒▒▒");
            Terminal.WriteLine("▒▒▒▀▄░░▀░▄█▄░░░▄▀▒▒▒");
            Terminal.WriteLine("▒▒▒▒▄██▄░░░▀▀█▀▒▒▒▒▒");
            Terminal.WriteLine("▒▒▒▄▀▓▓▀██▀▀▀▄▒▒▒▒▒▒");
            Terminal.WriteLine("▒▒▒█▓▓▓▓█░░░░░█▒▒▒▒▒");
            Terminal.WriteLine("▒▒▒██▄▓▓▓█▄▄▄█▀█▒▒▒▒");
            Terminal.WriteLine("▒▒▒▒██████▄▄██▄█▒▒▒▒");
            Terminal.WriteLine("▒▒▒▒███████████▒▒▒▒▒");
            Terminal.WriteLine("▒▒▒▒▒█▀▀▀▀▀█▀▀▒▒▒▒▒▒");
            Terminal.WriteLine("▒▒▒▒▒█▄▄▄▄▄▄█▒▒▒▒▒▒▒");
        }
        else
        {
            Terminal.WriteLine("Please enter a valid selection.");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password.");
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Access granted.");
        }
        else
        {
            Terminal.WriteLine("Incorrect password. Try again.");
        }
    }
}
