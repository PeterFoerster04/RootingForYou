using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    float speedBoost = 10f;
    GameObject player;
    MouseMovement playerScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player = collision.gameObject;
            playerScript = player.GetComponent<MouseMovement>();

            if (playerScript)
            {

				playerScript.downfallValue -= speedBoost;
				Destroy(gameObject);

			}
        }
    }



    IEnumerator TimerForDisable()
    {
        playerScript.downfallValue -= speedBoost;
        Destroy(gameObject);

        yield return new WaitForSeconds(2);

        playerScript.downfallValue += speedBoost;
    }

}
