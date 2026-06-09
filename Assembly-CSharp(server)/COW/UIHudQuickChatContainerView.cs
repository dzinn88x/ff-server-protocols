using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200233A RID: 9018
	[Token(Token = "0x200233A")]
	public class UIHudQuickChatContainerView : UIBaseView
	{
		// Token: 0x0600C184 RID: 49540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C184")]
		[Address(RVA = "0x17E0B38", Offset = "0x17E0B38", VA = "0x7BBBFE0B38", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C185 RID: 49541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C185")]
		[Address(RVA = "0x17E0C58", Offset = "0x17E0C58", VA = "0x7BBBFE0C58")]
		public UIHudQuickChatContainerView()
		{
		}

		// Token: 0x0400DA96 RID: 55958
		[Token(Token = "0x400DA96")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView ScrollView;

		// Token: 0x0400DA97 RID: 55959
		[Token(Token = "0x400DA97")]
		[FieldOffset(Offset = "0x28")]
		public UITable MessageListTable;

		// Token: 0x0400DA98 RID: 55960
		[Token(Token = "0x400DA98")]
		[FieldOffset(Offset = "0x30")]
		public QuickChatView ChatMessageInstance;
	}
}
