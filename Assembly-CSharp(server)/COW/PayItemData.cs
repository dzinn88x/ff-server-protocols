using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C8E RID: 7310
	[Token(Token = "0x2001C8E")]
	public class PayItemData
	{
		// Token: 0x06009F96 RID: 40854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F96")]
		[Address(RVA = "0x203DD9C", Offset = "0x203DD9C", VA = "0x7BBC83DD9C")]
		public static string Brief(PayItemData data)
		{
			return null;
		}

		// Token: 0x06009F97 RID: 40855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F97")]
		[Address(RVA = "0x203DFFC", Offset = "0x203DFFC", VA = "0x7BBC83DFFC")]
		public static string Detail(PayItemData data)
		{
			return null;
		}

		// Token: 0x06009F98 RID: 40856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F98")]
		[Address(RVA = "0x203E324", Offset = "0x203E324", VA = "0x7BBC83E324")]
		public PayItemData()
		{
		}

		// Token: 0x0400A641 RID: 42561
		[Token(Token = "0x400A641")]
		[FieldOffset(Offset = "0x10")]
		public string ItemIdentifier;

		// Token: 0x0400A642 RID: 42562
		[Token(Token = "0x400A642")]
		[FieldOffset(Offset = "0x18")]
		public int VirtualCurrencyCount;

		// Token: 0x0400A643 RID: 42563
		[Token(Token = "0x400A643")]
		[FieldOffset(Offset = "0x1C")]
		public int BonusVirtualCurrencyCount;

		// Token: 0x0400A644 RID: 42564
		[Token(Token = "0x400A644")]
		[FieldOffset(Offset = "0x20")]
		public int PromotionVirtualCurrencyCount;

		// Token: 0x0400A645 RID: 42565
		[Token(Token = "0x400A645")]
		[FieldOffset(Offset = "0x24")]
		public float CostAmount;

		// Token: 0x0400A646 RID: 42566
		[Token(Token = "0x400A646")]
		[FieldOffset(Offset = "0x28")]
		public string CostString;

		// Token: 0x0400A647 RID: 42567
		[Token(Token = "0x400A647")]
		[FieldOffset(Offset = "0x30")]
		public string CdnUrl;

		// Token: 0x0400A648 RID: 42568
		[Token(Token = "0x400A648")]
		[FieldOffset(Offset = "0x38")]
		public string ResourceName;

		// Token: 0x0400A649 RID: 42569
		[Token(Token = "0x400A649")]
		[FieldOffset(Offset = "0x40")]
		public ResourceID ResourceId;

		// Token: 0x0400A64A RID: 42570
		[Token(Token = "0x400A64A")]
		[FieldOffset(Offset = "0x48")]
		public Subscription Subscription;

		// Token: 0x0400A64B RID: 42571
		[Token(Token = "0x400A64B")]
		[FieldOffset(Offset = "0x50")]
		public long RebateId;
	}
}
