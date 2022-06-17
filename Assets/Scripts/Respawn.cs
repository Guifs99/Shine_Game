
using UnityEngine;
	using System.Collections;
	
	public class Respawn : MonoBehaviour {
	
	public Vector3 SpawnPoint;
	
	void OnTriggerEnter (Collider col)
	{
if (col.tag == "Player")
	{
    col.gameObject.GetComponent<Morte>().SpawnPoint=gameObject;
	}
    }
    }
