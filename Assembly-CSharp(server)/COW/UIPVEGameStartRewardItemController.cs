using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001630 RID: 5680
	[Token(Token = "0x2001630")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFD7C", Offset = "0x10EFD7C")]
	public class UIPVEGameStartRewardItemController : UIBaseController
	{
		// Token: 0x0600663C RID: 26172 RVA: 0x0001D2F8 File Offset: 0x0001B4F8
		[Token(Token = "0x600663C")]
		[Address(RVA = "0x16E3420", Offset = "0x16E3420", VA = "0x7BBBEE3420")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663D")]
		[Address(RVA = "0x16E3470", Offset = "0x16E3470", VA = "0x7BBBEE3470", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600663E RID: 26174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663E")]
		[Address(RVA = "0x16E2D7C", Offset = "0x16E2D7C", VA = "0x7BBBEE2D7C")]
		public void SetViewData(BaseItemInfo data)
		{
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663F")]
		[Address(RVA = "0x16E2D84", Offset = "0x16E2D84", VA = "0x7BBBEE2D84")]
		public void RefreshUI()
		{
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006640")]
		[Address(RVA = "0x16E34D4", Offset = "0x16E34D4", VA = "0x7BBBEE34D4")]
		public UIPVEGameStartRewardItemController()
		{
		}

		// Token: 0x04008413 RID: 33811
		[Token(Token = "0x4008413")]
		[FieldOffset(Offset = "0x58")]
		private UIPVEStartGameItemView m_View;

		// Token: 0x04008414 RID: 33812
		[Token(Token = "0x4008414")]
		[FieldOffset(Offset = "0x60")]
		private BaseItemInfo m_Data;
	}
}
