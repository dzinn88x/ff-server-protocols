using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200184F RID: 6223
	[Token(Token = "0x200184F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3C8C", Offset = "0x10F3C8C")]
	public class UIGoogleEngagementRewardsAccountItemController : UIBaseController
	{
		// Token: 0x06007A28 RID: 31272 RVA: 0x000219A8 File Offset: 0x0001FBA8
		[Token(Token = "0x6007A28")]
		[Address(RVA = "0x1A8397C", Offset = "0x1A8397C", VA = "0x7BBC28397C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A29")]
		[Address(RVA = "0x1A839CC", Offset = "0x1A839CC", VA = "0x7BBC2839CC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A2A")]
		[Address(RVA = "0x1A83AB0", Offset = "0x1A83AB0", VA = "0x7BBC283AB0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A2B")]
		[Address(RVA = "0x1A83AB8", Offset = "0x1A83AB8", VA = "0x7BBC283AB8")]
		public void SetScrollview(UIScrollView scrollView)
		{
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A2C")]
		[Address(RVA = "0x1A83AF8", Offset = "0x1A83AF8", VA = "0x7BBC283AF8")]
		public void SetData(string accountName)
		{
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A2D")]
		[Address(RVA = "0x1A83B44", Offset = "0x1A83B44", VA = "0x7BBC283B44")]
		private void OnClick()
		{
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A2E")]
		[Address(RVA = "0x1A83BF0", Offset = "0x1A83BF0", VA = "0x7BBC283BF0")]
		public UIGoogleEngagementRewardsAccountItemController()
		{
		}

		// Token: 0x04008F11 RID: 36625
		[Token(Token = "0x4008F11")]
		[FieldOffset(Offset = "0x58")]
		private UIGoogleEngagementRewardsAccountItemView m_View;

		// Token: 0x04008F12 RID: 36626
		[Token(Token = "0x4008F12")]
		[FieldOffset(Offset = "0x60")]
		private string m_AccountName;
	}
}
