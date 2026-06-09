using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020014A9 RID: 5289
	[Token(Token = "0x20014A9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED504", Offset = "0x10ED504")]
	public class UIClanMatchResultPopupController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060059B7 RID: 22967 RVA: 0x0001A640 File Offset: 0x00018840
		[Token(Token = "0x60059B7")]
		[Address(RVA = "0x1CFE008", Offset = "0x1CFE008", VA = "0x7BBC4FE008")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B8")]
		[Address(RVA = "0x1CFE058", Offset = "0x1CFE058", VA = "0x7BBC4FE058", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B9")]
		[Address(RVA = "0x1CFE1B0", Offset = "0x1CFE1B0", VA = "0x7BBC4FE1B0", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060059BA RID: 22970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BA")]
		[Address(RVA = "0x1CFE1F0", Offset = "0x1CFE1F0", VA = "0x7BBC4FE1F0")]
		public void SetResultAttachData(FakeSubmitRes clanMatchResult)
		{
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BB")]
		[Address(RVA = "0x1CFE5C4", Offset = "0x1CFE5C4", VA = "0x7BBC4FE5C4")]
		private void SetClanInfo()
		{
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BC")]
		[Address(RVA = "0x1CFE97C", Offset = "0x1CFE97C", VA = "0x7BBC4FE97C")]
		private void RefreshCupIcon(FakeSubmitRes clanMatchResult)
		{
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BD")]
		[Address(RVA = "0x1CFED54", Offset = "0x1CFED54", VA = "0x7BBC4FED54", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BE")]
		[Address(RVA = "0x1CFEECC", Offset = "0x1CFEECC", VA = "0x7BBC4FEECC", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x0001A658 File Offset: 0x00018858
		[Token(Token = "0x60059BF")]
		[Address(RVA = "0x1CFF030", Offset = "0x1CFF030", VA = "0x7BBC4FF030", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060059C0 RID: 22976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C0")]
		[Address(RVA = "0x1CFF0C8", Offset = "0x1CFF0C8", VA = "0x7BBC4FF0C8")]
		public UIClanMatchResultPopupController()
		{
		}

		// Token: 0x04007D1A RID: 32026
		[Token(Token = "0x4007D1A")]
		[FieldOffset(Offset = "0x98")]
		private UIClanMatchResultPopupView m_View;

		// Token: 0x04007D1B RID: 32027
		[Token(Token = "0x4007D1B")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelChampionship m_ModelChampionship;
	}
}
