using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

    const int TOTAL_METALS = 3;
    const int TOTAL_GEMS = 10;

    enum Metals { SILVER, GOLD, PLATINUM };
    enum Gems { MALACHITE, AMETHYST, TURQUOIS, GARNET, SAPPHIRE, CITRINE, RUBY, EMERALD, DIAMOND, ALEXANDRITE };

    int[] metals = new int[3];
    int[] gems = new int[10];

    GameObject digger;
    GameObject sifter;
    GameObject hauler;
    GameObject gemCollector;
    GameObject structuralEngineer;

    Text silver;
    Text gold;
    Text platinum;

	// Use this for initialization
	void Start () 
    {
        for (int i = 0; i < TOTAL_METALS; i++)
        {
            metals[i] = 0;
        }

        for (int i = 0; i < TOTAL_GEMS; i++)
        {
            gems[i] = 0;
        }

        silver = GameObject.Find("Silver Image").transform.GetChild(0).GetComponent<Text>();
        gold = GameObject.Find("Gold Image").transform.GetChild(0).GetComponent<Text>();
        platinum = GameObject.Find("Platinum Image").transform.GetChild(0).GetComponent<Text>();

        updateUserInterface();
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}

    public int getMetal(char metal)
    {
        switch(metal)
        {
            case 's':
                return metals[(int)Metals.SILVER];
            case 'g':
                return metals[(int)Metals.GOLD];
            case 'p':
                return metals[(int)Metals.PLATINUM];
            default:
                return 0;
        }
    }

    public void updateUserInterface()
    {
        silver.text = "" + metals[(int)Metals.SILVER];
        gold.text = "" + metals[(int)Metals.GOLD];
        platinum.text = "" + metals[(int)Metals.PLATINUM];
    }

    public void increaseMetal(char metal, int amount)
    {
        if (amount <= 0)
        {
            return;
        }

        switch(metal)
        {
            case 's':
                metals[(int)Metals.SILVER] += amount;
                break;
            case 'g':
                metals[(int)Metals.GOLD] += amount;
                break;
            case 'p':
                metals[(int)Metals.PLATINUM] += amount;
                break;
            default:
                return;
        }
    }

    public void decreaseMetal(char metal, int amount)
    {
        if (amount <= 0)
        {
            return;
        }

        switch (metal)
        {
            case 's':
                metals[(int)Metals.SILVER] -= amount;
                if (metals[(int)Metals.SILVER] < 0)
                    metals[(int)Metals.SILVER] = 0;
                break;
            case 'g':
                metals[(int)Metals.GOLD] -= amount;
                if (metals[(int)Metals.GOLD] < 0)
                    metals[(int)Metals.GOLD] = 0;
                break;
            case 'p':
                metals[(int)Metals.PLATINUM] -= amount;
                if (metals[(int)Metals.PLATINUM] < 0)
                    metals[(int)Metals.PLATINUM] = 0;
                break;
            default:
                return;
        }
    }

    public bool assignDigger(GameObject nDigger)
    {
        if (digger != null)
            return false;
        
        digger = nDigger;
        return true;
    }

    public bool assignSifter(GameObject nSifter)
    {
        if (sifter != null)
            return false;

        sifter = nSifter;
        return true;
    }

    public bool assignHauler(GameObject nHauler)
    {
        if (hauler != null)
            return false;

        hauler = nHauler;
        return true;
    }

    public bool assignGemCollector(GameObject nGemCollector)
    {
        if (gemCollector != null)
            return false;

        gemCollector = nGemCollector;
        return true;
    }

    public bool assignStructuralEngineer(GameObject nStructuralEngineer)
    {
        if (structuralEngineer != null)
            return false;

        structuralEngineer = nStructuralEngineer;
        return true;
    }
}
