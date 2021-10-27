using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    public GameObject _upgrade = null;

    private GameObject upgrade {  get { return _upgrade; } }

    private List<Enemy> enemies { get; set; } = null;

    private float fireRate { get; set; } = 0.1f;
    private float currentFireRate { get; set; } = 0.0f;

private void Start()
    {
        enemies = new List<Enemy>();
    }


private void Update()
    {
        
    }

public void Upgrade()
    {
        if (upgrade == null)
        {
            return;
        }
        Instantiate (upgrade, transform.position, transform.rotation);
        Destroy (gameObject);
    }
private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy == null)
        {
            enemies.Add(enemy);
        }
    }
private void OnTriggerExit(Collider other)
    { 
    Enemy enemy = other.GetComponent<Enemy>();
            if(enemy != null)
            {
            enemies.Remove(enemy);
            }
    
}
}