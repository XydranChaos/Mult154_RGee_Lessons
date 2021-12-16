using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmBrain : MonoBehaviour
{
    //While it has the hive, patrol around the hive
    //When no hive, pursue the player
    // Start is called before the first frame update
    private bool hasHive = true;
    private Patrol patrol;
    private Bot bot;
    void Start()
    {
        patrol = GetComponent<Patrol>();
        bot = GetComponent<Bot>();
        HivePickUp.HivePickedUp += HiveTaken;
    }

    void HiveTaken()
    {
        hasHive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasHive)
        {
            patrol.PatrolWaypoints();
        }
        else
        {
            bot.Pursue();
        }
    }
}
