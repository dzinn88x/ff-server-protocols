using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024C6 RID: 9414
	[Token(Token = "0x20024C6")]
	public class UIRankMapSelectView : UIBaseView
	{
		// Token: 0x0600C49C RID: 50332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C49C")]
		[Address(RVA = "0x1E10D8C", Offset = "0x1E10D8C", VA = "0x7BBC610D8C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C49D RID: 50333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C49D")]
		[Address(RVA = "0x1E11000", Offset = "0x1E11000", VA = "0x7BBC611000")]
		public UIRankMapSelectView()
		{
		}

		// Token: 0x0400EF6A RID: 61290
		[Token(Token = "0x400EF6A")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel UIRankMapSelect;

		// Token: 0x0400EF6B RID: 61291
		[Token(Token = "0x400EF6B")]
		[FieldOffset(Offset = "0x28")]
		public UIToggleButton ModeBtn;

		// Token: 0x0400EF6C RID: 61292
		[Token(Token = "0x400EF6C")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList MapList;

		// Token: 0x0400EF6D RID: 61293
		[Token(Token = "0x400EF6D")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Bottom;

		// Token: 0x0400EF6E RID: 61294
		[Token(Token = "0x400EF6E")]
		[FieldOffset(Offset = "0x40")]
		public UILabel MapInfos;

		// Token: 0x0400EF6F RID: 61295
		[Token(Token = "0x400EF6F")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ExtraPoint;

		// Token: 0x0400EF70 RID: 61296
		[Token(Token = "0x400EF70")]
		[FieldOffset(Offset = "0x50")]
		public UILabel RPLabel;

		// Token: 0x0400EF71 RID: 61297
		[Token(Token = "0x400EF71")]
		[FieldOffset(Offset = "0x58")]
		public UIButton ConfirmButton;
	}
}
