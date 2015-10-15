using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour {

    public Canvas mainCanvas;
    public Image silverImage;
    public Image goldImage;
    public Image platinumImage;
    public Button hireButton;
    public Button buildButton;
    public Button marketButton;
    private int silver;
    private int gold;
    private int platinum;

	// Use this for initialization
	void Start () 
    {
        silver = 0;
        gold = 0;
        platinum = 0;
        updateMetal();

	}
	
	// Update is called once per frame
	void Update () 
    {

	}

    void updateMetal()
    {
        silverImage.GetComponentInChildren<Text>().text = "" + silver;
        goldImage.GetComponentInChildren<Text>().text = "" + gold;
        platinumImage.GetComponentInChildren<Text>().text = "" + platinum;
    }
}
