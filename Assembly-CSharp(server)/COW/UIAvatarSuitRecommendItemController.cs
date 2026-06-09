using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016D0 RID: 5840
	[Token(Token = "0x20016D0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0D9C", Offset = "0x10F0D9C")]
	public class UIAvatarSuitRecommendItemController : UIBaseController
	{
		// Token: 0x06006B69 RID: 27497 RVA: 0x0001E678 File Offset: 0x0001C878
		[Token(Token = "0x6006B69")]
		[Address(RVA = "0x1E52C5C", Offset = "0x1E52C5C", VA = "0x7BBC652C5C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B6A")]
		[Address(RVA = "0x1E52CAC", Offset = "0x1E52CAC", VA = "0x7BBC652CAC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B6B")]
		[Address(RVA = "0x1E52DE8", Offset = "0x1E52DE8", VA = "0x7BBC652DE8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B6C")]
		[Address(RVA = "0x1E52DF0", Offset = "0x1E52DF0", VA = "0x7BBC652DF0")]
		private void OnCloseClick()
		{
		}

		// Token: 0x06006B6D RID: 27501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B6D")]
		[Address(RVA = "0x1E52DF8", Offset = "0x1E52DF8", VA = "0x7BBC652DF8")]
		private void OnPurchaseClick()
		{
		}

		// Token: 0x06006B6E RID: 27502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B6E")]
		[Address(RVA = "0x1E5340C", Offset = "0x1E5340C", VA = "0x7BBC65340C")]
		public void RefreshData(uint suitId)
		{
		}

		// Token: 0x06006B6F RID: 27503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B6F")]
		[Address(RVA = "0x1E536F4", Offset = "0x1E536F4", VA = "0x7BBC6536F4")]
		public UIAvatarSuitRecommendItemController()
		{
		}

		// Token: 0x04008753 RID: 34643
		[Token(Token = "0x4008753")]
		[FieldOffset(Offset = "0x58")]
		private UIAvatarSuitRecommendItemView m_View;

		// Token: 0x04008754 RID: 34644
		[Token(Token = "0x4008754")]
		[FieldOffset(Offset = "0x60")]
		private uint m_SuitID;
	}
}
