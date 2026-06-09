using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024E0 RID: 9440
	[Token(Token = "0x20024E0")]
	public class UIRoomListItemView : UIBaseView
	{
		// Token: 0x0600C4D0 RID: 50384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4D0")]
		[Address(RVA = "0x1A1A8F8", Offset = "0x1A1A8F8", VA = "0x7BBC21A8F8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4D1 RID: 50385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4D1")]
		[Address(RVA = "0x1A1AD80", Offset = "0x1A1AD80", VA = "0x7BBC21AD80")]
		public UIRoomListItemView()
		{
		}

		// Token: 0x0400F000 RID: 61440
		[Token(Token = "0x400F000")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400F001 RID: 61441
		[Token(Token = "0x400F001")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Icon;

		// Token: 0x0400F002 RID: 61442
		[Token(Token = "0x400F002")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Players;

		// Token: 0x0400F003 RID: 61443
		[Token(Token = "0x400F003")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Status;

		// Token: 0x0400F004 RID: 61444
		[Token(Token = "0x400F004")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ModeName;

		// Token: 0x0400F005 RID: 61445
		[Token(Token = "0x400F005")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Sole;

		// Token: 0x0400F006 RID: 61446
		[Token(Token = "0x400F006")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Duo;

		// Token: 0x0400F007 RID: 61447
		[Token(Token = "0x400F007")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Quad;

		// Token: 0x0400F008 RID: 61448
		[Token(Token = "0x400F008")]
		[FieldOffset(Offset = "0x60")]
		public UISprite LanguageSprite;

		// Token: 0x0400F009 RID: 61449
		[Token(Token = "0x400F009")]
		[FieldOffset(Offset = "0x68")]
		public UISprite Map;

		// Token: 0x0400F00A RID: 61450
		[Token(Token = "0x400F00A")]
		[FieldOffset(Offset = "0x70")]
		public UITable Flags;

		// Token: 0x0400F00B RID: 61451
		[Token(Token = "0x400F00B")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Lock;

		// Token: 0x0400F00C RID: 61452
		[Token(Token = "0x400F00C")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Emulator;

		// Token: 0x0400F00D RID: 61453
		[Token(Token = "0x400F00D")]
		[FieldOffset(Offset = "0x88")]
		public UILabel ID;

		// Token: 0x0400F00E RID: 61454
		[Token(Token = "0x400F00E")]
		[FieldOffset(Offset = "0x90")]
		public UILabel Name;

		// Token: 0x0400F00F RID: 61455
		[Token(Token = "0x400F00F")]
		[FieldOffset(Offset = "0x98")]
		public GameObject Effect_Glow;

		// Token: 0x0400F010 RID: 61456
		[Token(Token = "0x400F010")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite WeatherSprite;

		// Token: 0x0400F011 RID: 61457
		[Token(Token = "0x400F011")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel MapName;
	}
}
