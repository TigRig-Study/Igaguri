using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
  private Rigidbody igaguri;
  private void Start()
  {
    igaguri = GetComponent<Rigidbody>();
    Shoot(new Vector3(0, 200, 2000));
  }

  public void Shoot(Vector3 dir)
  {
    igaguri.AddForce(dir);
  }

  private void OnCollisionEnter(Collision other)
  {
    igaguri.isKinematic = true;
  }
}
