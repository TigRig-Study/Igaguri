using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
  private Rigidbody igaguri;
  private ParticleSystem particle;
  private void Awake()
  {
    igaguri = GetComponent<Rigidbody>();
    particle = GetComponent<ParticleSystem>();
  }

  public void Shoot(Vector3 dir)
  {
    igaguri.AddForce(dir);
  }

  private void OnCollisionEnter(Collision other)
  {
    igaguri.isKinematic = true;
    particle.Play();
  }
}
