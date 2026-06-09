using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001733 RID: 5939
	[Token(Token = "0x2001733")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1B3C", Offset = "0x10F1B3C")]
	internal class UICollectionBgItemController : UIEasyListItemController
	{
		// Token: 0x06006F42 RID: 28482 RVA: 0x0001F3C8 File Offset: 0x0001D5C8
		[Token(Token = "0x6006F42")]
		[Address(RVA = "0x2096A44", Offset = "0x2096A44", VA = "0x7BBC896A44")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F43")]
		[Address(RVA = "0x2096A94", Offset = "0x2096A94", VA = "0x7BBC896A94", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006F44 RID: 28484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F44")]
		[Address(RVA = "0x2096D68", Offset = "0x2096D68", VA = "0x7BBC896D68", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F45")]
		[Address(RVA = "0x2096E34", Offset = "0x2096E34", VA = "0x7BBC896E34", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006F46 RID: 28486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F46")]
		[Address(RVA = "0x2097210", Offset = "0x2097210", VA = "0x7BBC897210", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F47")]
		[Address(RVA = "0x2097260", Offset = "0x2097260", VA = "0x7BBC897260")]
		public void HighLightCurrent()
		{
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F48")]
		[Address(RVA = "0x2097434", Offset = "0x2097434", VA = "0x7BBC897434", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F49")]
		[Address(RVA = "0x2097BF8", Offset = "0x2097BF8", VA = "0x7BBC897BF8")]
		private void OnBannerUpdate(object[] param)
		{
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F4A")]
		[Address(RVA = "0x20979E8", Offset = "0x20979E8", VA = "0x7BBC8979E8")]
		private void SetRankingItemIcon()
		{
		}

		// Token: 0x06006F4B RID: 28491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F4B")]
		[Address(RVA = "0x2097BFC", Offset = "0x2097BFC", VA = "0x7BBC897BFC")]
		public UICollectionBgItemController()
		{
		}

		// Token: 0x0400896F RID: 35183
		[Token(Token = "0x400896F")]
		[FieldOffset(Offset = "0x70")]
		private UICollectionBgItemView m_View;

		// Token: 0x04008970 RID: 35184
		[Token(Token = "0x4008970")]
		[FieldOffset(Offset = "0x78")]
		private BannerBaseInfo m_BannerBaseInfo;

		// Token: 0x04008971 RID: 35185
		[Token(Token = "0x4008971")]
		[FieldOffset(Offset = "0x80")]
		private UIModelCollection m_ModelCollection;
	}
}
