using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200156A RID: 5482
	[Token(Token = "0x200156A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE854", Offset = "0x10EE854")]
	public class UIExchangeMallRankItemController : UIExchangeMallItemController
	{
		// Token: 0x06005F49 RID: 24393 RVA: 0x0001B918 File Offset: 0x00019B18
		[Token(Token = "0x6005F49")]
		[Address(RVA = "0x2273458", Offset = "0x2273458", VA = "0x7BBCA73458")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4A")]
		[Address(RVA = "0x22734A8", Offset = "0x22734A8", VA = "0x7BBCA734A8", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4B")]
		[Address(RVA = "0x2273774", Offset = "0x2273774", VA = "0x7BBCA73774", Slot = "43")]
		protected override void SetPreviewTitle()
		{
		}

		// Token: 0x06005F4C RID: 24396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4C")]
		[Address(RVA = "0x2273968", Offset = "0x2273968", VA = "0x7BBCA73968", Slot = "40")]
		protected override void ResetState()
		{
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4D")]
		[Address(RVA = "0x22735D4", Offset = "0x22735D4", VA = "0x7BBCA735D4")]
		private void SetRankIcon()
		{
		}

		// Token: 0x06005F4E RID: 24398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4E")]
		[Address(RVA = "0x22734D4", Offset = "0x22734D4", VA = "0x7BBCA734D4")]
		private void CheckIsReachBuyRankLevel()
		{
		}

		// Token: 0x06005F4F RID: 24399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4F")]
		[Address(RVA = "0x22739CC", Offset = "0x22739CC", VA = "0x7BBCA739CC")]
		public UIExchangeMallRankItemController()
		{
		}

		// Token: 0x04007FF3 RID: 32755
		[Token(Token = "0x4007FF3")]
		[FieldOffset(Offset = "0x230")]
		private bool m_ReachBuyRankLevel;
	}
}
