using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023D1 RID: 9169
	[Token(Token = "0x20023D1")]
	public class UIInvitePlatformView : UIBaseView
	{
		// Token: 0x0600C2B2 RID: 49842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2B2")]
		[Address(RVA = "0x1E84F08", Offset = "0x1E84F08", VA = "0x7BBC684F08", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2B3 RID: 49843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2B3")]
		[Address(RVA = "0x1E85100", Offset = "0x1E85100", VA = "0x7BBC685100")]
		public UIInvitePlatformView()
		{
		}

		// Token: 0x0400DF55 RID: 57173
		[Token(Token = "0x400DF55")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid GridInterAppInvite;

		// Token: 0x0400DF56 RID: 57174
		[Token(Token = "0x400DF56")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnCopyLink;

		// Token: 0x0400DF57 RID: 57175
		[Token(Token = "0x400DF57")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnLineInvite;

		// Token: 0x0400DF58 RID: 57176
		[Token(Token = "0x400DF58")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnFBInvite;

		// Token: 0x0400DF59 RID: 57177
		[Token(Token = "0x400DF59")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnVKInvite;

		// Token: 0x0400DF5A RID: 57178
		[Token(Token = "0x400DF5A")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnOtherInvite;

		// Token: 0x0400DF5B RID: 57179
		[Token(Token = "0x400DF5B")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Tips;
	}
}
