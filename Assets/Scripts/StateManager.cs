using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : Singleton<StateManager>
{
    string _name;
    string _score;

    public string getName()
    { 
        return _name;
    }

    public void setName(string newName)
    {
        _name = newName;
    }

    public void setScore(string newScore)
    {
        _score = newScore;
    }

    public string getScore() 
    {
        return _score;
    }

}
