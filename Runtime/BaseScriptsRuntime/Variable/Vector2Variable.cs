using ProjectArchitectureBase.Event;
using ProjectArchitectureBase.VariableBase;
using UnityEngine;

namespace ProjectArchitectureBase.Variables
{
    [CreateAssetMenu(menuName = "Variables/Vector2", fileName = "Vector2Variable")]
    public class Vector2Variable : Variable<Vector2,Vector2Event>
    {  
    }
}
