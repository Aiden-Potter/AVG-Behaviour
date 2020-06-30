using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
public class AIConCompare : Conditional
{
    public SharedInt int1;
    public SharedInt int2;

    public override TaskStatus OnUpdate()
    {
        if(int1.Value>int2.Value)
        {
            return TaskStatus.Success;
        }
        else
        {
            return TaskStatus.Failure;
        }
    }
}
