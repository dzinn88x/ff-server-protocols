using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020D9 RID: 8409
	[Token(Token = "0x20020D9")]
	public class UIActivityAnnouncementView : UIBaseView
	{
		// Token: 0x0600BCC3 RID: 48323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC3")]
		[Address(RVA = "0x1A456B4", Offset = "0x1A456B4", VA = "0x7BBC2456B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCC4 RID: 48324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC4")]
		[Address(RVA = "0x1A45910", Offset = "0x1A45910", VA = "0x7BBC245910")]
		public UIActivityAnnouncementView()
		{
		}

		// Token: 0x0400BEA8 RID: 48808
		[Token(Token = "0x400BEA8")]
		[FieldOffset(Offset = "0x20")]
		public Transform LeftTabContainer;

		// Token: 0x0400BEA9 RID: 48809
		[Token(Token = "0x400BEA9")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture AD;

		// Token: 0x0400BEAA RID: 48810
		[Token(Token = "0x400BEAA")]
		[FieldOffset(Offset = "0x30")]
		public UITable ContentTable;

		// Token: 0x0400BEAB RID: 48811
		[Token(Token = "0x400BEAB")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Facebook;

		// Token: 0x0400BEAC RID: 48812
		[Token(Token = "0x400BEAC")]
		[FieldOffset(Offset = "0x40")]
		public UIButton Official;

		// Token: 0x0400BEAD RID: 48813
		[Token(Token = "0x400BEAD")]
		[FieldOffset(Offset = "0x48")]
		public UIButton Ins;

		// Token: 0x0400BEAE RID: 48814
		[Token(Token = "0x400BEAE")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Introduction;

		// Token: 0x0400BEAF RID: 48815
		[Token(Token = "0x400BEAF")]
		[FieldOffset(Offset = "0x58")]
		public UIButton Operation;
	}
}
