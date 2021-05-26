using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DestroyingEnemy : MonoBehaviour
{

    public int score;
    public TextMeshProUGUI myScore;
    // Start is called before the first frame update
    void Start()
    {
        myScore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            Destroy(other.gameObject);
            score++;
            myScore.text = "score:" + score;
        }
    }
}
