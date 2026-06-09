using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C44 RID: 7236
	[Token(Token = "0x2001C44")]
	public class UIInventoryItemDragDropContainer : UIDragDropContainer
	{
		// Token: 0x06009D4F RID: 40271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D4F")]
		[Address(RVA = "0x1919978", Offset = "0x1919978", VA = "0x7BBC119978")]
		public UIInventoryItemDragDropContainer()
		{
		}

		// Token: 0x0400A345 RID: 41797
		[Token(Token = "0x400A345")]
		[FieldOffset(Offset = "0x20")]
		public UIInventoryItemDragDropContainer ParentContainer;

		// Token: 0x0400A346 RID: 41798
		[Token(Token = "0x400A346")]
		[FieldOffset(Offset = "0x28")]
		public EInventoryDragDropContainerType ContainerType;
	}
}
