using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EnemyGeneration : MonoBehaviour
{
    public GameObject Enemy;
    public int min = -5;
    public int max = 5;
    float myTime = 0;
    int myTime2 = 0;
    int timer=0;
    public TextMeshProUGUI myTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Mathf.RoundToInt(Time.deltaTime);
        myTime += Time.deltaTime;
        myTime2 = Mathf.RoundToInt(myTime);
        PlaceCubes();

        myTimer.text = "time" + timer;
        if(timer>=50)
        {
            SceneManager.LoadScene(2);
        }
        if (myTime2 >= 5 && myTime2 <= 6)
        {
            Instantiate(Enemy, GeneratedPosition(), Quaternion.identity);
        }
        myTime = 0;
    }
    Vector3 GeneratedPosition()
    {
        int x, y, z;
        x = Random.Range(min, max);
        y = Random.Range(0, 1);
        z = Random.Range(min, max);
        return new Vector3(x, y, z);
    }
    void PlaceCubes()
    {

    }

}
