using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A3B RID: 6715
	[Token(Token = "0x2001A3B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7CFC", Offset = "0x10F7CFC")]
	public class UIManualGrownController : UIManualContentBaseController
	{
		// Token: 0x06008D1B RID: 36123 RVA: 0x00025A10 File Offset: 0x00023C10
		[Token(Token = "0x6008D1B")]
		[Address(RVA = "0x1DF8030", Offset = "0x1DF8030", VA = "0x7BBC5F8030")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008D1C RID: 36124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D1C")]
		[Address(RVA = "0x1DF8080", Offset = "0x1DF8080", VA = "0x7BBC5F8080", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008D1D RID: 36125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D1D")]
		[Address(RVA = "0x1DF8844", Offset = "0x1DF8844", VA = "0x7BBC5F8844", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008D1E RID: 36126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D1E")]
		[Address(RVA = "0x1DF884C", Offset = "0x1DF884C", VA = "0x7BBC5F884C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008D1F RID: 36127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D1F")]
		[Address(RVA = "0x1DF8880", Offset = "0x1DF8880", VA = "0x7BBC5F8880", Slot = "28")]
		public override void SetData(UIManualDataBase data)
		{
		}

		// Token: 0x06008D20 RID: 36128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D20")]
		[Address(RVA = "0x1DF8928", Offset = "0x1DF8928", VA = "0x7BBC5F8928", Slot = "30")]
		public override void RefreshView()
		{
		}

		// Token: 0x06008D21 RID: 36129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D21")]
		[Address(RVA = "0x1DF894C", Offset = "0x1DF894C", VA = "0x7BBC5F894C")]
		public void DoRefreshView(int pageID)
		{
		}

		// Token: 0x06008D22 RID: 36130 RVA: 0x00025A28 File Offset: 0x00023C28
		[Token(Token = "0x6008D22")]
		[Address(RVA = "0x1DF90B8", Offset = "0x1DF90B8", VA = "0x7BBC5F90B8", Slot = "31")]
		protected override int GetMaxPage()
		{
			return 0;
		}

		// Token: 0x06008D23 RID: 36131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D23")]
		[Address(RVA = "0x1DF8298", Offset = "0x1DF8298", VA = "0x7BBC5F8298")]
		private void InitRewardGroup()
		{
		}

		// Token: 0x06008D24 RID: 36132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D24")]
		[Address(RVA = "0x1DF864C", Offset = "0x1DF864C", VA = "0x7BBC5F864C")]
		private void InitProgress()
		{
		}

		// Token: 0x06008D25 RID: 36133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D25")]
		[Address(RVA = "0x1DF90C8", Offset = "0x1DF90C8", VA = "0x7BBC5F90C8")]
		public UIManualGrownController()
		{
		}

		// Token: 0x04009941 RID: 39233
		[Token(Token = "0x4009941")]
		[FieldOffset(Offset = "0x78")]
		private UIManualGrownView m_View;

		// Token: 0x04009942 RID: 39234
		[Token(Token = "0x4009942")]
		[FieldOffset(Offset = "0x80")]
		private UIManualGrownData m_Data;

		// Token: 0x04009943 RID: 39235
		[Token(Token = "0x4009943")]
		[FieldOffset(Offset = "0x88")]
		private List<GameObject> m_PosList;

		// Token: 0x04009944 RID: 39236
		[Token(Token = "0x4009944")]
		[FieldOffset(Offset = "0x90")]
		private List<UIManualGrownItemGroupController> m_GroupCtrlList;

		// Token: 0x04009945 RID: 39237
		[Token(Token = "0x4009945")]
		[FieldOffset(Offset = "0x98")]
		private List<GameObject> m_ProgressList;

		// Token: 0x04009946 RID: 39238
		[Token(Token = "0x4009946")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject m_LeftArrowTips;

		// Token: 0x04009947 RID: 39239
		[Token(Token = "0x4009947")]
		[FieldOffset(Offset = "0xA8")]
		private GameObject m_RightArrowTips;

		// Token: 0x04009948 RID: 39240
		[Token(Token = "0x4009948")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int m_GroupCnt;

		// Token: 0x02001A3C RID: 6716
		[Token(Token = "0x2001A3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7D34", Offset = "0x10F7D34")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06008D27 RID: 36135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008D27")]
			[Address(RVA = "0x1DF9070", Offset = "0x1DF9070", VA = "0x7BBC5F9070")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x06008D28 RID: 36136 RVA: 0x00025A40 File Offset: 0x00023C40
			[Token(Token = "0x6008D28")]
			[Address(RVA = "0x1DF91D0", Offset = "0x1DF91D0", VA = "0x7BBC5F91D0")]
			internal bool <DoRefreshView>b__0(LevelRewardData e)
			{
				return default(bool);
			}

			// Token: 0x04009949 RID: 39241
			[Token(Token = "0x4009949")]
			[FieldOffset(Offset = "0x10")]
			public int ctrlIdx;
		}
	}
}
