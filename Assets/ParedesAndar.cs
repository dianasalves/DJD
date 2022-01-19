using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedesAndar : MonoBehaviour
{
    public GameObject parede;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Frente", 1);
    }
}
