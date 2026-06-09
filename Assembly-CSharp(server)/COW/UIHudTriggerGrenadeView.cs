using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200238E RID: 9102
	[Token(Token = "0x200238E")]
	public class UIHudTriggerGrenadeView : UIBaseView
	{
		// Token: 0x0600C22C RID: 49708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C22C")]
		[Address(RVA = "0x15ECFF0", Offset = "0x15ECFF0", VA = "0x7BBBDECFF0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C22D RID: 49709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C22D")]
		[Address(RVA = "0x15ED1E8", Offset = "0x15ED1E8", VA = "0x7BBBDED1E8")]
		public UIHudTriggerGrenadeView()
		{
		}

		// Token: 0x0400DCFF RID: 56575
		[Token(Token = "0x400DCFF")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Root;

		// Token: 0x0400DD00 RID: 56576
		[Token(Token = "0x400DD00")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Button;

		// Token: 0x0400DD01 RID: 56577
		[Token(Token = "0x400DD01")]
		[FieldOffset(Offset = "0x30")]
		public UISprite GrenadeIcon;

		// Token: 0x0400DD02 RID: 56578
		[Token(Token = "0x400DD02")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CDIcon;

		// Token: 0x0400DD03 RID: 56579
		[Token(Token = "0x400DD03")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Circle;

		// Token: 0x0400DD04 RID: 56580
		[Token(Token = "0x400DD04")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TimeLabel;
	}
}
