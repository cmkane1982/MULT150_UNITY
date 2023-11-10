using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWalls : MonoBehaviour
{
    private float elapsedTime = 0f;

    [System.Serializable]
    public class wallMovement
    {
        public GameObject wall;
        public GameObject destination;
        public int duration;
        private Vector3 startPosition;

        public void SetStartPosition()
        {
            this.startPosition = this.wall.transform.position;
        }

        public Vector3 GetStartPosition()
        {
            return this.startPosition;
        }
    }

    [Header("Wall Movement")]
    [SerializeField] public wallMovement[] wallInformation;
    private void Start()
    {
        
    }

    private void Update()
    {
        foreach(wallMovement wm in wallInformation)
        {
            elapsedTime += Time.deltaTime;
            float percentComplete = elapsedTime / wm.duration;

            wm.SetStartPosition();
            wm.wall.transform.position = Vector3.Lerp(wm.GetStartPosition(), wm.destination.transform.position, percentComplete);
        }
    }
}
