using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002105 RID: 8453
	[Token(Token = "0x2002105")]
	internal class UIAvatarProfileItemView : UIBaseView
	{
		// Token: 0x0600BD1B RID: 48411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1B")]
		[Address(RVA = "0x208CF78", Offset = "0x208CF78", VA = "0x7BBC88CF78", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD1C RID: 48412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1C")]
		[Address(RVA = "0x208D3C4", Offset = "0x208D3C4", VA = "0x7BBC88D3C4")]
		public UIAvatarProfileItemView()
		{
		}

		// Token: 0x0400C097 RID: 49303
		[Token(Token = "0x400C097")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ProfileBtn;

		// Token: 0x0400C098 RID: 49304
		[Token(Token = "0x400C098")]
		[FieldOffset(Offset = "0x28")]
		public GameObject UnlockNode;

		// Token: 0x0400C099 RID: 49305
		[Token(Token = "0x400C099")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ProfileTitle;

		// Token: 0x0400C09A RID: 49306
		[Token(Token = "0x400C09A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject LockNode;

		// Token: 0x0400C09B RID: 49307
		[Token(Token = "0x400C09B")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TXT_PROFILE_LOCKED_INVISIBLE;

		// Token: 0x0400C09C RID: 49308
		[Token(Token = "0x400C09C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject CanUnlockNode;

		// Token: 0x0400C09D RID: 49309
		[Token(Token = "0x400C09D")]
		[FieldOffset(Offset = "0x50")]
		public Transform unlockTips;

		// Token: 0x0400C09E RID: 49310
		[Token(Token = "0x400C09E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject TipsGO;

		// Token: 0x0400C09F RID: 49311
		[Token(Token = "0x400C09F")]
		[FieldOffset(Offset = "0x60")]
		public GameObject SatisfyHL;

		// Token: 0x0400C0A0 RID: 49312
		[Token(Token = "0x400C0A0")]
		[FieldOffset(Offset = "0x68")]
		public GameObject HasOwnObject;

		// Token: 0x0400C0A1 RID: 49313
		[Token(Token = "0x400C0A1")]
		[FieldOffset(Offset = "0x70")]
		public UILabel NeedLevel;

		// Token: 0x0400C0A2 RID: 49314
		[Token(Token = "0x400C0A2")]
		[FieldOffset(Offset = "0x78")]
		public UILabel DebrisCount;

		// Token: 0x0400C0A3 RID: 49315
		[Token(Token = "0x400C0A3")]
		[FieldOffset(Offset = "0x80")]
		public GameObject NotOwnObject;

		// Token: 0x0400C0A4 RID: 49316
		[Token(Token = "0x400C0A4")]
		[FieldOffset(Offset = "0x88")]
		public UIButton AwardBtn;

		// Token: 0x0400C0A5 RID: 49317
		[Token(Token = "0x400C0A5")]
		[FieldOffset(Offset = "0x90")]
		public UISprite AwardSprite;

		// Token: 0x0400C0A6 RID: 49318
		[Token(Token = "0x400C0A6")]
		[FieldOffset(Offset = "0x98")]
		public UISprite UnKnownAward;
	}
}
