using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B03 RID: 6915
	[Token(Token = "0x2001B03")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F923C", Offset = "0x10F923C")]
	public class UIPopMenuItemBigController : UIBaseController
	{
		// Token: 0x060092F9 RID: 37625 RVA: 0x00027168 File Offset: 0x00025368
		[Token(Token = "0x60092F9")]
		[Address(RVA = "0x20EBACC", Offset = "0x20EBACC", VA = "0x7BBC8EBACC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060092FA RID: 37626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092FA")]
		[Address(RVA = "0x20EBB1C", Offset = "0x20EBB1C", VA = "0x7BBC8EBB1C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060092FB RID: 37627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092FB")]
		[Address(RVA = "0x20EBC00", Offset = "0x20EBC00", VA = "0x7BBC8EBC00", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060092FC RID: 37628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092FC")]
		[Address(RVA = "0x20EA6C8", Offset = "0x20EA6C8", VA = "0x7BBC8EA6C8")]
		public void SetDragDisable()
		{
		}

		// Token: 0x060092FD RID: 37629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092FD")]
		[Address(RVA = "0x20EA2C8", Offset = "0x20EA2C8", VA = "0x7BBC8EA2C8")]
		public void SetItemData(PopMenuData data)
		{
		}

		// Token: 0x060092FE RID: 37630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092FE")]
		[Address(RVA = "0x20EA680", Offset = "0x20EA680", VA = "0x7BBC8EA680")]
		public void SetCellWidthWithParent(int width)
		{
		}

		// Token: 0x060092FF RID: 37631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092FF")]
		[Address(RVA = "0x20EBC08", Offset = "0x20EBC08", VA = "0x7BBC8EBC08")]
		private void OnPopMenuItemClick()
		{
		}

		// Token: 0x06009300 RID: 37632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009300")]
		[Address(RVA = "0x20EBEA8", Offset = "0x20EBEA8", VA = "0x7BBC8EBEA8")]
		public UIPopMenuItemBigController()
		{
		}

		// Token: 0x04009D33 RID: 40243
		[Token(Token = "0x4009D33")]
		[FieldOffset(Offset = "0x58")]
		private UIPopMenuItemBigView m_View;

		// Token: 0x04009D34 RID: 40244
		[Token(Token = "0x4009D34")]
		[FieldOffset(Offset = "0x60")]
		private PopMenuData m_Data;
	}
}
