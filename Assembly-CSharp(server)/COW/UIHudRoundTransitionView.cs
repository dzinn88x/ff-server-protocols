using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200235A RID: 9050
	[Token(Token = "0x200235A")]
	public class UIHudRoundTransitionView : UIBaseView
	{
		// Token: 0x0600C1C4 RID: 49604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C4")]
		[Address(RVA = "0x1663440", Offset = "0x1663440", VA = "0x7BBBE63440", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1C5 RID: 49605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C5")]
		[Address(RVA = "0x1663B98", Offset = "0x1663B98", VA = "0x7BBBE63B98")]
		public UIHudRoundTransitionView()
		{
		}

		// Token: 0x0400DB32 RID: 56114
		[Token(Token = "0x400DB32")]
		[FieldOffset(Offset = "0x20")]
		public Animator Animator;

		// Token: 0x0400DB33 RID: 56115
		[Token(Token = "0x400DB33")]
		[FieldOffset(Offset = "0x28")]
		public GameObject roundResultDetailsContainer;

		// Token: 0x0400DB34 RID: 56116
		[Token(Token = "0x400DB34")]
		[FieldOffset(Offset = "0x30")]
		public UILabel coins;

		// Token: 0x0400DB35 RID: 56117
		[Token(Token = "0x400DB35")]
		[FieldOffset(Offset = "0x38")]
		public UILabel coinValue;

		// Token: 0x0400DB36 RID: 56118
		[Token(Token = "0x400DB36")]
		[FieldOffset(Offset = "0x40")]
		public UILabel roundInfo;

		// Token: 0x0400DB37 RID: 56119
		[Token(Token = "0x400DB37")]
		[FieldOffset(Offset = "0x48")]
		public GameObject winSprite;

		// Token: 0x0400DB38 RID: 56120
		[Token(Token = "0x400DB38")]
		[FieldOffset(Offset = "0x50")]
		public GameObject loseSprite;

		// Token: 0x0400DB39 RID: 56121
		[Token(Token = "0x400DB39")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid bonusGrid;

		// Token: 0x0400DB3A RID: 56122
		[Token(Token = "0x400DB3A")]
		[FieldOffset(Offset = "0x60")]
		public GameObject bonusItem;

		// Token: 0x0400DB3B RID: 56123
		[Token(Token = "0x400DB3B")]
		[FieldOffset(Offset = "0x68")]
		public GameObject mvpPlayer;

		// Token: 0x0400DB3C RID: 56124
		[Token(Token = "0x400DB3C")]
		[FieldOffset(Offset = "0x70")]
		public UILabel MVPPlayerName;

		// Token: 0x0400DB3D RID: 56125
		[Token(Token = "0x400DB3D")]
		[FieldOffset(Offset = "0x78")]
		public GameObject nextRoundContainer;

		// Token: 0x0400DB3E RID: 56126
		[Token(Token = "0x400DB3E")]
		[FieldOffset(Offset = "0x80")]
		public UILabel roundNum;

		// Token: 0x0400DB3F RID: 56127
		[Token(Token = "0x400DB3F")]
		[FieldOffset(Offset = "0x88")]
		public UILabel gamezoneName;

		// Token: 0x0400DB40 RID: 56128
		[Token(Token = "0x400DB40")]
		[FieldOffset(Offset = "0x90")]
		public UILabel matchpoint;

		// Token: 0x0400DB41 RID: 56129
		[Token(Token = "0x400DB41")]
		[FieldOffset(Offset = "0x98")]
		public UISprite myFactionIcon;

		// Token: 0x0400DB42 RID: 56130
		[Token(Token = "0x400DB42")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel myTeamName;

		// Token: 0x0400DB43 RID: 56131
		[Token(Token = "0x400DB43")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject myScores;

		// Token: 0x0400DB44 RID: 56132
		[Token(Token = "0x400DB44")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel myScoreCurrent;

		// Token: 0x0400DB45 RID: 56133
		[Token(Token = "0x400DB45")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel myScorePrevious;

		// Token: 0x0400DB46 RID: 56134
		[Token(Token = "0x400DB46")]
		[FieldOffset(Offset = "0xC0")]
		public TweenAlpha myTweenAlpha;

		// Token: 0x0400DB47 RID: 56135
		[Token(Token = "0x400DB47")]
		[FieldOffset(Offset = "0xC8")]
		public TweenPosition myTweenPos;

		// Token: 0x0400DB48 RID: 56136
		[Token(Token = "0x400DB48")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject myVFX;

		// Token: 0x0400DB49 RID: 56137
		[Token(Token = "0x400DB49")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite oppoFactionIcon;

		// Token: 0x0400DB4A RID: 56138
		[Token(Token = "0x400DB4A")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel oppoTeamName;

		// Token: 0x0400DB4B RID: 56139
		[Token(Token = "0x400DB4B")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject oppScores;

		// Token: 0x0400DB4C RID: 56140
		[Token(Token = "0x400DB4C")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel oppoScoreCurrent;

		// Token: 0x0400DB4D RID: 56141
		[Token(Token = "0x400DB4D")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel oppoScorePrevious;

		// Token: 0x0400DB4E RID: 56142
		[Token(Token = "0x400DB4E")]
		[FieldOffset(Offset = "0x100")]
		public TweenAlpha oppoTweenAlpha;

		// Token: 0x0400DB4F RID: 56143
		[Token(Token = "0x400DB4F")]
		[FieldOffset(Offset = "0x108")]
		public TweenPosition oppoTweenPos;

		// Token: 0x0400DB50 RID: 56144
		[Token(Token = "0x400DB50")]
		[FieldOffset(Offset = "0x110")]
		public GameObject oppoVFX;
	}
}
