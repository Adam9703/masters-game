using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab; // A prefab that the object pool returns instances of

    private Stack<GameObject> inactiveInstances = new Stack<GameObject>(); // A Stack of currently inactive instances of the prefab

    // Method used to return instance of the prefab
    public GameObject GetObject()
    {
        GameObject activeGameObject;

        if(inactiveInstances.Count > 0) // If an inactive instance of the prefab is available, return it
        {
            activeGameObject = inactiveInstances.Pop(); // Remove the instance of the game object from the collection of inactive instances
        }
        else // If there is not an inactive instance, create a new one
        {
            activeGameObject = (GameObject)GameObject.Instantiate(prefab);

            // Add a PooledObject component to the prefab to state that it came from this object pool
            PooledObject pooledObject = activeGameObject.AddComponent<PooledObject>();
            pooledObject.pool = this;
        }

        // Root the instance in the scene and enable it by setting it to true
        activeGameObject.transform.SetParent(null);
        activeGameObject.SetActive(true);

        return activeGameObject; // Return the game object
    }

    public void ReturnObject(GameObject toReturn)
    {
        PooledObject pooledObject = toReturn.GetComponent<PooledObject>();

        // If the instance of the object came from this pool then return it to the object pool
        if(pooledObject != null && pooledObject.pool == this)
        {
            // Make the instance a child of the scene and disable it (similar to activating)
            toReturn.transform.SetParent(transform);
            toReturn.SetActive(false);

            // Then add the instance to the collection of inactive instances by pushing it onto the stack
            inactiveInstances.Push(toReturn);
        }
        else // If this can't be done then destroy it
        {
            Debug.LogWarning(toReturn.name + " was returned to a pool it wasn't created from! It will be destroyed"); // Display a warning saying it is being destroyed
            Destroy(toReturn); // Destroy this object that is being returned
        }
    }

    // This class is a component that simply indeitifes the pool that a GameObject has come from so we know where to return to
    public class PooledObject : MonoBehaviour
    {
        public ObjectPool pool;
    }
}
