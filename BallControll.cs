using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class BallControll : MonoBehaviour
{

    Rigidbody fizik;
    public int hiz;
    int score = 0;
    public int plus;
    public Text scoreText;
    public Text finished;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        
    }

   
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vec*hiz);

       // Debug.Log("dikey= " + dikey);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            Destroy(other.gameObject);
            score++;

            scoreText.text = "Score: " + score;

            if (score == plus)
            {
                finished.text = "Game Finished";
            }
        }
        
    }
}
