using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001715 RID: 5909
	[Token(Token = "0x2001715")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F16C4", Offset = "0x10F16C4")]
	public class UIClanAreaItemController : UIPopMenuItemBaseController
	{
		// Token: 0x06006E2D RID: 28205 RVA: 0x0001F080 File Offset: 0x0001D280
		[Token(Token = "0x6006E2D")]
		[Address(RVA = "0x1BF9200", Offset = "0x1BF9200", VA = "0x7BBC3F9200")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E2E RID: 28206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2E")]
		[Address(RVA = "0x1BF9250", Offset = "0x1BF9250", VA = "0x7BBC3F9250", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E2F RID: 28207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2F")]
		[Address(RVA = "0x1BF9334", Offset = "0x1BF9334", VA = "0x7BBC3F9334", Slot = "28")]
		public override void SetItemData(PopMenuData data)
		{
		}

		// Token: 0x06006E30 RID: 28208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E30")]
		[Address(RVA = "0x1BF94AC", Offset = "0x1BF94AC", VA = "0x7BBC3F94AC")]
		private void SetSelectedState(bool selected)
		{
		}

		// Token: 0x06006E31 RID: 28209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E31")]
		[Address(RVA = "0x1BF95C4", Offset = "0x1BF95C4", VA = "0x7BBC3F95C4")]
		private void OnPopMenuItemClick()
		{
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E32")]
		[Address(RVA = "0x1BF9660", Offset = "0x1BF9660", VA = "0x7BBC3F9660")]
		public UIClanAreaItemController()
		{
		}

		// Token: 0x040088E9 RID: 35049
		[Token(Token = "0x40088E9")]
		[FieldOffset(Offset = "0x60")]
		private UIClanAreaItemView m_View;

		// Token: 0x040088EA RID: 35050
		[Token(Token = "0x40088EA")]
		[FieldOffset(Offset = "0x68")]
		private PopMenuData m_Data;

		// Token: 0x040088EB RID: 35051
		[Token(Token = "0x40088EB")]
		[FieldOffset(Offset = "0x70")]
		private ClanAreaItemVO m_VO;
	}
}
