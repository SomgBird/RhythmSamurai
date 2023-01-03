using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Core : MonoBehaviour
{
    private readonly List<CoreComponent> CoreComponents = new();
    
    public void LogicUpdate()
    {
        foreach (CoreComponent component in CoreComponents)
            component.LogicUpdate();
    }

    public void AddComponent(CoreComponent component)
    {
        if (!CoreComponents.Contains(component))
            CoreComponents.Add(component);
    }
    
    public T GetCoreComponent<T>() where T : CoreComponent
    {
        T component = CoreComponents.OfType<T>().FirstOrDefault();

        if (component)
            return component;

        // Double check the component in case of Unity callbacks sequences issues
        // which may lead to accessing component before it was added to the list.
        component = GetComponentInChildren<T>();

        if (component)
            return component;

        Debug.LogWarning($"{typeof(T)} not found on {transform.parent.name}");
        return null;
    }

    public T GetCoreComponent<T>(ref T value) where T : CoreComponent
    {
        value = GetCoreComponent<T>();
        return value;
    }
}
