using UnityEngine;
using System.Collections;

public class MineCart : MonoBehaviour 
{
    public bool movingRight;
    public bool movingLeft;
    public bool isMoving;
    public bool isFull;

    public GameObject mineCart;
    public GameObject leftWheel;
    public GameObject rightWheel;
    public GameObject[] rocks;

    public Vector3 right;
    public Vector3 left;

    public const int LEFT = 1;
    public const int RIGHT = 2;

    public const float SPEED_EMPTY = 0.5f;
    public const float SPEED_25 = 0.4f;
    public const float SPEED_50 = 0.3f;
    public const float SPEED_75 = 0.2f;
    public const float SPEED_100 = 0.1f;

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
	}
}
