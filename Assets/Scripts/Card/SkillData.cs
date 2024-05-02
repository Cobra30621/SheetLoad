using System;
using System.Collections.Generic;
using System.Linq;
using GameAction;
using Sirenix.OdinInspector;
using UnityEngine;
using Utilities;

namespace Card
{
    [CreateAssetMenu(fileName = "SkillData",menuName = "SkillData",order = 0)]
    public class SkillData : ScriptableObject
    {
        #region Private Variables

        [SerializeField]
        [LabelWidth(30)]
        [LabelText("Url:")]
        [BoxGroup("LoadData")]
        private string url = "https://opensheet.elk.sh/17o-e5oCXd3G-jgaeQcWVH2am7DFnWY5afiKsLWWvOQs/SkillData";

        [SerializeField]
        [TableList]
        private SkillInfo[] effectInfos;

        #endregion
        
        
        #region Public Methods

        public List<SkillInfo> GetAllCardInfo()
        {
            return effectInfos.ToList();
        }

        #endregion

        #region Private Methods

        [Button]
        [BoxGroup("LoadData")]
        private void ParseDataFromGoogleSheet()
        {
            GoogleSheetService.LoadDataArray<SkillInfo>(url , infos => effectInfos = infos);
        }

        #endregion
    }
    
    
    [Serializable]
    public class SkillInfo
    {
        public GameActionType ActionType;
        public int EffectID;
        public string action;

        public int int1;
        public int int2;
        public int int3;
    }
}