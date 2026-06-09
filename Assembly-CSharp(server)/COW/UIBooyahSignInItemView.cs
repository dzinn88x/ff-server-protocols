using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002121 RID: 8481
	[Token(Token = "0x2002121")]
	public class UIBooyahSignInItemView : UIBaseView
	{
		// Token: 0x0600BD52 RID: 48466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD52")]
		[Address(RVA = "0x1432F38", Offset = "0x1432F38", VA = "0x7BBBC32F38", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD53 RID: 48467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD53")]
		[Address(RVA = "0x1433108", Offset = "0x1433108", VA = "0x7BBBC33108")]
		public UIBooyahSignInItemView()
		{
		}

		// Token: 0x0400C275 RID: 49781
		[Token(Token = "0x400C275")]
		[FieldOffset(Offset = "0x20")]
		public Animator ItemAnimator;

		// Token: 0x0400C276 RID: 49782
		[Token(Token = "0x400C276")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SpriteBooyah;

		// Token: 0x0400C277 RID: 49783
		[Token(Token = "0x400C277")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SpriteFail;

		// Token: 0x0400C278 RID: 49784
		[Token(Token = "0x400C278")]
		[FieldOffset(Offset = "0x38")]
		public GameObject SpriteBack;

		// Token: 0x0400C279 RID: 49785
		[Token(Token = "0x400C279")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SpriteChosen;

		// Token: 0x0400C27A RID: 49786
		[Token(Token = "0x400C27A")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnCard;
	}
}
