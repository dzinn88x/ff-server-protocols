using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002440 RID: 9280
	[Token(Token = "0x2002440")]
	internal class UIMatchZombieResultInfoItemView : UIBaseView
	{
		// Token: 0x0600C390 RID: 50064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C390")]
		[Address(RVA = "0x14842C4", Offset = "0x14842C4", VA = "0x7BBBC842C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C391 RID: 50065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C391")]
		[Address(RVA = "0x14844CC", Offset = "0x14844CC", VA = "0x7BBBC844CC")]
		public UIMatchZombieResultInfoItemView()
		{
		}

		// Token: 0x0400E753 RID: 59219
		[Token(Token = "0x400E753")]
		[FieldOffset(Offset = "0x20")]
		public UIButton AddFriendBtn;

		// Token: 0x0400E754 RID: 59220
		[Token(Token = "0x400E754")]
		[FieldOffset(Offset = "0x28")]
		public GameObject briefProfile;

		// Token: 0x0400E755 RID: 59221
		[Token(Token = "0x400E755")]
		[FieldOffset(Offset = "0x30")]
		public UISprite WeaponIcon;

		// Token: 0x0400E756 RID: 59222
		[Token(Token = "0x400E756")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ScoreLabel;

		// Token: 0x0400E757 RID: 59223
		[Token(Token = "0x400E757")]
		[FieldOffset(Offset = "0x40")]
		public GameObject EndLine;

		// Token: 0x0400E758 RID: 59224
		[Token(Token = "0x400E758")]
		[FieldOffset(Offset = "0x48")]
		public GameObject baseProfile;

		// Token: 0x0400E759 RID: 59225
		[Token(Token = "0x400E759")]
		[FieldOffset(Offset = "0x50")]
		public GameObject MVPIcon;
	}
}
