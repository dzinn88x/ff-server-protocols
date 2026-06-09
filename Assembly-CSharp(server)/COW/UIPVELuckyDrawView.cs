using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024B2 RID: 9394
	[Token(Token = "0x20024B2")]
	internal class UIPVELuckyDrawView : UIBaseView
	{
		// Token: 0x0600C474 RID: 50292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C474")]
		[Address(RVA = "0x16E4AC4", Offset = "0x16E4AC4", VA = "0x7BBBEE4AC4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C475 RID: 50293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C475")]
		[Address(RVA = "0x16E4F5C", Offset = "0x16E4F5C", VA = "0x7BBBEE4F5C")]
		public UIPVELuckyDrawView()
		{
		}

		// Token: 0x0400EEAC RID: 61100
		[Token(Token = "0x400EEAC")]
		[FieldOffset(Offset = "0x20")]
		public GameObject MaskBG;

		// Token: 0x0400EEAD RID: 61101
		[Token(Token = "0x400EEAD")]
		[FieldOffset(Offset = "0x28")]
		public Animator ItemsRoot;

		// Token: 0x0400EEAE RID: 61102
		[Token(Token = "0x400EEAE")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Item0;

		// Token: 0x0400EEAF RID: 61103
		[Token(Token = "0x400EEAF")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Item1;

		// Token: 0x0400EEB0 RID: 61104
		[Token(Token = "0x400EEB0")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Item2;

		// Token: 0x0400EEB1 RID: 61105
		[Token(Token = "0x400EEB1")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Item3;

		// Token: 0x0400EEB2 RID: 61106
		[Token(Token = "0x400EEB2")]
		[FieldOffset(Offset = "0x50")]
		public GameObject RankSSS;

		// Token: 0x0400EEB3 RID: 61107
		[Token(Token = "0x400EEB3")]
		[FieldOffset(Offset = "0x58")]
		public GameObject RankS;

		// Token: 0x0400EEB4 RID: 61108
		[Token(Token = "0x400EEB4")]
		[FieldOffset(Offset = "0x60")]
		public GameObject RankA;

		// Token: 0x0400EEB5 RID: 61109
		[Token(Token = "0x400EEB5")]
		[FieldOffset(Offset = "0x68")]
		public GameObject RankB;

		// Token: 0x0400EEB6 RID: 61110
		[Token(Token = "0x400EEB6")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnDetail;

		// Token: 0x0400EEB7 RID: 61111
		[Token(Token = "0x400EEB7")]
		[FieldOffset(Offset = "0x78")]
		public GameObject OpenAllObj;

		// Token: 0x0400EEB8 RID: 61112
		[Token(Token = "0x400EEB8")]
		[FieldOffset(Offset = "0x80")]
		public UIButton PurchaseBtn;

		// Token: 0x0400EEB9 RID: 61113
		[Token(Token = "0x400EEB9")]
		[FieldOffset(Offset = "0x88")]
		public GameObject FreeBG;

		// Token: 0x0400EEBA RID: 61114
		[Token(Token = "0x400EEBA")]
		[FieldOffset(Offset = "0x90")]
		public GameObject CostBG;

		// Token: 0x0400EEBB RID: 61115
		[Token(Token = "0x400EEBB")]
		[FieldOffset(Offset = "0x98")]
		public UILabel DiamondCount;

		// Token: 0x0400EEBC RID: 61116
		[Token(Token = "0x400EEBC")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel LuckyTodayLabel;

		// Token: 0x0400EEBD RID: 61117
		[Token(Token = "0x400EEBD")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton CloseBtn;
	}
}
