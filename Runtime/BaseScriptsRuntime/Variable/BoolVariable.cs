using UnityEngine;
using ProjectArchitectureBase.Event;
using ProjectArchitectureBase.VariableBase;
namespace ProjectArchitectureBase.Variables
{
    [CreateAssetMenu(menuName = "Variables/bool", fileName = "BoolVariable")]
    public class BoolVariable : Variable<bool,BoolEvent>
    {  
    }
}
