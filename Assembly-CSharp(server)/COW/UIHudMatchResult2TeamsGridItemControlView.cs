using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002309 RID: 8969
	[Token(Token = "0x2002309")]
	public class UIHudMatchResult2TeamsGridItemControlView : UIBaseView
	{
		// Token: 0x0600C122 RID: 49442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C122")]
		[Address(RVA = "0x15C383C", Offset = "0x15C383C", VA = "0x7BBBDC383C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C123 RID: 49443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C123")]
		[Address(RVA = "0x15C3BA8", Offset = "0x15C3BA8", VA = "0x7BBBDC3BA8")]
		public UIHudMatchResult2TeamsGridItemControlView()
		{
		}

		// Token: 0x0400D88C RID: 55436
		[Token(Token = "0x400D88C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Self;

		// Token: 0x0400D88D RID: 55437
		[Token(Token = "0x400D88D")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SimpleProfileInfo;

		// Token: 0x0400D88E RID: 55438
		[Token(Token = "0x400D88E")]
		[FieldOffset(Offset = "0x30")]
		public UISprite HeadIcon;

		// Token: 0x0400D88F RID: 55439
		[Token(Token = "0x400D88F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject infoContainer;

		// Token: 0x0400D890 RID: 55440
		[Token(Token = "0x400D890")]
		[FieldOffset(Offset = "0x40")]
		public UILabel nickname;

		// Token: 0x0400D891 RID: 55441
		[Token(Token = "0x400D891")]
		[FieldOffset(Offset = "0x48")]
		public UILabel clanName;

		// Token: 0x0400D892 RID: 55442
		[Token(Token = "0x400D892")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Kill;

		// Token: 0x0400D893 RID: 55443
		[Token(Token = "0x400D893")]
		[FieldOffset(Offset = "0x58")]
		public UILabel OnZoneTime;

		// Token: 0x0400D894 RID: 55444
		[Token(Token = "0x400D894")]
		[FieldOffset(Offset = "0x60")]
		public UILabel BuffCount;

		// Token: 0x0400D895 RID: 55445
		[Token(Token = "0x400D895")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Score;

		// Token: 0x0400D896 RID: 55446
		[Token(Token = "0x400D896")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Evaluation;

		// Token: 0x0400D897 RID: 55447
		[Token(Token = "0x400D897")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Mvp;

		// Token: 0x0400D898 RID: 55448
		[Token(Token = "0x400D898")]
		[FieldOffset(Offset = "0x80")]
		public UIButton AddFriendBtn;
	}
}
