using UnityEngine;
using ProjectArchitectureBase.Event;
using ProjectArchitectureBase.VariableBase;

namespace ProjectArchitectureBase.Variables
{
    [CreateAssetMenu(menuName = "Variables/int", fileName = "IntVariable")]
    public class IntVariable : Variable<int,IntEvent>
    {  
    }
}
