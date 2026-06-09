using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002168 RID: 8552
	[Token(Token = "0x2002168")]
	internal class UIClanDetailsView : UIBaseView
	{
		// Token: 0x0600BDE0 RID: 48608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE0")]
		[Address(RVA = "0x1CFAF88", Offset = "0x1CFAF88", VA = "0x7BBC4FAF88", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDE1 RID: 48609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE1")]
		[Address(RVA = "0x1CFB214", Offset = "0x1CFB214", VA = "0x7BBC4FB214")]
		public UIClanDetailsView()
		{
		}

		// Token: 0x0400C5ED RID: 50669
		[Token(Token = "0x400C5ED")]
		[FieldOffset(Offset = "0x20")]
		public UILabel NameLabel;

		// Token: 0x0400C5EE RID: 50670
		[Token(Token = "0x400C5EE")]
		[FieldOffset(Offset = "0x28")]
		public UILabel IDLabel;

		// Token: 0x0400C5EF RID: 50671
		[Token(Token = "0x400C5EF")]
		[FieldOffset(Offset = "0x30")]
		public UISprite GuildIcon;

		// Token: 0x0400C5F0 RID: 50672
		[Token(Token = "0x400C5F0")]
		[FieldOffset(Offset = "0x38")]
		public UILabel GloryLabel;

		// Token: 0x0400C5F1 RID: 50673
		[Token(Token = "0x400C5F1")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TAGLabel;

		// Token: 0x0400C5F2 RID: 50674
		[Token(Token = "0x400C5F2")]
		[FieldOffset(Offset = "0x48")]
		public UITable TableContent;

		// Token: 0x0400C5F3 RID: 50675
		[Token(Token = "0x400C5F3")]
		[FieldOffset(Offset = "0x50")]
		public GameObject AreaContainer;

		// Token: 0x0400C5F4 RID: 50676
		[Token(Token = "0x400C5F4")]
		[FieldOffset(Offset = "0x58")]
		public UILabel AreaLabel;

		// Token: 0x0400C5F5 RID: 50677
		[Token(Token = "0x400C5F5")]
		[FieldOffset(Offset = "0x60")]
		public Transform GuildLeaderContent;
	}
}
