using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer_spawnees : MonoBehaviour
{
    public GameObject customer; //obj to substantiate

    //An instance of scriptable obj
    public Customer_Spawner custInstance;

    int instanceNum = 0;

    // Start is called before the first frame update
    void Start()
    {
          SpawnCustModels(); //Call in another class
    }

    public void SpawnCustModels() {
      int currentSpawnIndex = 0;

      for (int i = 0; i < custInstance.numberOfPrefabsToCreate; i++) {
        //Creates instance of prefab at current spawn pt
        GameObject currentEntity = Instantiate(customer,
            custInstance.spawnPoints[currentSpawnIndex], Quaternion.identity);

        //Sets the name of the instantiated entity to be the string defined in the Customer_Spawner
        //and then apprends it with a unique number
        currentEntity.name = custInstance.prefabName + instanceNum;

        //Moves to the next spawn point index. Will wrap if it goes out of range
        currentSpawnIndex = (currentSpawnIndex + 1) % custInstance.spawnPoints.Length;

        ++instanceNum;
      }

		}
}
