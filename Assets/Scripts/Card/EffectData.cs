using System;
using System.Collections.Generic;
using System.Linq;
using GameAction;
using Sirenix.OdinInspector;
using UnityEngine;
using Utilities;

namespace Card
{
    [CreateAssetMenu(fileName = "EffectData",menuName = "EffectData",order = 0)]
    public class EffectData : ScriptableObject
    {
        #region Private Variables

        [SerializeField]
        [LabelWidth(30)]
        [LabelText("Url:")]
        [BoxGroup("LoadData")]
        private string url = "https://opensheet.elk.sh/17o-e5oCXd3G-jgaeQcWVH2am7DFnWY5afiKsLWWvOQs/EffectData";

        [SerializeField]
        [TableList]
        private EffectInfo[] effectInfos;

        #endregion
        
        
        #region Public Methods

        public List<EffectInfo> GetAllCardInfo()
        {
            return effectInfos.ToList();
        }

        #endregion

        #region Private Methods

        [Button]
        [BoxGroup("LoadData")]
        private void ParseDataFromGoogleSheet()
        {
            GoogleSheetService.LoadDataArray<EffectInfo>(url , infos => effectInfos = infos);
        }

        #endregion
    }
    
    
    [Serializable]
    public class EffectInfo
    {
        public GameActionType ActionType;
        public int EffectID;
        public string action;

        public int int1;
        public int int2;
        public int int3;
        public float float1;
    }
}