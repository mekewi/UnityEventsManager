using UnityEngine;
using ProjectArchitectureBase.Event;
using ProjectArchitectureBase.VariableBase;

namespace Variables.Scripts.VariableBase.Variables
{
    [CreateAssetMenu(menuName = "Variables/Vector3", fileName = "Vector3Variable")]
    public class Vector3Variable : Variable<Vector3,Vector3Event>
    {  
    }
}
