using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200139E RID: 5022
	[Token(Token = "0x200139E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB918", Offset = "0x10EB918")]
	public class UIMVPPeakDayWndController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06005155 RID: 20821 RVA: 0x000188E8 File Offset: 0x00016AE8
		[Token(Token = "0x6005155")]
		[Address(RVA = "0x19F012C", Offset = "0x19F012C", VA = "0x7BBC1F012C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005156")]
		[Address(RVA = "0x19F017C", Offset = "0x19F017C", VA = "0x7BBC1F017C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005157")]
		[Address(RVA = "0x19F0C9C", Offset = "0x19F0C9C", VA = "0x7BBC1F0C9C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005158")]
		[Address(RVA = "0x19F0CDC", Offset = "0x19F0CDC", VA = "0x7BBC1F0CDC")]
		private void CloseAllItem()
		{
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005159")]
		[Address(RVA = "0x19F0400", Offset = "0x19F0400", VA = "0x7BBC1F0400")]
		public void SetViewData()
		{
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600515A")]
		[Address(RVA = "0x19F0E28", Offset = "0x19F0E28", VA = "0x7BBC1F0E28")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600515B")]
		[Address(RVA = "0x19F0E30", Offset = "0x19F0E30", VA = "0x7BBC1F0E30")]
		private void OnBtnClaimClick()
		{
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600515C")]
		[Address(RVA = "0x19F0F0C", Offset = "0x19F0F0C", VA = "0x7BBC1F0F0C", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x00018900 File Offset: 0x00016B00
		[Token(Token = "0x600515D")]
		[Address(RVA = "0x19F0F8C", Offset = "0x19F0F8C", VA = "0x7BBC1F0F8C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600515E")]
		[Address(RVA = "0x19F0FD0", Offset = "0x19F0FD0", VA = "0x7BBC1F0FD0")]
		public UIMVPPeakDayWndController()
		{
		}

		// Token: 0x040077BA RID: 30650
		[Token(Token = "0x40077BA")]
		[FieldOffset(Offset = "0x98")]
		private UIMVPPeakDayWndView m_View;

		// Token: 0x040077BB RID: 30651
		[Token(Token = "0x40077BB")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040077BC RID: 30652
		[Token(Token = "0x40077BC")]
		[FieldOffset(Offset = "0xA8")]
		private ClientActivityDesc desc;

		// Token: 0x040077BD RID: 30653
		[Token(Token = "0x40077BD")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelMVP m_ModelMVP;

		// Token: 0x040077BE RID: 30654
		[Token(Token = "0x40077BE")]
		[FieldOffset(Offset = "0xB8")]
		private List<UIStandardItemMAXBController> itemList;

		// Token: 0x040077BF RID: 30655
		[Token(Token = "0x40077BF")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_PeakDayAwardClaimed;
	}
}
