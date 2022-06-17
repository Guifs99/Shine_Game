using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Morte : MonoBehaviour
{

    public GameObject implosion;
    public float faleceu;
    public Text mycounter;
    public int life = 1;
    public GameObject SpawnPoint;
    public int DeathCount = 0;


    private void OnParticleCollision(GameObject other)
    {
        life--;

        if (life < 0)
        {
            Instantiate(implosion, transform.position, Quaternion.identity);
            //Destroy(gameObject);//
            if (SpawnPoint)
            {
                transform.position = SpawnPoint.transform.position;
                DeathCount = DeathCount + 1;
                faleceu = DeathCount;
                mycounter.text = faleceu.ToString("0");
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }
}
