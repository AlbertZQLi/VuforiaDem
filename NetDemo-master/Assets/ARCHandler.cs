using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARCHandler : MonoBehaviour
{
  // Start is called before the first frame update

  public static ARCHandler singleton;

  private void Awake()
  {
    DontDestroyOnLoad(gameObject);
    if (singleton == null)
      singleton = this;
    else
      Destroy(gameObject);
  } 
  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
