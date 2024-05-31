using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;  // Enemy the flashlight is attached to
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Player") {
            Debug.Log("player detected");
            Enemy.GetComponent<Enemy>().ChangeState(CopState.ChasePlayer);
        }
    }
}