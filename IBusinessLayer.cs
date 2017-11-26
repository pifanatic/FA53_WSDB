﻿using System;
using System.Collections.Generic;

public interface IBusinessLayer
{
    void AddGame(string name, string developerName);

    void AddDeveloper(string name);

    void EditGame(string newName, string oldName);

    void EditDeveloper(string newName, string oldName);

    void DeleteGame(string name);

    void DeleteDeveloper(string name);

    List<Game> GetGames();

    List<Developer> GetDevelopers();
}