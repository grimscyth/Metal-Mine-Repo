using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour 
{

    private Canvas mainCanvas;

    private Button hireButton;
    private Button buildButton;
    private Button marketButton;

    private GameController gameController;

    public GameObject diggerPrefab;
    public GameObject haulerPrefab;
    public GameObject sifterPrefab;
    public GameObject gemCollectorPrefab;
    public GameObject structuralEngineerPrefab;

    //private GameObject workerTypeSelect;

	void Start () 
    {
        mainCanvas = GameObject.Find("Main Game Overlay").GetComponent<Canvas>();

        hireButton = GameObject.Find("Hire Button").GetComponent<Button>();
        buildButton = GameObject.Find("Build Button").GetComponent<Button>();
        marketButton = GameObject.Find("Market Button").GetComponent<Button>();

        gameController = this.GetComponent<GameController>();

        //workerTypeSelect = GameObject.Find("Worker Type Select");
        //workerTypeSelect.SetActive(false);
	}

    /*
    public void hireWorker()
    {
        workerTypeSelect.SetActive(true);
    }


    public void selectWorker(string type)
    {
        GameObject temp;

        switch(type)
        {
            case "d":
                temp = Instantiate(diggerPrefab) as GameObject;
                gameController.assignDigger(temp);
                break;
            case "h":
                temp = Instantiate(haulerPrefab) as GameObject;
                gameController.assignHauler(temp);
                break;
            case "s":
                temp = Instantiate(sifterPrefab) as GameObject;
                gameController.assignSifter(temp);
                break;
            case "g":
                temp = Instantiate(gemCollectorPrefab) as GameObject;
                gameController.assignGemCollector(temp);
                break;
            case "e":
                temp = Instantiate(structuralEngineerPrefab) as GameObject;
                gameController.assignStructuralEngineer(temp);
                break;
            default:
                Debug.Log("Error: Worker type not found!");
                break;
        }

        workerTypeSelect.SetActive(false);
    }*/

}
