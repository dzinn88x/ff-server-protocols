using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B02 RID: 6914
	[Token(Token = "0x2001B02")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x10F91DC", Offset = "0x10F91DC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F91DC", Offset = "0x10F91DC")]
	public class UIPopMenuItemBaseController : UIBaseController
	{
		// Token: 0x060092F5 RID: 37621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F5")]
		[Address(RVA = "0x20EBAB8", Offset = "0x20EBAB8", VA = "0x7BBC8EBAB8", Slot = "28")]
		public virtual void SetItemData(PopMenuData data)
		{
		}

		// Token: 0x060092F6 RID: 37622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F6")]
		[Address(RVA = "0x20EBABC", Offset = "0x20EBABC", VA = "0x7BBC8EBABC", Slot = "29")]
		public virtual void SetItemData(PopMenuData data, int CellWidth, int CellHeight)
		{
		}

		// Token: 0x060092F7 RID: 37623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F7")]
		[Address(RVA = "0x20EBAC0", Offset = "0x20EBAC0", VA = "0x7BBC8EBAC0", Slot = "30")]
		public virtual void SetItemData(PopMenuData data, int CellWidth, int CellHeight, float itemLocalPositionX, NGUIText.Alignment labelAlignment, UIWidget.Pivot labelPivot)
		{
		}

		// Token: 0x060092F8 RID: 37624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F8")]
		[Address(RVA = "0x20EBAC4", Offset = "0x20EBAC4", VA = "0x7BBC8EBAC4")]
		public UIPopMenuItemBaseController()
		{
		}

		// Token: 0x04009D32 RID: 40242
		[Token(Token = "0x4009D32")]
		[FieldOffset(Offset = "0x58")]
		public uint ItemIdex;
	}
}
