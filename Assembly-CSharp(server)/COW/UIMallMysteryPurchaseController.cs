using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015A3 RID: 5539
	[Token(Token = "0x20015A3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEEFC", Offset = "0x10EEEFC")]
	public class UIMallMysteryPurchaseController : UIMallPurchaseBaseController
	{
		// Token: 0x0600615A RID: 24922 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		[Token(Token = "0x600615A")]
		[Address(RVA = "0x1DED788", Offset = "0x1DED788", VA = "0x7BBC5ED788")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x0600615B RID: 24923 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
		// (set) Token: 0x0600615C RID: 24924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008C2")]
		protected override int ItemCount
		{
			[Token(Token = "0x600615B")]
			[Address(RVA = "0x1DED7D8", Offset = "0x1DED7D8", VA = "0x7BBC5ED7D8", Slot = "43")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600615C")]
			[Address(RVA = "0x1DED7E0", Offset = "0x1DED7E0", VA = "0x7BBC5ED7E0", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615D")]
		[Address(RVA = "0x1DED8B8", Offset = "0x1DED8B8", VA = "0x7BBC5ED8B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615E")]
		[Address(RVA = "0x1DEDC84", Offset = "0x1DEDC84", VA = "0x7BBC5EDC84")]
		private void PurchaseItem()
		{
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615F")]
		[Address(RVA = "0x1DEDD64", Offset = "0x1DEDD64", VA = "0x7BBC5EDD64")]
		public void RefreshData(MysteryPoolStoreItem poolStoreItem)
		{
		}

		// Token: 0x06006160 RID: 24928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006160")]
		[Address(RVA = "0x1DEE31C", Offset = "0x1DEE31C", VA = "0x7BBC5EE31C")]
		private void SetPriceData()
		{
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006161")]
		[Address(RVA = "0x1DEE3D4", Offset = "0x1DEE3D4", VA = "0x7BBC5EE3D4")]
		public UIMallMysteryPurchaseController()
		{
		}

		// Token: 0x0400814A RID: 33098
		[Token(Token = "0x400814A")]
		[FieldOffset(Offset = "0xD8")]
		private MysteryPoolStoreItem m_MysteryStoreDesc;
	}
}
