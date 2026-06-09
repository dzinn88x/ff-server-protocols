using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002321 RID: 8993
	[Token(Token = "0x2002321")]
	public class UIHudOBCountView : UIBaseView
	{
		// Token: 0x0600C152 RID: 49490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C152")]
		[Address(RVA = "0x17BC3CC", Offset = "0x17BC3CC", VA = "0x7BBBFBC3CC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C153 RID: 49491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C153")]
		[Address(RVA = "0x17BC5AC", Offset = "0x17BC5AC", VA = "0x7BBBFBC5AC")]
		public UIHudOBCountView()
		{
		}

		// Token: 0x0400D9EF RID: 55791
		[Token(Token = "0x400D9EF")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400D9F0 RID: 55792
		[Token(Token = "0x400D9F0")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SkillOBIcon;

		// Token: 0x0400D9F1 RID: 55793
		[Token(Token = "0x400D9F1")]
		[FieldOffset(Offset = "0x30")]
		public GameObject NormalOBIcon;

		// Token: 0x0400D9F2 RID: 55794
		[Token(Token = "0x400D9F2")]
		[FieldOffset(Offset = "0x38")]
		public UILabel countLabel;

		// Token: 0x0400D9F3 RID: 55795
		[Token(Token = "0x400D9F3")]
		[FieldOffset(Offset = "0x40")]
		public TweenAlpha TA;

		// Token: 0x0400D9F4 RID: 55796
		[Token(Token = "0x400D9F4")]
		[FieldOffset(Offset = "0x48")]
		public GameObject LikeIcon;
	}
}
