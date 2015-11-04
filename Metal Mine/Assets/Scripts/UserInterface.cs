using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour 
{

    private Canvas mainCanvas;

    private GameController gameController;
    private GameObject selectionWindowHire;

    private bool selectionWindowHireOpen;
    private bool selectionWindowHireClosed;
    private bool selectionWindowHireOpening;
    private bool selectionWindowHireClosing;

    private const int selectionWindowHireOpenX = 810;
    private const int selectionWindowHireClosedX = 1110;

    private GameObject prefabDigger;
    private GameObject prefabHauler;
    private GameObject prefabSifter;
    private GameObject prefabGemCollector;
    private GameObject prefabStructuralEngineer;

	void Start () 
    {
        gameController = this.GetComponent<GameController>();
        mainCanvas = GameObject.Find("canvasMain").GetComponent<Canvas>();
        selectionWindowHire = GameObject.Find("selectionWindowHire");

        selectionWindowHireOpen = false;
        selectionWindowHireClosed = true;
        selectionWindowHireOpening = false;
        selectionWindowHireClosing = false;

        prefabDigger = (GameObject)Resources.Load("Prefabs/digger", typeof(GameObject));
        prefabHauler = (GameObject)Resources.Load("Prefabs/hauler", typeof(GameObject));
        prefabSifter = (GameObject)Resources.Load("Prefabs/sifter", typeof(GameObject));
        prefabGemCollector = (GameObject)Resources.Load("Prefabs/gemCollector", typeof(GameObject));
        prefabStructuralEngineer = (GameObject)Resources.Load("Prefabs/structuralEngineer", typeof(GameObject));
	}

    void Update()
    {
        if (selectionWindowHireOpening)
        {
            openSelectionWindowHire();
        }
        else if (selectionWindowHireClosing)
        {
            closeSelectionWindowHire();
        }
    }
    
    public void hireWorker()
    {
        if (selectionWindowHireClosed && !selectionWindowHireOpening)
        {
            selectionWindowHireOpening = true;
            selectionWindowHireClosing = false;
            selectionWindowHireClosed = false;
        }
        else if (selectionWindowHireOpen && !selectionWindowHireClosing)
        {
            selectionWindowHireClosing = true;
            selectionWindowHireOpening = false;
            selectionWindowHireOpen = false;
        }
        else if (selectionWindowHireClosing)
        {
            selectionWindowHireOpening = true;
            selectionWindowHireClosing = false;
        }
        else if (selectionWindowHireOpening)
        {
            selectionWindowHireClosing = true;
            selectionWindowHireOpening = false;
        }
    }

    private void openSelectionWindowHire()
    {
        if (selectionWindowHire.transform.localPosition.x >= selectionWindowHireOpenX)
        {
            selectionWindowHire.transform.localPosition = new Vector3(selectionWindowHire.transform.localPosition.x - 10,
                                                                      selectionWindowHire.transform.localPosition.y,
                                                                      selectionWindowHire.transform.localPosition.z);
        }

        if (selectionWindowHire.transform.localPosition.x < selectionWindowHireOpenX)
        {
            selectionWindowHire.transform.localPosition = new Vector3(selectionWindowHireOpenX,
                                                                      selectionWindowHire.transform.localPosition.y,
                                                                      selectionWindowHire.transform.localPosition.z);
        }

        if (selectionWindowHire.transform.localPosition.x == selectionWindowHireOpenX)
        {
            selectionWindowHireOpen = true;
            selectionWindowHireOpening = false;
        }
    }

    private void closeSelectionWindowHire()
    {
        if (selectionWindowHire.transform.localPosition.x <= selectionWindowHireClosedX)
        {
            selectionWindowHire.transform.localPosition = new Vector3(selectionWindowHire.transform.localPosition.x + 10,
                                                                      selectionWindowHire.transform.localPosition.y,
                                                                      selectionWindowHire.transform.localPosition.z);
        }

        if (selectionWindowHire.transform.localPosition.x > selectionWindowHireClosedX)
        {
            selectionWindowHire.transform.localPosition = new Vector3(selectionWindowHireClosedX, 
                                                                      selectionWindowHire.transform.localPosition.y,
                                                                      selectionWindowHire.transform.localPosition.z);
        }

        if (selectionWindowHire.transform.localPosition.x == selectionWindowHireOpenX)
        {
            selectionWindowHireClosed = true;
            selectionWindowHireClosing = false;
        }
    }

    public void hireDigger()
    {
        Instantiate(prefabDigger);
    }

    public void hireHauler()
    {
        Instantiate(prefabHauler);
    }

    public void hireSifter()
    {
        Instantiate(prefabSifter);
    }

    public void hireGemCollector()
    {
        Instantiate(prefabGemCollector);
    }

    public void hireStructuralEngineer()
    {
        Instantiate(prefabStructuralEngineer);
    }
}
