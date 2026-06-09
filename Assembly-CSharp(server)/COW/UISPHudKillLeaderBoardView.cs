using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002515 RID: 9493
	[Token(Token = "0x2002515")]
	internal class UISPHudKillLeaderBoardView : UIBaseView
	{
		// Token: 0x0600C53A RID: 50490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C53A")]
		[Address(RVA = "0x1EE8F10", Offset = "0x1EE8F10", VA = "0x7BBC6E8F10", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C53B RID: 50491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C53B")]
		[Address(RVA = "0x1EE9120", Offset = "0x1EE9120", VA = "0x7BBC6E9120")]
		public UISPHudKillLeaderBoardView()
		{
		}

		// Token: 0x0400F253 RID: 62035
		[Token(Token = "0x400F253")]
		[FieldOffset(Offset = "0x20")]
		public GameObject InfoPanel;

		// Token: 0x0400F254 RID: 62036
		[Token(Token = "0x400F254")]
		[FieldOffset(Offset = "0x28")]
		public TweenPosition TweenPosition;

		// Token: 0x0400F255 RID: 62037
		[Token(Token = "0x400F255")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Title;

		// Token: 0x0400F256 RID: 62038
		[Token(Token = "0x400F256")]
		[FieldOffset(Offset = "0x38")]
		public UISprite TeamIcon;

		// Token: 0x0400F257 RID: 62039
		[Token(Token = "0x400F257")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TeamFakeIcon;

		// Token: 0x0400F258 RID: 62040
		[Token(Token = "0x400F258")]
		[FieldOffset(Offset = "0x48")]
		public UILabel KillCount;

		// Token: 0x0400F259 RID: 62041
		[Token(Token = "0x400F259")]
		[FieldOffset(Offset = "0x50")]
		public UILabel KillLabel;
	}
}
