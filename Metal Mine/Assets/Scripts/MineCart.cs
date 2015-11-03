using UnityEngine;
using System.Collections;

public class MineCart : MonoBehaviour 
{
    private bool movingRight;
    private bool movingLeft;
    private bool isMoving;
    private bool isFull;

    private GameObject mineCart;
    private GameObject leftWheel;
    private GameObject rightWheel;
    private GameObject[] rocks;

    private Vector3 right;
    private Vector3 left;

    private const int LEFT = 1;
    private const int RIGHT = 2;

    private const float SPEED_EMPTY = 0.5f;
    private const float SPEED_25 = 0.4f;
    private const float SPEED_50 = 0.3f;
    private const float SPEED_75 = 0.2f;
    private const float SPEED_100 = 0.1f;

    private const int FILL_EMPTY = 0;
    private const int FILL_25 = 1;
    private const int FILL_50 = 2;
    private const int FILL_75 = 3;
    private const int FILL_100 = 4;

    private int fillLevel;

    private bool needUpdateFill;

	// Use this for initialization
	void Start () 
    {
        movingRight = false;
        movingLeft = false;
        isMoving = false;
        isFull = false;

        mineCart = this.gameObject;
        leftWheel = mineCart.transform.GetChild(0).gameObject;
        rightWheel = mineCart.transform.GetChild(1).gameObject;

        right = new Vector3(0, 0, 1);
        left = new Vector3(0, 0, -1);

        rocks = new GameObject[3];
        rocks[0] = mineCart.transform.GetChild(2).gameObject;
        rocks[1] = mineCart.transform.GetChild(3).gameObject;
        rocks[2] = mineCart.transform.GetChild(4).gameObject;

        fillLevel = 3;

        needUpdateFill = false;

        updateFillLevel();

	}

    public void moveCart(int dir)
    {
        if (dir == LEFT)
        {
            pushLeft();
        }
        else if (dir == RIGHT)
        {
            pushRight();
        }
        else
        {
            Debug.Log("Invalid direction");
            return;
        }

        isMoving = true;
    }

    void pushLeft()
    {
        movingLeft = true;
        movingRight = false;
    }

    void pushRight()
    {
        movingRight = true;
        movingLeft = false;
    }

    public void stopCart()
    {
        isMoving = false;
        movingLeft = false;
        movingRight = false;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (!isMoving)
            return;

        if (isMoving && movingRight)
        {
            leftWheel.transform.Rotate(left, SPEED_EMPTY*2);
            rightWheel.transform.Rotate(left, SPEED_EMPTY*2);
            mineCart.transform.position = new Vector2(mineCart.transform.position.x + SPEED_EMPTY * Time.deltaTime, mineCart.transform.position.y);
        }
        else if (isMoving && movingLeft)
        {
            leftWheel.transform.Rotate(right, 1);
            rightWheel.transform.Rotate(right, 1);
            mineCart.transform.position = new Vector2(mineCart.transform.position.x - SPEED_EMPTY * Time.deltaTime, mineCart.transform.position.y);
        }

        if (needUpdateFill)
        {
            updateFillLevel();
            needUpdateFill = false;
        }
	}

    void updateFillLevel()
    {
        if (fillLevel == FILL_EMPTY)
        {
            rocks[0].gameObject.SetActive(false);
            rocks[1].gameObject.SetActive(false);
            rocks[2].gameObject.SetActive(false);
        }
        else if (fillLevel == FILL_25)
        {
            rocks[0].gameObject.SetActive(false);
            rocks[1].gameObject.SetActive(false);
            rocks[2].gameObject.SetActive(false);
        }
        else if (fillLevel == FILL_50)
        {
            rocks[0].gameObject.SetActive(true);
            rocks[1].gameObject.SetActive(false);
            rocks[2].gameObject.SetActive(false);
        }
        else if (fillLevel == FILL_75)
        {
            rocks[0].gameObject.SetActive(true);
            rocks[1].gameObject.SetActive(true);
            rocks[2].gameObject.SetActive(false);
        }
        else if (fillLevel == FILL_100)
        {
            rocks[0].gameObject.SetActive(true);
            rocks[1].gameObject.SetActive(true);
            rocks[2].gameObject.SetActive(true);
        }
    }
}
