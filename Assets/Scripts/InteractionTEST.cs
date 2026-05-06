

namespace EJETAGame
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    //interface IInteractable
    //{
        //public void Interact();
    //}

    /**
     * Interactable test case where we change the color of a sphere gameobject
     * into a random color;
     */
    public class InteractionTEST : MonoBehaviour, IInteractable
    {
        public GameObject player;
        private Color randomColor;
        //public Transform InteractorSource;
        //public float InteractRange;
        private int puzzle2Piece = 0;
        public KeyCode escapeKey;
        public float detectionRange = 5;
        //bool keyReleased = false;
        //int lastPieceCount = 0;
        public GameObject Puzzle2;

        //Which button the user must press to initiate the Interaction;
        public KeyCode interactionKey;
        public void Interact()
        {
            //if (Input.GetKeyDown(interactionKey))
            //{
                //this.GetComponent<Renderer>().material.color = RandomColor();
                //Debug.Log("Success");
            //}
            start();
            Update();
                
        }

        //When our interaction begin, we set the UI text to prompt the user to
        //press a button to interact with the gameobject;
        public void OnInteractEnter()
        {
            InteractionText.instance.SetText("Press "+interactionKey+" to interact");
        }


        //We can debug a statement to let us know when the interaction ends;
        public void OnInteractExit()
        {
            Debug.Log("Interaction Ended");
        }

        private Color RandomColor()
        {
            return randomColor = Random.ColorHSV();
        }

        //public void Update()
        //{
            //if (Input.GetKeyDown(interactionKey))
            //{
                //Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
                //if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
                //{
                    //if (hitInfo.collider.gameObject.TryGetcomponent(out IInteractable interactObj))
                    //{
                        //interactObj.Interact();
                    //}
                //}
            //}
        //}

        void start()
        {
            //canvasToToggle.SetActive(false);
            player = GameObject.FindWithTag("Player");
        }

        void Update()
        {
            if (Input.GetKeyDown(interactionKey) && gameObject.CompareTag("Puzzle1"))
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else if (Input.GetKeyDown(escapeKey) && gameObject.CompareTag("Puzzle1"))
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }

            if (Input.GetKeyDown(interactionKey) && gameObject.CompareTag("Puzzle2Piece") && Vector3.Distance(transform.position, player.transform.position) < detectionRange)
            {
                //if (Input.GetKeyDown(interactionKey) && )
                //{
                    Destroy(gameObject);
                    puzzle2Piece++;
                    Debug.Log("Item Collected");
                //}
            }

            if (puzzle2Piece >= 4)
            {
                SolvePuzzle2();
            }
        }

        void SolvePuzzle2()
        {
            Debug.Log("Destroy triggered");

            foreach (Transform child in Puzzle2.transform)
            {
                Destroy(child.gameObject);
            }
        }
    }

}
