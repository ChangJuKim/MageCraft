using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBehavior : MonoBehaviour
{
    public SpellData spellData;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * spellData.speed * Time.deltaTime);

    }
}
