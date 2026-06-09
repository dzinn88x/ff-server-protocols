using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001AE9 RID: 6889
	[Token(Token = "0x2001AE9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8E34", Offset = "0x10F8E34")]
	public class UIPetChangeNamePopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06009205 RID: 37381 RVA: 0x00026DC0 File Offset: 0x00024FC0
		[Token(Token = "0x6009205")]
		[Address(RVA = "0x20D32EC", Offset = "0x20D32EC", VA = "0x7BBC8D32EC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009206")]
		[Address(RVA = "0x20D333C", Offset = "0x20D333C", VA = "0x7BBC8D333C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009207")]
		[Address(RVA = "0x20D34F0", Offset = "0x20D34F0", VA = "0x7BBC8D34F0")]
		private void RefreshViewData()
		{
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009208")]
		[Address(RVA = "0x20D3DC8", Offset = "0x20D3DC8", VA = "0x7BBC8D3DC8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009209")]
		[Address(RVA = "0x20D3B88", Offset = "0x20D3B88", VA = "0x7BBC8D3B88")]
		private void OnInputChange()
		{
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600920A")]
		[Address(RVA = "0x20D3E7C", Offset = "0x20D3E7C", VA = "0x7BBC8D3E7C")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600920B")]
		[Address(RVA = "0x20D47F4", Offset = "0x20D47F4", VA = "0x7BBC8D47F4", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600920C RID: 37388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600920C")]
		[Address(RVA = "0x20D4B74", Offset = "0x20D4B74", VA = "0x7BBC8D4B74", Slot = "38")]
		public override void EnterByReturn()
		{
		}

		// Token: 0x0600920D RID: 37389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600920D")]
		[Address(RVA = "0x20D4510", Offset = "0x20D4510", VA = "0x7BBC8D4510")]
		private void ShowRenameDiamondShortHint()
		{
		}

		// Token: 0x0600920E RID: 37390 RVA: 0x00026DD8 File Offset: 0x00024FD8
		[Token(Token = "0x600920E")]
		[Address(RVA = "0x20D4C00", Offset = "0x20D4C00", VA = "0x7BBC8D4C00", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600920F RID: 37391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600920F")]
		[Address(RVA = "0x20D4C44", Offset = "0x20D4C44", VA = "0x7BBC8D4C44")]
		public UIPetChangeNamePopupWindowController()
		{
		}

		// Token: 0x04009CC1 RID: 40129
		[Token(Token = "0x4009CC1")]
		[FieldOffset(Offset = "0x98")]
		private UIChangeNamePopupWindowView m_View;

		// Token: 0x04009CC2 RID: 40130
		[Token(Token = "0x4009CC2")]
		private const uint BTN_DEFUALT_COLOR = 4294967295U;

		// Token: 0x04009CC3 RID: 40131
		[Token(Token = "0x4009CC3")]
		private const uint BTN_GREY_COLOR = 2593823487U;

		// Token: 0x04009CC4 RID: 40132
		[Token(Token = "0x4009CC4")]
		[FieldOffset(Offset = "0xA0")]
		private PetInfo m_PetData;

		// Token: 0x04009CC5 RID: 40133
		[Token(Token = "0x4009CC5")]
		[FieldOffset(Offset = "0xA8")]
		private PetRenameCostData m_CostData;

		// Token: 0x04009CC6 RID: 40134
		[Token(Token = "0x4009CC6")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_HasRequestedRename;

		// Token: 0x04009CC7 RID: 40135
		[Token(Token = "0x4009CC7")]
		[FieldOffset(Offset = "0xB1")]
		private bool isFree;

		// Token: 0x02001AEA RID: 6890
		[Token(Token = "0x2001AEA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8E6C", Offset = "0x10F8E6C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06009211 RID: 37393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009211")]
			[Address(RVA = "0x20D4CB0", Offset = "0x20D4CB0", VA = "0x7BBC8D4CB0")]
			public <>c()
			{
			}

			// Token: 0x06009212 RID: 37394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009212")]
			[Address(RVA = "0x20D4CB8", Offset = "0x20D4CB8", VA = "0x7BBC8D4CB8")]
			internal void <ShowRenameDiamondShortHint>b__15_0()
			{
			}

			// Token: 0x04009CC8 RID: 40136
			[Token(Token = "0x4009CC8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIPetChangeNamePopupWindowController.<>c <>9;

			// Token: 0x04009CC9 RID: 40137
			[Token(Token = "0x4009CC9")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__15_0;
		}
	}
}
