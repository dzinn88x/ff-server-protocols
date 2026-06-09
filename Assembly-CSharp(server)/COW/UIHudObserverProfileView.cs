using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002323 RID: 8995
	[Token(Token = "0x2002323")]
	public class UIHudObserverProfileView : UIBaseView
	{
		// Token: 0x0600C156 RID: 49494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C156")]
		[Address(RVA = "0x17BF064", Offset = "0x17BF064", VA = "0x7BBBFBF064", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C157 RID: 49495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C157")]
		[Address(RVA = "0x17BF498", Offset = "0x17BF498", VA = "0x7BBBFBF498")]
		public UIHudObserverProfileView()
		{
		}

		// Token: 0x0400D9F6 RID: 55798
		[Token(Token = "0x400D9F6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject normalContainer;

		// Token: 0x0400D9F7 RID: 55799
		[Token(Token = "0x400D9F7")]
		[FieldOffset(Offset = "0x28")]
		public UILabel name;

		// Token: 0x0400D9F8 RID: 55800
		[Token(Token = "0x400D9F8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject profileContainer;

		// Token: 0x0400D9F9 RID: 55801
		[Token(Token = "0x400D9F9")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnReport;

		// Token: 0x0400D9FA RID: 55802
		[Token(Token = "0x400D9FA")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ReportIcon;

		// Token: 0x0400D9FB RID: 55803
		[Token(Token = "0x400D9FB")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnDrop;

		// Token: 0x0400D9FC RID: 55804
		[Token(Token = "0x400D9FC")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnRevive;

		// Token: 0x0400D9FD RID: 55805
		[Token(Token = "0x400D9FD")]
		[FieldOffset(Offset = "0x58")]
		public UICountDownLabel ReviveCountDown;

		// Token: 0x0400D9FE RID: 55806
		[Token(Token = "0x400D9FE")]
		[FieldOffset(Offset = "0x60")]
		public UILabel playerId;

		// Token: 0x0400D9FF RID: 55807
		[Token(Token = "0x400D9FF")]
		[FieldOffset(Offset = "0x68")]
		public Animator Ani_LikeContainer;

		// Token: 0x0400DA00 RID: 55808
		[Token(Token = "0x400DA00")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnLike;

		// Token: 0x0400DA01 RID: 55809
		[Token(Token = "0x400DA01")]
		[FieldOffset(Offset = "0x78")]
		public UISprite LikeIcon;

		// Token: 0x0400DA02 RID: 55810
		[Token(Token = "0x400DA02")]
		[FieldOffset(Offset = "0x80")]
		public UILabel LikeLabel;

		// Token: 0x0400DA03 RID: 55811
		[Token(Token = "0x400DA03")]
		[FieldOffset(Offset = "0x88")]
		public ParticleSystem VFX_Ring;

		// Token: 0x0400DA04 RID: 55812
		[Token(Token = "0x400DA04")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnAdd;

		// Token: 0x0400DA05 RID: 55813
		[Token(Token = "0x400DA05")]
		[FieldOffset(Offset = "0x98")]
		public UISprite AddIcon;
	}
}
