using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A3E RID: 6718
	[Token(Token = "0x2001A3E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7D7C", Offset = "0x10F7D7C")]
	public class UIManualGrownItemGroupController : UIBaseController
	{
		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06008D35 RID: 36149 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008D34 RID: 36148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E1")]
		public GameObject ProgressLine
		{
			[Token(Token = "0x6008D35")]
			[Address(RVA = "0x1DF9E34", Offset = "0x1DF9E34", VA = "0x7BBC5F9E34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6008D34")]
			[Address(RVA = "0x1DF9088", Offset = "0x1DF9088", VA = "0x7BBC5F9088")]
			set
			{
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06008D36 RID: 36150 RVA: 0x00025A70 File Offset: 0x00023C70
		// (set) Token: 0x06008D37 RID: 36151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E2")]
		public int Idx
		{
			[Token(Token = "0x6008D36")]
			[Address(RVA = "0x1DF9078", Offset = "0x1DF9078", VA = "0x7BBC5F9078")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6008D37")]
			[Address(RVA = "0x1DF90C0", Offset = "0x1DF90C0", VA = "0x7BBC5F90C0")]
			set
			{
			}
		}

		// Token: 0x06008D38 RID: 36152 RVA: 0x00025A88 File Offset: 0x00023C88
		[Token(Token = "0x6008D38")]
		[Address(RVA = "0x1DF9E3C", Offset = "0x1DF9E3C", VA = "0x7BBC5F9E3C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008D39 RID: 36153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D39")]
		[Address(RVA = "0x1DF9E8C", Offset = "0x1DF9E8C", VA = "0x7BBC5F9E8C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008D3A RID: 36154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D3A")]
		[Address(RVA = "0x1DFA294", Offset = "0x1DFA294", VA = "0x7BBC5FA294", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008D3B RID: 36155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D3B")]
		[Address(RVA = "0x1DFA29C", Offset = "0x1DFA29C", VA = "0x7BBC5FA29C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008D3C RID: 36156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D3C")]
		[Address(RVA = "0x1DFA184", Offset = "0x1DFA184", VA = "0x7BBC5FA184")]
		private void InitPosList()
		{
		}

		// Token: 0x06008D3D RID: 36157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D3D")]
		[Address(RVA = "0x1DFA2A4", Offset = "0x1DFA2A4", VA = "0x7BBC5FA2A4")]
		private void EnablePosList(bool enable)
		{
		}

		// Token: 0x06008D3E RID: 36158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D3E")]
		[Address(RVA = "0x1DFA3F8", Offset = "0x1DFA3F8", VA = "0x7BBC5FA3F8")]
		private void EnabelItmCtrlList(bool enable)
		{
		}

		// Token: 0x06008D3F RID: 36159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D3F")]
		[Address(RVA = "0x1DF9EFC", Offset = "0x1DF9EFC", VA = "0x7BBC5F9EFC")]
		private void InitItmCtrlList()
		{
		}

		// Token: 0x06008D40 RID: 36160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D40")]
		[Address(RVA = "0x1DF9080", Offset = "0x1DF9080", VA = "0x7BBC5F9080")]
		public void SetData(LevelRewardData data)
		{
		}

		// Token: 0x06008D41 RID: 36161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D41")]
		[Address(RVA = "0x1DF9090", Offset = "0x1DF9090", VA = "0x7BBC5F9090")]
		public void RefreshView()
		{
		}

		// Token: 0x06008D42 RID: 36162 RVA: 0x00025AA0 File Offset: 0x00023CA0
		[Token(Token = "0x6008D42")]
		[Address(RVA = "0x1DFA54C", Offset = "0x1DFA54C", VA = "0x7BBC5FA54C")]
		private UIManualGrownItemGroupController.State CalState()
		{
			return UIManualGrownItemGroupController.State.NONE;
		}

		// Token: 0x06008D43 RID: 36163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D43")]
		[Address(RVA = "0x1DFA654", Offset = "0x1DFA654", VA = "0x7BBC5FA654")]
		private void DoShowView(UIManualGrownItemGroupController.State state)
		{
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D44")]
		[Address(RVA = "0x1DFA8D4", Offset = "0x1DFA8D4", VA = "0x7BBC5FA8D4")]
		private void SetLevel()
		{
		}

		// Token: 0x06008D45 RID: 36165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D45")]
		[Address(RVA = "0x1DFAB40", Offset = "0x1DFAB40", VA = "0x7BBC5FAB40")]
		private void ShowLv1View()
		{
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D46")]
		[Address(RVA = "0x1DFAB9C", Offset = "0x1DFAB9C", VA = "0x7BBC5FAB9C")]
		private void ShowRewardView(UIManualGrownItemGroupController.State state)
		{
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D47")]
		[Address(RVA = "0x1DFADFC", Offset = "0x1DFADFC", VA = "0x7BBC5FADFC")]
		private void ShowProgress(UIManualGrownItemGroupController.State state)
		{
		}

		// Token: 0x06008D48 RID: 36168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D48")]
		[Address(RVA = "0x1DFAEBC", Offset = "0x1DFAEBC", VA = "0x7BBC5FAEBC")]
		private void SetProgressEnable(bool enable)
		{
		}

		// Token: 0x06008D49 RID: 36169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D49")]
		[Address(RVA = "0x1DFAFF8", Offset = "0x1DFAFF8", VA = "0x7BBC5FAFF8")]
		public UIManualGrownItemGroupController()
		{
		}

		// Token: 0x0400994E RID: 39246
		[Token(Token = "0x400994E")]
		[FieldOffset(Offset = "0x58")]
		private UIManualGrownItemGroupView m_View;

		// Token: 0x0400994F RID: 39247
		[Token(Token = "0x400994F")]
		[FieldOffset(Offset = "0x60")]
		private List<UIManualGrownItemController> m_ItmCtrlList;

		// Token: 0x04009950 RID: 39248
		[Token(Token = "0x4009950")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> m_PosList;

		// Token: 0x04009951 RID: 39249
		[Token(Token = "0x4009951")]
		[FieldOffset(Offset = "0x70")]
		private LevelRewardData m_Data;

		// Token: 0x04009952 RID: 39250
		[Token(Token = "0x4009952")]
		[FieldOffset(Offset = "0x78")]
		private GameObject m_Porgress;

		// Token: 0x04009953 RID: 39251
		[Token(Token = "0x4009953")]
		[FieldOffset(Offset = "0x80")]
		private int m_Indx;

		// Token: 0x02001A3F RID: 6719
		[Token(Token = "0x2001A3F")]
		public enum State
		{
			// Token: 0x04009955 RID: 39253
			[Token(Token = "0x4009955")]
			NONE,
			// Token: 0x04009956 RID: 39254
			[Token(Token = "0x4009956")]
			AWARDED,
			// Token: 0x04009957 RID: 39255
			[Token(Token = "0x4009957")]
			CAN_AWARD,
			// Token: 0x04009958 RID: 39256
			[Token(Token = "0x4009958")]
			CAN_NOT_AWARD
		}
	}
}
