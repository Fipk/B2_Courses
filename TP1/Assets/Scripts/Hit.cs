using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(other.gameObject);
        SceneManager.LoadScene(2);
    }
}
