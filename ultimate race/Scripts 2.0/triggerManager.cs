using UnityEngine;

public class triggerManager : MonoBehaviour
{
    [SerializeField] private GameObject StartTrig;

    [SerializeField] private GameObject checkPointTrig;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkPointTrig.SetActive(false);
            StartTrig.SetActive(true);

        }
    }
}
