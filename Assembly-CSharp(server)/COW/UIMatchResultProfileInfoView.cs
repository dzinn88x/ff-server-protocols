using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200243B RID: 9275
	[Token(Token = "0x200243B")]
	public class UIMatchResultProfileInfoView : UIBaseView
	{
		// Token: 0x0600C386 RID: 50054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C386")]
		[Address(RVA = "0x147AEE8", Offset = "0x147AEE8", VA = "0x7BBBC7AEE8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C387 RID: 50055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C387")]
		[Address(RVA = "0x147B0E0", Offset = "0x147B0E0", VA = "0x7BBBC7B0E0")]
		public UIMatchResultProfileInfoView()
		{
		}

		// Token: 0x0400E704 RID: 59140
		[Token(Token = "0x400E704")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SelfBG;

		// Token: 0x0400E705 RID: 59141
		[Token(Token = "0x400E705")]
		[FieldOffset(Offset = "0x28")]
		public GameObject NormalBG;

		// Token: 0x0400E706 RID: 59142
		[Token(Token = "0x400E706")]
		[FieldOffset(Offset = "0x30")]
		public GameObject IconCelebrity;

		// Token: 0x0400E707 RID: 59143
		[Token(Token = "0x400E707")]
		[FieldOffset(Offset = "0x38")]
		public UILabel PlayerNameTxt;

		// Token: 0x0400E708 RID: 59144
		[Token(Token = "0x400E708")]
		[FieldOffset(Offset = "0x40")]
		public UILabel KillNumTxt;

		// Token: 0x0400E709 RID: 59145
		[Token(Token = "0x400E709")]
		[FieldOffset(Offset = "0x48")]
		public UILabel DamageNumTxt;

		// Token: 0x0400E70A RID: 59146
		[Token(Token = "0x400E70A")]
		[FieldOffset(Offset = "0x50")]
		public GameObject MVPFlag;
	}
}
