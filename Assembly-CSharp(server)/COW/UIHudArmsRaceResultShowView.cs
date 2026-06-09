using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200226B RID: 8811
	[Token(Token = "0x200226B")]
	public class UIHudArmsRaceResultShowView : UIBaseView
	{
		// Token: 0x0600BFE7 RID: 49127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE7")]
		[Address(RVA = "0x18876D4", Offset = "0x18876D4", VA = "0x7BBC0876D4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFE8 RID: 49128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE8")]
		[Address(RVA = "0x1887920", Offset = "0x1887920", VA = "0x7BBC087920")]
		public UIHudArmsRaceResultShowView()
		{
		}

		// Token: 0x0400D392 RID: 54162
		[Token(Token = "0x400D392")]
		[FieldOffset(Offset = "0x20")]
		public GameObject CallSignContainer;

		// Token: 0x0400D393 RID: 54163
		[Token(Token = "0x400D393")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnMask;

		// Token: 0x0400D394 RID: 54164
		[Token(Token = "0x400D394")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnShare;

		// Token: 0x0400D395 RID: 54165
		[Token(Token = "0x400D395")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnNext;

		// Token: 0x0400D396 RID: 54166
		[Token(Token = "0x400D396")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Rank1;

		// Token: 0x0400D397 RID: 54167
		[Token(Token = "0x400D397")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Rank2;

		// Token: 0x0400D398 RID: 54168
		[Token(Token = "0x400D398")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Rank3;

		// Token: 0x0400D399 RID: 54169
		[Token(Token = "0x400D399")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Rank4;
	}
}
