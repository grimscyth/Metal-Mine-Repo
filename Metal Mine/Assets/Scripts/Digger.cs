using UnityEngine;
using System.Collections;

public class Digger : Worker {

    const int MAX_DIG = 10;
    const int MAX_KNOWLEDGE = 10;
    const int MAX_TREASURE = 10;
    const int MAX_LEVEL = 10;

    // TRAITS
    int digSpeed;
    int pickKnowledge;
    int treasure;

    int pickPower;
    int digPower;
    int totalDigPower;

    bool mineCartNearby;
    bool isDigging;

	void Start () 
    {
        name = "Digger";

        digSpeed = 1;
        pickKnowledge = 1;
        treasure = 1;

        pickPower = 1;
        digPower = 1;
        
        setTotalDigPower();
	}

    public int getDigSpeed()
    {
        return digSpeed;
    }

    public bool incDigSpeed()
    {
        if (digSpeed < MAX_DIG)
        {
            digSpeed++;
            return true;
        }

        return false;
    }

    public int getPickKnowledge()
    {
        return pickKnowledge;
    }

    public bool incPickKnowledge()
    {
        if (pickKnowledge < MAX_KNOWLEDGE)
        {
            pickKnowledge++;
            return true;
        }

        return false;
    }

    public int getTreasure()
    {
        return treasure;
    }

    public bool incTreasure()
    {
        if (treasure < MAX_TREASURE)
        {
            treasure++;
            return true;
        }

        return false;
    }

    public void setTotalDigPower()
    {
        digPower = (digSpeed * level) + (pickKnowledge * pickPower);
    }
}
