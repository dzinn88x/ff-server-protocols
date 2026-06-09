using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024AE RID: 9390
	[Token(Token = "0x20024AE")]
	public class UIProfileTagView : UIBaseView
	{
		// Token: 0x0600C46C RID: 50284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C46C")]
		[Address(RVA = "0x1FF16D8", Offset = "0x1FF16D8", VA = "0x7BBC7F16D8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C46D RID: 50285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C46D")]
		[Address(RVA = "0x1FF18E0", Offset = "0x1FF18E0", VA = "0x7BBC7F18E0")]
		public UIProfileTagView()
		{
		}

		// Token: 0x0400EDA7 RID: 60839
		[Token(Token = "0x400EDA7")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIProfileTag;

		// Token: 0x0400EDA8 RID: 60840
		[Token(Token = "0x400EDA8")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Tag;

		// Token: 0x0400EDA9 RID: 60841
		[Token(Token = "0x400EDA9")]
		[FieldOffset(Offset = "0x30")]
		public UISprite LevelBg;

		// Token: 0x0400EDAA RID: 60842
		[Token(Token = "0x400EDAA")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Lock;

		// Token: 0x0400EDAB RID: 60843
		[Token(Token = "0x400EDAB")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Selected;

		// Token: 0x0400EDAC RID: 60844
		[Token(Token = "0x400EDAC")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ConditionNum;

		// Token: 0x0400EDAD RID: 60845
		[Token(Token = "0x400EDAD")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Equiped;
	}
}
