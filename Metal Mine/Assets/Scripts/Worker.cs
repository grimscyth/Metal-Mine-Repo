using UnityEngine;
using System.Collections;

public class Worker : MonoBehaviour 
{
    string name;
    int diggerLevel;
    int diggerExperience;
    int haulerLevel;
    int haulerExperience;
    int sifterLevel;
    int sifterExperience;
    int gemCollectorExperience;
    int gemCollectorLevel;
    int structuralEngineerLevel;
    int structuralEngineerExperience;

    public Worker(string nName = "Bob")
    {
        name = nName;
        diggerLevel = 1;
        diggerExperience = 0;
        haulerLevel = 1;
        haulerExperience = 0;
        sifterLevel = 1;
        sifterExperience = 0;
        gemCollectorLevel = 1;
        gemCollectorExperience = 0;
        structuralEngineerLevel = 1;
        structuralEngineerExperience = 0;
    }

    public void changeName(string nName)
    {
        name = nName;
    }

    public int getDiggerLevel()
    {
        return diggerLevel;
    }

    public void incrementDiggerLevel()
    {
        diggerLevel++;
    }

    public int getDiggerExperience()
    {
        return diggerExperience;
    }

    public void increaseDiggerExperience(int exp)
    {
        diggerExperience += exp;
    }

    public int getHaulerLevel()
    {
        return haulerLevel;
    }

    public void incrementHaulerLevel()
    {
        haulerLevel++;
    }

    public int getHaulerExperience()
    {
        return haulerExperience;
    }

    public void increaseHaulerExperience(int exp)
    {
        haulerExperience += exp;
    }

    public int getSifterLevel()
    {
        return sifterLevel;
    }

    public void incrementSifterLevel()
    {
        sifterLevel++;
    }

    public int getSifterExperience()
    {
        return sifterExperience;
    }

    public void increaseSifterExperience(int exp)
    {
        sifterExperience += exp;
    }

    public int getGemCollectorLevel()
    {
        return gemCollectorLevel;
    }

    public void incrementGemCollectorLevel()
    {
        gemCollectorLevel++;
    }

    public int getGemCollectorExperience()
    {
        return gemCollectorExperience;
    }

    public void increaseGemCollectorExperience(int exp)
    {
        gemCollectorExperience += exp;
    }

    public int getStructuralEngineerLevel()
    {
        return structuralEngineerLevel;
    }

    public void incrementStructuralEngineerLevel()
    {
        structuralEngineerLevel++;
    }

    public int getStructuralEngineerExperience()
    {
        return structuralEngineerExperience;
    }

    public void increaseStructuralEngineerExperience(int exp)
    {
        structuralEngineerExperience += exp;
    }

    private bool checkLevelUp(int skillLevel, int exp)
    {
        if (skillLevel == 1 && exp >= 100)
        {
            return true;
        }
        if (skillLevel == 2 && exp >= 200)
        {
            return true;
        }
        if (skillLevel == 3 && exp >= 300)
        {
            return true;
        }
        if (skillLevel == 4 && exp >= 400)
        {
            return true;
        }
        if (skillLevel == 5 && exp >= 500)
        {
            return true;
        }
        if (skillLevel == 6 && exp >= 600)
        {
            return true;
        }
        if (skillLevel == 7 && exp >= 700)
        {
            return true;
        }
        if (skillLevel == 8 && exp >= 800)
        {
            return true;
        }
        if (skillLevel == 9 && exp >= 900)
        {
            return true;
        }
        if (skillLevel == 10 && exp >= 1000)
        {
            return true;
        }

        return false;

    }
}
