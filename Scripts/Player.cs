using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject bullet;
  public float speed;

  private Transform t;
  private bool canShoot = true;
    private Transform shootingOffset;

    void Start()
    {
        t = GetComponent<Transform>();
        shootingOffset = GetComponentInChildren<Transform>();
    }

    void Update()
    {
      //if (Input.GetKeyDown(KeyCode.Space)) Debug.Log("Can shoot: " + canShoot);
      if (Input.GetKeyDown(KeyCode.Space) && canShoot)
      {
        GameObject shot = Instantiate(bullet, shootingOffset.position, Quaternion.identity);
        canShoot = false;

        Destroy(shot, 5f);
      }

        t.SetPositionAndRotation(new Vector2(t.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * speed,t.position.y), t.rotation);
    }

    public void setShoot(bool b)
    {
      canShoot = b;
    }
}
