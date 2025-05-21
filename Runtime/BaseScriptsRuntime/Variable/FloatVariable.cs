using UnityEngine;
using ProjectArchitectureBase.Event;
using ProjectArchitectureBase.VariableBase;

namespace ProjectArchitectureBase.Variables
{
    [CreateAssetMenu(menuName = "Variables/float", fileName = "FloatVariable")]
    public class FloatVariable : Variable<float,FloatEvent>
    {  
    }
}
