using UnityEngine;

public class MainController : MonoBehaviour
{
    //Global Variables
    private int[] labyrinth;
    private int wallsNumber   = 2;
    private int totalDoors    = 8;
    public char rotation; // Y or N
    public GameObject wall;

    void Start()
    {
        int i;
        int selectedWall;
        //Initialize variables
        labyrinth = new int[totalDoors];

        // We create the labyrinth
        for ( i = 0; i < wallsNumber; i++)
        {
            selectedWall = getRandom(i * 4, i * 4 + 3);
            labyrinth[selectedWall] = 1;
        }

        createLabyrinth(labyrinth);
    }

    void Update()
    {
        
    }

    /* Generates a random labyrinth */
    private void createLabyrinth(int[] labyrinth)
    {
        Quaternion currentRotation = Quaternion.Euler(90, 0, 0);
        Vector3 currentPosition;
        Vector3 wallWidth;
        float newXCoordinates;
        int i;

        wallWidth = wall.GetComponent<Collider>().bounds.size;

        for ( i = 0; i < totalDoors; i++ )
        {
            if ( labyrinth[i] == 0)
            {
                if( rotation == 'Y' )
                {
                    newXCoordinates = transform.position.z + (wallWidth.z * i);
                    currentPosition = new Vector3(transform.position.x, transform.position.y, newXCoordinates);
                    currentRotation = Quaternion.Euler(0, 90, 0);
                } else
                {
                    newXCoordinates = transform.position.x - (wallWidth.x * i);
                    currentPosition = new Vector3(newXCoordinates, transform.position.y, transform.position.z);
                    currentRotation = Quaternion.identity;
                }
                Instantiate(wall, currentPosition, currentRotation);
            }
        }
    }

    /* Get a random number in a specific range */
    private int getRandom( int min, int max )
    {
        int result = Random.Range(min, max);
        return result; 
    }
}
