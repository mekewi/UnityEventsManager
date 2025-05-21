using UnityEngine;
using ProjectArchitectureBase.Event;
using ProjectArchitectureBase.VariableBase;

namespace ProjectArchitectureBase.Variables
{
    [CreateAssetMenu(menuName = "Variables/string", fileName = "StringVariable")]
    public class StringVariable : Variable<string,StringEvent>
    {  
    }
}
