using UnityEngine;

public class RealWorldData : MonoBehaviour
{
    public float costLumber { get; private set; }
    public float costActualAverageLumber { get; private set; }
    public float costActualLumber { get; private set; }
    public float costGold { get; private set; }
    public float costActualAverageGold { get; private set; }
    public float costActualGold { get; private set; }
    public float costCopper { get; private set; }
    public float costActualAverageCopper { get; private set; }
    public float costActualCopper { get; private set; }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* 
        The prices of each resource will be based on real world data but not exactly the same instead it will be 
        calculated as a base value subtract % difference from the daily average.

        - get last 24 hours of lumber, gold, and copper prices from an API
        - average the price for each based on 5 min intervals (this will be costActualAverage variables)
        - get the most recent price for each (this will be costActual variables)

        */

    }

    //every 5 mins update prices to reflect real world data
}
