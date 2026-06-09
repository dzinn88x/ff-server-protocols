using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200227B RID: 8827
	[Token(Token = "0x200227B")]
	public class UIHudBigHeadResultShowView : UIBaseView
	{
		// Token: 0x0600C007 RID: 49159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C007")]
		[Address(RVA = "0x1895E58", Offset = "0x1895E58", VA = "0x7BBC095E58", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C008 RID: 49160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C008")]
		[Address(RVA = "0x18960D4", Offset = "0x18960D4", VA = "0x7BBC0960D4")]
		public UIHudBigHeadResultShowView()
		{
		}

		// Token: 0x0400D3F5 RID: 54261
		[Token(Token = "0x400D3F5")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Container;

		// Token: 0x0400D3F6 RID: 54262
		[Token(Token = "0x400D3F6")]
		[FieldOffset(Offset = "0x28")]
		public UILabel PlayerRank;

		// Token: 0x0400D3F7 RID: 54263
		[Token(Token = "0x400D3F7")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TotalPlayersCount;

		// Token: 0x0400D3F8 RID: 54264
		[Token(Token = "0x400D3F8")]
		[FieldOffset(Offset = "0x38")]
		public UISprite PlayerRankTop_NO1;

		// Token: 0x0400D3F9 RID: 54265
		[Token(Token = "0x400D3F9")]
		[FieldOffset(Offset = "0x40")]
		public UISprite PlayerRankTop_NO2;

		// Token: 0x0400D3FA RID: 54266
		[Token(Token = "0x400D3FA")]
		[FieldOffset(Offset = "0x48")]
		public UISprite PlayerRankTop_NO3;

		// Token: 0x0400D3FB RID: 54267
		[Token(Token = "0x400D3FB")]
		[FieldOffset(Offset = "0x50")]
		public GameObject PersonalCallSignContainer;

		// Token: 0x0400D3FC RID: 54268
		[Token(Token = "0x400D3FC")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BtnMask;

		// Token: 0x0400D3FD RID: 54269
		[Token(Token = "0x400D3FD")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnShare;
	}
}
