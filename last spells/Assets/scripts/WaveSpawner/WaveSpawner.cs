using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Wave
{
   public List<GameObject> wave = new List<GameObject>();
}

public class WaveSpawner : MonoBehaviour
{
   public int stage;
    GameObject stageboss;
    int _currentwave = 0;
    ClearScript clear;
    [SerializeField]private List<GameObject> enemies = new List<GameObject>();

   [SerializeField] public List<Wave> waves = new List<Wave>();
    // Start is called before the first frame update
    void Start()
    {

        clear = GameObject.Find("clearobject").GetComponent<ClearScript>();

        print(waves[_currentwave].wave.Count); 
        Nextwave();
    }

    private void Update()
    {
        


        if (GameObject.FindGameObjectsWithTag("enemy").Length == 0)
        {
            if (_currentwave > waves.Count-1)
            {
                clear.StageCleared(stage);
                SceneManager.LoadScene("levelselect");
                return;
            }
          Nextwave();
        }
       
    }
    void Nextwave()
    {
        
       

        for (int i = 0; i < waves[_currentwave].wave.Count; i++)
        {
            if (i == waves[_currentwave].wave.Count-1)
            {
                Instantiate(waves[_currentwave].wave[i], new Vector3(0,1.5f,0), Quaternion.identity);

            }
            else
            {
                Instantiate(waves[_currentwave].wave[i], new Vector3(Random.Range(-8,8), Random.Range(.5f,2),0), Quaternion.identity);

            }

        }
        _currentwave++;
    }

}
