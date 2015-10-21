using UnityEngine;
using System.Collections;

public class Worker : MonoBehaviour 
{
    GameController gameController;

    //UserInterface userInterface;

    protected string workerName;
    protected int experience;
    protected int level;

    public void Start()
    {
        workerName = "Bob";
        experience = 0;
        level = 1;

        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        //userInterface = gameController.GetComponent<UserInterface>();
    }

    public void changeName(string nName)
    {
        workerName = nName;
    }

    public string getName()
    {
        return workerName;
    }

    private bool checkLevelUp(int level)
    {
        if (level == 1 && experience >= 100)
        {
            return true;
        }
        if (level == 2 && experience >= 200)
        {
            return true;
        }
        if (level == 3 && experience >= 300)
        {
            return true;
        }
        if (level == 4 && experience >= 400)
        {
            return true;
        }
        if (level == 5 && experience >= 500)
        {
            return true;
        }
        if (level == 6 && experience >= 600)
        {
            return true;
        }
        if (level == 7 && experience >= 700)
        {
            return true;
        }
        if (level == 8 && experience >= 800)
        {
            return true;
        }
        if (level == 9 && experience >= 900)
        {
            return true;
        }
        if (level == 10 && experience >= 1000)
        {
            return true;
        }

        return false;

    }
}
