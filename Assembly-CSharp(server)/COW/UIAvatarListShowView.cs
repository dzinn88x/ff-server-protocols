using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002101 RID: 8449
	[Token(Token = "0x2002101")]
	public class UIAvatarListShowView : UIBaseView
	{
		// Token: 0x0600BD13 RID: 48403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD13")]
		[Address(RVA = "0x207A5BC", Offset = "0x207A5BC", VA = "0x7BBC87A5BC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD14 RID: 48404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD14")]
		[Address(RVA = "0x207AAF8", Offset = "0x207AAF8", VA = "0x7BBC87AAF8")]
		public UIAvatarListShowView()
		{
		}

		// Token: 0x0400C050 RID: 49232
		[Token(Token = "0x400C050")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition AvatarTweenPos;

		// Token: 0x0400C051 RID: 49233
		[Token(Token = "0x400C051")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ClostBtn;

		// Token: 0x0400C052 RID: 49234
		[Token(Token = "0x400C052")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Icon01;

		// Token: 0x0400C053 RID: 49235
		[Token(Token = "0x400C053")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Icon02;

		// Token: 0x0400C054 RID: 49236
		[Token(Token = "0x400C054")]
		[FieldOffset(Offset = "0x40")]
		public GameObject LevelTips;

		// Token: 0x0400C055 RID: 49237
		[Token(Token = "0x400C055")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget AvatarWidget;

		// Token: 0x0400C056 RID: 49238
		[Token(Token = "0x400C056")]
		[FieldOffset(Offset = "0x50")]
		public UIScrollView AvatarScrollView;

		// Token: 0x0400C057 RID: 49239
		[Token(Token = "0x400C057")]
		[FieldOffset(Offset = "0x58")]
		public UIEasyList Grid;

		// Token: 0x0400C058 RID: 49240
		[Token(Token = "0x400C058")]
		[FieldOffset(Offset = "0x60")]
		public UILabel AvatarNameChoose;

		// Token: 0x0400C059 RID: 49241
		[Token(Token = "0x400C059")]
		[FieldOffset(Offset = "0x68")]
		public Transform CurrentChooseBtnTr;

		// Token: 0x0400C05A RID: 49242
		[Token(Token = "0x400C05A")]
		[FieldOffset(Offset = "0x70")]
		public GameObject AwakenAvatarExchangeContainer;

		// Token: 0x0400C05B RID: 49243
		[Token(Token = "0x400C05B")]
		[FieldOffset(Offset = "0x78")]
		public UIButton ExchangeToOriAvatarBtn;

		// Token: 0x0400C05C RID: 49244
		[Token(Token = "0x400C05C")]
		[FieldOffset(Offset = "0x80")]
		public UIAvatarAwakenSwitchItemView AvatarOriItem;

		// Token: 0x0400C05D RID: 49245
		[Token(Token = "0x400C05D")]
		[FieldOffset(Offset = "0x88")]
		public UIButton ExchangeToAwakenAvatarBtn;

		// Token: 0x0400C05E RID: 49246
		[Token(Token = "0x400C05E")]
		[FieldOffset(Offset = "0x90")]
		public UIAvatarAwakenSwitchItemView AvatarAwakenItem;

		// Token: 0x0400C05F RID: 49247
		[Token(Token = "0x400C05F")]
		[FieldOffset(Offset = "0x98")]
		public UIButton AwakenEntranceBtn;

		// Token: 0x0400C060 RID: 49248
		[Token(Token = "0x400C060")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel UIAwakenBtnLabel;

		// Token: 0x0400C061 RID: 49249
		[Token(Token = "0x400C061")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject btnLabelVFX;

		// Token: 0x0400C062 RID: 49250
		[Token(Token = "0x400C062")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject btnIconVFX;

		// Token: 0x0400C063 RID: 49251
		[Token(Token = "0x400C063")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject AwakenEntranceTips;
	}
}
