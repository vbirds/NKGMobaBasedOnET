//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2020年3月28日 21:57:14
//------------------------------------------------------------

using System.Collections.Generic;
using Sirenix.OdinInspector;

namespace ETModel
{
    /// <summary>
    /// 刷新某个或某几个Buff的持续时间
    /// </summary>
    public class RefreshTargetBuffTimeBuffData: BuffDataBase
    {
        [LabelText("要刷新的BuffID")]
        public List<int> TheBuffsIDToBeRefreshed = new List<int>();
    }
}