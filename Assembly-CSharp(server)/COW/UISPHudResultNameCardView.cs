using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200252D RID: 9517
	[Token(Token = "0x200252D")]
	public class UISPHudResultNameCardView : UIBaseView
	{
		// Token: 0x0600C56A RID: 50538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C56A")]
		[Address(RVA = "0x1EF0690", Offset = "0x1EF0690", VA = "0x7BBC6F0690", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C56B RID: 50539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C56B")]
		[Address(RVA = "0x1EF082C", Offset = "0x1EF082C", VA = "0x7BBC6F082C")]
		public UISPHudResultNameCardView()
		{
		}

		// Token: 0x0400F342 RID: 62274
		[Token(Token = "0x400F342")]
		[FieldOffset(Offset = "0x20")]
		public GameObject OldCard;

		// Token: 0x0400F343 RID: 62275
		[Token(Token = "0x400F343")]
		[FieldOffset(Offset = "0x28")]
		public UILabel NameLabel;

		// Token: 0x0400F344 RID: 62276
		[Token(Token = "0x400F344")]
		[FieldOffset(Offset = "0x30")]
		public GameObject NewCard;

		// Token: 0x0400F345 RID: 62277
		[Token(Token = "0x400F345")]
		[FieldOffset(Offset = "0x38")]
		public UILabel NewNameLabel;

		// Token: 0x0400F346 RID: 62278
		[Token(Token = "0x400F346")]
		[FieldOffset(Offset = "0x40")]
		public GameObject MVP;
	}
}
