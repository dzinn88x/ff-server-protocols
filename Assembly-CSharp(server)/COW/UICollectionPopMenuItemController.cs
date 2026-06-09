using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200173B RID: 5947
	[Token(Token = "0x200173B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1C2C", Offset = "0x10F1C2C")]
	public class UICollectionPopMenuItemController : UIPopMenuItemBaseController
	{
		// Token: 0x06006FD1 RID: 28625 RVA: 0x0001F5A8 File Offset: 0x0001D7A8
		[Token(Token = "0x6006FD1")]
		[Address(RVA = "0x20A9F58", Offset = "0x20A9F58", VA = "0x7BBC8A9F58")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006FD2 RID: 28626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD2")]
		[Address(RVA = "0x20A9FA8", Offset = "0x20A9FA8", VA = "0x7BBC8A9FA8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006FD3 RID: 28627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD3")]
		[Address(RVA = "0x20AA114", Offset = "0x20AA114", VA = "0x7BBC8AA114", Slot = "29")]
		public override void SetItemData(PopMenuData data, int CellWidth, int CellHeight)
		{
		}

		// Token: 0x06006FD4 RID: 28628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD4")]
		[Address(RVA = "0x20AA5B8", Offset = "0x20AA5B8", VA = "0x7BBC8AA5B8")]
		private void SetSelectedState(bool selected)
		{
		}

		// Token: 0x06006FD5 RID: 28629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD5")]
		[Address(RVA = "0x20AA600", Offset = "0x20AA600", VA = "0x7BBC8AA600")]
		public void OnPopMenuItemClick()
		{
		}

		// Token: 0x06006FD6 RID: 28630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD6")]
		[Address(RVA = "0x20AA9D4", Offset = "0x20AA9D4", VA = "0x7BBC8AA9D4")]
		public UICollectionPopMenuItemController()
		{
		}

		// Token: 0x040089D4 RID: 35284
		[Token(Token = "0x40089D4")]
		[FieldOffset(Offset = "0x60")]
		private UICollectionPopMeuItemView m_View;

		// Token: 0x040089D5 RID: 35285
		[Token(Token = "0x40089D5")]
		[FieldOffset(Offset = "0x68")]
		private PopMenuData m_Data;

		// Token: 0x040089D6 RID: 35286
		[Token(Token = "0x40089D6")]
		[FieldOffset(Offset = "0x70")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x0200173C RID: 5948
		[Token(Token = "0x200173C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1C64", Offset = "0x10F1C64")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006FD8 RID: 28632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006FD8")]
			[Address(RVA = "0x20AAA40", Offset = "0x20AAA40", VA = "0x7BBC8AAA40")]
			public <>c()
			{
			}

			// Token: 0x06006FD9 RID: 28633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006FD9")]
			[Address(RVA = "0x20AAA48", Offset = "0x20AAA48", VA = "0x7BBC8AAA48")]
			internal void <OnPopMenuItemClick>b__7_0()
			{
			}

			// Token: 0x040089D7 RID: 35287
			[Token(Token = "0x40089D7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UICollectionPopMenuItemController.<>c <>9;

			// Token: 0x040089D8 RID: 35288
			[Token(Token = "0x40089D8")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__7_0;
		}
	}
}
