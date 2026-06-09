using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A4F RID: 6735
	[Token(Token = "0x2001A4F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7EEC", Offset = "0x10F7EEC")]
	public class UIManualMapEvtController : UIManualContentBaseController
	{
		// Token: 0x06008DAD RID: 36269 RVA: 0x00025BF0 File Offset: 0x00023DF0
		[Token(Token = "0x6008DAD")]
		[Address(RVA = "0x18E1650", Offset = "0x18E1650", VA = "0x7BBC0E1650")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008DAE RID: 36270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DAE")]
		[Address(RVA = "0x18E16A0", Offset = "0x18E16A0", VA = "0x7BBC0E16A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008DAF RID: 36271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DAF")]
		[Address(RVA = "0x18E1A68", Offset = "0x18E1A68", VA = "0x7BBC0E1A68", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008DB0 RID: 36272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DB0")]
		[Address(RVA = "0x18E1A70", Offset = "0x18E1A70", VA = "0x7BBC0E1A70", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008DB1 RID: 36273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DB1")]
		[Address(RVA = "0x18E1A78", Offset = "0x18E1A78", VA = "0x7BBC0E1A78", Slot = "28")]
		public override void SetData(UIManualDataBase data)
		{
		}

		// Token: 0x06008DB2 RID: 36274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DB2")]
		[Address(RVA = "0x18E1B18", Offset = "0x18E1B18", VA = "0x7BBC0E1B18", Slot = "30")]
		public override void RefreshView()
		{
		}

		// Token: 0x06008DB3 RID: 36275 RVA: 0x00025C08 File Offset: 0x00023E08
		[Token(Token = "0x6008DB3")]
		[Address(RVA = "0x18E21D8", Offset = "0x18E21D8", VA = "0x7BBC0E21D8", Slot = "31")]
		protected override int GetMaxPage()
		{
			return 0;
		}

		// Token: 0x06008DB4 RID: 36276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DB4")]
		[Address(RVA = "0x18E18B4", Offset = "0x18E18B4", VA = "0x7BBC0E18B4")]
		private void InitEvtItemCtrl()
		{
		}

		// Token: 0x06008DB5 RID: 36277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DB5")]
		[Address(RVA = "0x18E1B44", Offset = "0x18E1B44", VA = "0x7BBC0E1B44")]
		private void DoRefreshView(int pageID)
		{
		}

		// Token: 0x06008DB6 RID: 36278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DB6")]
		[Address(RVA = "0x18E2A54", Offset = "0x18E2A54", VA = "0x7BBC0E2A54")]
		public void OnClickMore(ManualInMapData data)
		{
		}

		// Token: 0x06008DB7 RID: 36279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DB7")]
		[Address(RVA = "0x18E2ABC", Offset = "0x18E2ABC", VA = "0x7BBC0E2ABC")]
		public UIManualMapEvtController()
		{
		}

		// Token: 0x04009996 RID: 39318
		[Token(Token = "0x4009996")]
		[FieldOffset(Offset = "0x78")]
		private UIManualMapEvtView m_View;

		// Token: 0x04009997 RID: 39319
		[Token(Token = "0x4009997")]
		[FieldOffset(Offset = "0x80")]
		private UIManualMapEventData m_Data;

		// Token: 0x04009998 RID: 39320
		[Token(Token = "0x4009998")]
		[FieldOffset(Offset = "0x88")]
		private UIManualMapEvtItemController m_LeftCtrl;

		// Token: 0x04009999 RID: 39321
		[Token(Token = "0x4009999")]
		[FieldOffset(Offset = "0x90")]
		private UIManualMapEvtItemController m_RightCtrl;

		// Token: 0x0400999A RID: 39322
		[Token(Token = "0x400999A")]
		[FieldOffset(Offset = "0x98")]
		private GameObject m_LeftArrowTips;

		// Token: 0x0400999B RID: 39323
		[Token(Token = "0x400999B")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject m_RightArrowTips;

		// Token: 0x02001A50 RID: 6736
		[Token(Token = "0x2001A50")]
		public enum LocationType
		{
			// Token: 0x0400999D RID: 39325
			[Token(Token = "0x400999D")]
			NONE,
			// Token: 0x0400999E RID: 39326
			[Token(Token = "0x400999E")]
			LEFT,
			// Token: 0x0400999F RID: 39327
			[Token(Token = "0x400999F")]
			RIGHT
		}

		// Token: 0x02001A51 RID: 6737
		[Token(Token = "0x2001A51")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7F24", Offset = "0x10F7F24")]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06008DB8 RID: 36280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008DB8")]
			[Address(RVA = "0x18E2328", Offset = "0x18E2328", VA = "0x7BBC0E2328")]
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x06008DB9 RID: 36281 RVA: 0x00025C20 File Offset: 0x00023E20
			[Token(Token = "0x6008DB9")]
			[Address(RVA = "0x18E2AC4", Offset = "0x18E2AC4", VA = "0x7BBC0E2AC4")]
			internal bool <DoRefreshView>b__0(ManualInMapData e)
			{
				return default(bool);
			}

			// Token: 0x040099A0 RID: 39328
			[Token(Token = "0x40099A0")]
			[FieldOffset(Offset = "0x10")]
			public int pageID;
		}
	}
}
