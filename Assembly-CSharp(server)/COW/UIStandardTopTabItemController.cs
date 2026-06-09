using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001679 RID: 5753
	[Token(Token = "0x2001679")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F02BC", Offset = "0x10F02BC")]
	public class UIStandardTopTabItemController : UIEasyListItemController
	{
		// Token: 0x06006868 RID: 26728 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
		[Token(Token = "0x6006868")]
		[Address(RVA = "0x21341CC", Offset = "0x21341CC", VA = "0x7BBC9341CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006869")]
		[Address(RVA = "0x213421C", Offset = "0x213421C", VA = "0x7BBC93421C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600686A")]
		[Address(RVA = "0x2134300", Offset = "0x2134300", VA = "0x7BBC934300", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600686B")]
		[Address(RVA = "0x2134E28", Offset = "0x2134E28", VA = "0x7BBC934E28")]
		public void SetRedPointState(bool value)
		{
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x0001D9B8 File Offset: 0x0001BBB8
		[Token(Token = "0x600686C")]
		[Address(RVA = "0x2134E88", Offset = "0x2134E88", VA = "0x7BBC934E88")]
		public bool GetRedPointState()
		{
			return default(bool);
		}

		// Token: 0x0600686D RID: 26733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600686D")]
		[Address(RVA = "0x2134EE0", Offset = "0x2134EE0", VA = "0x7BBC934EE0", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600686E")]
		[Address(RVA = "0x213507C", Offset = "0x213507C", VA = "0x7BBC93507C", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600686F")]
		[Address(RVA = "0x21350F4", Offset = "0x21350F4", VA = "0x7BBC9350F4")]
		public UIStandardTopTabItemController()
		{
		}

		// Token: 0x0400853D RID: 34109
		[Token(Token = "0x400853D")]
		[FieldOffset(Offset = "0x70")]
		private UIStandardTopTabItemView m_View;

		// Token: 0x0400853E RID: 34110
		[Token(Token = "0x400853E")]
		[FieldOffset(Offset = "0x78")]
		private StandardTopTabItemViewData m_Data;

		// Token: 0x0400853F RID: 34111
		[Token(Token = "0x400853F")]
		[FieldOffset(Offset = "0x80")]
		public float selectBgWidth;
	}
}
