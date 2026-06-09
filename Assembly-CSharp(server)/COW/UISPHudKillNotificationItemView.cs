using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002516 RID: 9494
	[Token(Token = "0x2002516")]
	internal class UISPHudKillNotificationItemView : UIBaseView
	{
		// Token: 0x0600C53C RID: 50492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C53C")]
		[Address(RVA = "0x1EE9128", Offset = "0x1EE9128", VA = "0x7BBC6E9128", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C53D RID: 50493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C53D")]
		[Address(RVA = "0x1EE9600", Offset = "0x1EE9600", VA = "0x7BBC6E9600")]
		public UISPHudKillNotificationItemView()
		{
		}

		// Token: 0x0400F25A RID: 62042
		[Token(Token = "0x400F25A")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UISPHudKillNotificationItem;

		// Token: 0x0400F25B RID: 62043
		[Token(Token = "0x400F25B")]
		[FieldOffset(Offset = "0x28")]
		public TweenAlpha tweenAlpha;

		// Token: 0x0400F25C RID: 62044
		[Token(Token = "0x400F25C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject MoveContainer;

		// Token: 0x0400F25D RID: 62045
		[Token(Token = "0x400F25D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel KillTxt;

		// Token: 0x0400F25E RID: 62046
		[Token(Token = "0x400F25E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject KillContainer;

		// Token: 0x0400F25F RID: 62047
		[Token(Token = "0x400F25F")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget Team1;

		// Token: 0x0400F260 RID: 62048
		[Token(Token = "0x400F260")]
		[FieldOffset(Offset = "0x50")]
		public UIEffectSprite TeamIcon1;

		// Token: 0x0400F261 RID: 62049
		[Token(Token = "0x400F261")]
		[FieldOffset(Offset = "0x58")]
		public UISprite TeamFakeIcon1;

		// Token: 0x0400F262 RID: 62050
		[Token(Token = "0x400F262")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Name1;

		// Token: 0x0400F263 RID: 62051
		[Token(Token = "0x400F263")]
		[FieldOffset(Offset = "0x68")]
		public UIWidget Team2;

		// Token: 0x0400F264 RID: 62052
		[Token(Token = "0x400F264")]
		[FieldOffset(Offset = "0x70")]
		public UIEffectSprite TeamIcon2;

		// Token: 0x0400F265 RID: 62053
		[Token(Token = "0x400F265")]
		[FieldOffset(Offset = "0x78")]
		public UISprite TeamFakeIcon2;

		// Token: 0x0400F266 RID: 62054
		[Token(Token = "0x400F266")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Name2;

		// Token: 0x0400F267 RID: 62055
		[Token(Token = "0x400F267")]
		[FieldOffset(Offset = "0x88")]
		public UILabel PureName1;

		// Token: 0x0400F268 RID: 62056
		[Token(Token = "0x400F268")]
		[FieldOffset(Offset = "0x90")]
		public UILabel PureName2;

		// Token: 0x0400F269 RID: 62057
		[Token(Token = "0x400F269")]
		[FieldOffset(Offset = "0x98")]
		public UISprite HeadShot;

		// Token: 0x0400F26A RID: 62058
		[Token(Token = "0x400F26A")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite KnockDown;

		// Token: 0x0400F26B RID: 62059
		[Token(Token = "0x400F26B")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite Weapon;

		// Token: 0x0400F26C RID: 62060
		[Token(Token = "0x400F26C")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite BG;
	}
}
