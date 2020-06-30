using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//两句命名空间的引入
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

//继承一个类
public class AICal : Action
{
    public SharedInt randomNum;

    public override TaskStatus OnUpdate()
    {
        randomNum.Value = Random.Range(1, 10);
        return base.OnUpdate();
    }
}
