using UnityEngine;

public class RandomColorObjectSpawner : MonoBehaviour
{
    public enum ObjectColor { Red, Blue, Yellow }

    public GameObject redPrefab;
    public GameObject bluePrefab;
    public GameObject yellowPrefab;
    public Transform spawnArea;
    public CoinsLogic Logic;
    void Start()
    {
        InvokeRepeating("SpawnRandomColorObject", 0f, 1f);
    }

    void SpawnRandomColorObject()
    {
        if (spawnArea == null)
        {
            Debug.LogError("Please assign spawn area in the inspector.");
            return;
        }

        // Choose a random color
        ObjectColor selectedColor = (ObjectColor)Random.Range(0, 3);

        // Instantiate the selected object based on the color
        GameObject selectedObject = null;
        switch (selectedColor)
        {
            case ObjectColor.Red:
                selectedObject = Instantiate(redPrefab);
                selectedObject.GetComponent<Collect>().Log = Logic;
                selectedObject.GetComponent<Collect>().color = ObjectColor.Red;
                break;
            case ObjectColor.Blue:
                selectedObject = Instantiate(bluePrefab);
                selectedObject.GetComponent<Collect>().Log = Logic;
                selectedObject.GetComponent<Collect>().color = ObjectColor.Blue;
                break;
            case ObjectColor.Yellow:
                selectedObject = Instantiate(yellowPrefab);
                selectedObject.GetComponent<Collect>().Log = Logic;
                selectedObject.GetComponent<Animator>().SetBool("Spawn", true);
                selectedObject.GetComponent<Collect>().color = ObjectColor.Yellow;

                break;
        }

        // Calculate a random position within the spawn area
        Vector3 randomPosition = new Vector3(
            Random.Range(spawnArea.position.x - spawnArea.localScale.x / 2, spawnArea.position.x + spawnArea.localScale.x / 2),
            spawnArea.position.y,
            Random.Range(spawnArea.position.z - spawnArea.localScale.z / 2, spawnArea.position.z + spawnArea.localScale.z / 2)
        );

        // Spawn the selected object at the random position
        if (selectedObject != null)
        {
            selectedObject.transform.position = randomPosition;
            
        }
    }
}
