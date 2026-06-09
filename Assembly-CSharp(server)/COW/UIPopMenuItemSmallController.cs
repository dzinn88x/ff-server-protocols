using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B05 RID: 6917
	[Token(Token = "0x2001B05")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F92D4", Offset = "0x10F92D4")]
	public class UIPopMenuItemSmallController : UIBaseController
	{
		// Token: 0x06009307 RID: 37639 RVA: 0x00027198 File Offset: 0x00025398
		[Token(Token = "0x6009307")]
		[Address(RVA = "0x20EC40C", Offset = "0x20EC40C", VA = "0x7BBC8EC40C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009308 RID: 37640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009308")]
		[Address(RVA = "0x20EC45C", Offset = "0x20EC45C", VA = "0x7BBC8EC45C")]
		public void SetDragDisable()
		{
		}

		// Token: 0x06009309 RID: 37641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009309")]
		[Address(RVA = "0x20EC4A0", Offset = "0x20EC4A0", VA = "0x7BBC8EC4A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600930A RID: 37642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600930A")]
		[Address(RVA = "0x20EC584", Offset = "0x20EC584", VA = "0x7BBC8EC584", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600930B RID: 37643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600930B")]
		[Address(RVA = "0x20EC58C", Offset = "0x20EC58C", VA = "0x7BBC8EC58C")]
		public void SetItemData(PopMenuData data)
		{
		}

		// Token: 0x0600930C RID: 37644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600930C")]
		[Address(RVA = "0x20ECC70", Offset = "0x20ECC70", VA = "0x7BBC8ECC70")]
		public void SetCellWidthWithParent(int width)
		{
		}

		// Token: 0x0600930D RID: 37645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600930D")]
		[Address(RVA = "0x20ECCB8", Offset = "0x20ECCB8", VA = "0x7BBC8ECCB8")]
		private void OnPopMenuItemClick()
		{
		}

		// Token: 0x0600930E RID: 37646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600930E")]
		[Address(RVA = "0x20ECF58", Offset = "0x20ECF58", VA = "0x7BBC8ECF58")]
		public UIPopMenuItemSmallController()
		{
		}

		// Token: 0x04009D37 RID: 40247
		[Token(Token = "0x4009D37")]
		[FieldOffset(Offset = "0x58")]
		private UIPopMenuItemSmallView m_View;

		// Token: 0x04009D38 RID: 40248
		[Token(Token = "0x4009D38")]
		[FieldOffset(Offset = "0x60")]
		private PopMenuData m_Data;
	}
}
