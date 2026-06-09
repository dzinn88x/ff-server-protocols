using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020DE RID: 8414
	[Token(Token = "0x20020DE")]
	public class UIActivityExchangeContentView : UIBaseView
	{
		// Token: 0x0600BCCD RID: 48333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCCD")]
		[Address(RVA = "0x194E8A0", Offset = "0x194E8A0", VA = "0x7BBC14E8A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCCE RID: 48334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCCE")]
		[Address(RVA = "0x194EAB8", Offset = "0x194EAB8", VA = "0x7BBC14EAB8")]
		public UIActivityExchangeContentView()
		{
		}

		// Token: 0x0400BEF2 RID: 48882
		[Token(Token = "0x400BEF2")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ScrollView_NoTabs;

		// Token: 0x0400BEF3 RID: 48883
		[Token(Token = "0x400BEF3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ScrollView;

		// Token: 0x0400BEF4 RID: 48884
		[Token(Token = "0x400BEF4")]
		[FieldOffset(Offset = "0x30")]
		public UITable ContentTable;

		// Token: 0x0400BEF5 RID: 48885
		[Token(Token = "0x400BEF5")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Introduction;

		// Token: 0x0400BEF6 RID: 48886
		[Token(Token = "0x400BEF6")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Time;

		// Token: 0x0400BEF7 RID: 48887
		[Token(Token = "0x400BEF7")]
		[FieldOffset(Offset = "0x48")]
		public UIDragScrollView DragArea;

		// Token: 0x0400BEF8 RID: 48888
		[Token(Token = "0x400BEF8")]
		[FieldOffset(Offset = "0x50")]
		public UIWidget DragWidget;
	}
}
