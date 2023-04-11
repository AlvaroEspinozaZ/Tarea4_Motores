using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{
    Rigidbody rgb;
    [Range(0,10)][SerializeField] float speedPlayer;
    float H, V;
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoving();
    }

    public void PlayerMoving()
    {        
        H = Input.GetAxis("Horizontal");
        V = Input.GetAxis("Vertical");
        rgb.velocity = new Vector3(H * speedPlayer,0,V*speedPlayer);
    }
}
