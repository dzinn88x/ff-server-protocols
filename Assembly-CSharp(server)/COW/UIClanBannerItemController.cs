using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200171A RID: 5914
	[Token(Token = "0x200171A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F17DC", Offset = "0x10F17DC")]
	public class UIClanBannerItemController : UIEasyListItemController
	{
		// Token: 0x06006E4E RID: 28238 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		[Token(Token = "0x6006E4E")]
		[Address(RVA = "0x1CEB918", Offset = "0x1CEB918", VA = "0x7BBC4EB918")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E4F RID: 28239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E4F")]
		[Address(RVA = "0x1CEB968", Offset = "0x1CEB968", VA = "0x7BBC4EB968", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E50 RID: 28240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E50")]
		[Address(RVA = "0x1CEBA4C", Offset = "0x1CEBA4C", VA = "0x7BBC4EBA4C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006E51 RID: 28241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E51")]
		[Address(RVA = "0x1CEBCF8", Offset = "0x1CEBCF8", VA = "0x7BBC4EBCF8")]
		private void SelectBanner()
		{
		}

		// Token: 0x06006E52 RID: 28242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E52")]
		[Address(RVA = "0x1CEBE0C", Offset = "0x1CEBE0C", VA = "0x7BBC4EBE0C")]
		public UIClanBannerItemController()
		{
		}

		// Token: 0x040088F2 RID: 35058
		[Token(Token = "0x40088F2")]
		[FieldOffset(Offset = "0x70")]
		private UIClanBannerItemView m_View;

		// Token: 0x040088F3 RID: 35059
		[Token(Token = "0x40088F3")]
		[FieldOffset(Offset = "0x78")]
		private BannerBaseInfo m_ClanBannerInfo;
	}
}
