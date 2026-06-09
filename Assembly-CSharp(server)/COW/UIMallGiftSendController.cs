using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200159E RID: 5534
	[Token(Token = "0x200159E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEE1C", Offset = "0x10EEE1C")]
	public class UIMallGiftSendController : UIMallPurchaseBaseController
	{
		// Token: 0x06006129 RID: 24873 RVA: 0x0001C038 File Offset: 0x0001A238
		[Token(Token = "0x6006129")]
		[Address(RVA = "0x1C73834", Offset = "0x1C73834", VA = "0x7BBC473834")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612A")]
		[Address(RVA = "0x1C73884", Offset = "0x1C73884", VA = "0x7BBC473884", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612B")]
		[Address(RVA = "0x1C73A54", Offset = "0x1C73A54", VA = "0x7BBC473A54")]
		private void OnGemsPurchaseBtnClick()
		{
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612C")]
		[Address(RVA = "0x1C73BB4", Offset = "0x1C73BB4", VA = "0x7BBC473BB4")]
		private void OnGoldPurchaseBtnClick()
		{
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612D")]
		[Address(RVA = "0x1C73A5C", Offset = "0x1C73A5C", VA = "0x7BBC473A5C")]
		private void SendItem(EInventory.CurrencyType currency)
		{
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612E")]
		[Address(RVA = "0x1C6FF84", Offset = "0x1C6FF84", VA = "0x7BBC46FF84")]
		public void RefreshData(GiftItem giftItem, ulong[] receiversIdList, EGiftStore_BuddyType buddyType, string message, string receiversName)
		{
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612F")]
		[Address(RVA = "0x1C73C9C", Offset = "0x1C73C9C", VA = "0x7BBC473C9C")]
		private void SetPriceData()
		{
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006130")]
		[Address(RVA = "0x1C73E58", Offset = "0x1C73E58", VA = "0x7BBC473E58")]
		public UIMallGiftSendController()
		{
		}

		// Token: 0x04008101 RID: 33025
		[Token(Token = "0x4008101")]
		[FieldOffset(Offset = "0xD8")]
		private GiftItem m_GiftItemData;

		// Token: 0x04008102 RID: 33026
		[Token(Token = "0x4008102")]
		[FieldOffset(Offset = "0xE0")]
		private string m_ReceiversName;

		// Token: 0x04008103 RID: 33027
		[Token(Token = "0x4008103")]
		[FieldOffset(Offset = "0xE8")]
		private ulong[] m_ReceiversIdList;

		// Token: 0x04008104 RID: 33028
		[Token(Token = "0x4008104")]
		[FieldOffset(Offset = "0xF0")]
		private EGiftStore_BuddyType m_BuddyType;

		// Token: 0x04008105 RID: 33029
		[Token(Token = "0x4008105")]
		[FieldOffset(Offset = "0xF8")]
		private string m_Message;
	}
}
