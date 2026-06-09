using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200210D RID: 8461
	[Token(Token = "0x200210D")]
	public class UIAvatarSuitListItemView : UIBaseView
	{
		// Token: 0x0600BD2B RID: 48427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD2B")]
		[Address(RVA = "0x1E528F8", Offset = "0x1E528F8", VA = "0x7BBC6528F8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD2C RID: 48428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD2C")]
		[Address(RVA = "0x1E52B5C", Offset = "0x1E52B5C", VA = "0x7BBC652B5C")]
		public UIAvatarSuitListItemView()
		{
		}

		// Token: 0x0400C1A2 RID: 49570
		[Token(Token = "0x400C1A2")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Download;

		// Token: 0x0400C1A3 RID: 49571
		[Token(Token = "0x400C1A3")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SuitBtn;

		// Token: 0x0400C1A4 RID: 49572
		[Token(Token = "0x400C1A4")]
		[FieldOffset(Offset = "0x30")]
		public UISprite SuitSprite;

		// Token: 0x0400C1A5 RID: 49573
		[Token(Token = "0x400C1A5")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HL;

		// Token: 0x0400C1A6 RID: 49574
		[Token(Token = "0x400C1A6")]
		[FieldOffset(Offset = "0x40")]
		public UILabel SuitNameLabel;

		// Token: 0x0400C1A7 RID: 49575
		[Token(Token = "0x400C1A7")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ownStateLabel;

		// Token: 0x0400C1A8 RID: 49576
		[Token(Token = "0x400C1A8")]
		[FieldOffset(Offset = "0x50")]
		public UIButton equipBtn;

		// Token: 0x0400C1A9 RID: 49577
		[Token(Token = "0x400C1A9")]
		[FieldOffset(Offset = "0x58")]
		public UIButton obtainBtn;
	}
}
