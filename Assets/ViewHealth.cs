using UnityEngine;

public abstract class ViewHealth : MonoBehaviour
{
    [SerializeField] protected Health Health;

    protected virtual void Start()
    {
        Change();
    }

    private void OnEnable()
    {
        Health.ChangeHealthEvent += Change;
    }

    private void OnDisable()
    {
        Health.ChangeHealthEvent -= Change;
    }

    protected abstract void Change();
}
