using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public void AttackGobelin()
    {
        
        GameObject.Find("Score").GetComponent<Gobelin>().health--;
        GameObject.Find("Score").GetComponent<Gobelin>().DisplayValue();
    }
}
