using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200240F RID: 9231
	[Token(Token = "0x200240F")]
	public class UIMailView : UIBaseView
	{
		// Token: 0x0600C32E RID: 49966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C32E")]
		[Address(RVA = "0x1CE5864", Offset = "0x1CE5864", VA = "0x7BBC4E5864", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C32F RID: 49967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C32F")]
		[Address(RVA = "0x1CE5EBC", Offset = "0x1CE5EBC", VA = "0x7BBC4E5EBC")]
		public UIMailView()
		{
		}

		// Token: 0x0400E3C7 RID: 58311
		[Token(Token = "0x400E3C7")]
		[FieldOffset(Offset = "0x20")]
		public UILabel CountLabel;

		// Token: 0x0400E3C8 RID: 58312
		[Token(Token = "0x400E3C8")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView MailScrollView;

		// Token: 0x0400E3C9 RID: 58313
		[Token(Token = "0x400E3C9")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList MailList;

		// Token: 0x0400E3CA RID: 58314
		[Token(Token = "0x400E3CA")]
		[FieldOffset(Offset = "0x38")]
		public GameObject NoMail;

		// Token: 0x0400E3CB RID: 58315
		[Token(Token = "0x400E3CB")]
		[FieldOffset(Offset = "0x40")]
		public Transform RightContainer;

		// Token: 0x0400E3CC RID: 58316
		[Token(Token = "0x400E3CC")]
		[FieldOffset(Offset = "0x48")]
		public UIScrollView ContentScrollView;

		// Token: 0x0400E3CD RID: 58317
		[Token(Token = "0x400E3CD")]
		[FieldOffset(Offset = "0x50")]
		public UIPanel PanelMailContent;

		// Token: 0x0400E3CE RID: 58318
		[Token(Token = "0x400E3CE")]
		[FieldOffset(Offset = "0x58")]
		public UILabel MailContent;

		// Token: 0x0400E3CF RID: 58319
		[Token(Token = "0x400E3CF")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView GiftContentScrollView;

		// Token: 0x0400E3D0 RID: 58320
		[Token(Token = "0x400E3D0")]
		[FieldOffset(Offset = "0x68")]
		public UILabel GiftMailContent;

		// Token: 0x0400E3D1 RID: 58321
		[Token(Token = "0x400E3D1")]
		[FieldOffset(Offset = "0x70")]
		public UILabel MailMessage;

		// Token: 0x0400E3D2 RID: 58322
		[Token(Token = "0x400E3D2")]
		[FieldOffset(Offset = "0x78")]
		public GameObject GiftDecorate;

		// Token: 0x0400E3D3 RID: 58323
		[Token(Token = "0x400E3D3")]
		[FieldOffset(Offset = "0x80")]
		public GameObject GiftDecorate1;

		// Token: 0x0400E3D4 RID: 58324
		[Token(Token = "0x400E3D4")]
		[FieldOffset(Offset = "0x88")]
		public GameObject GiftDecorate2;

		// Token: 0x0400E3D5 RID: 58325
		[Token(Token = "0x400E3D5")]
		[FieldOffset(Offset = "0x90")]
		public GameObject GiftIcon;

		// Token: 0x0400E3D6 RID: 58326
		[Token(Token = "0x400E3D6")]
		[FieldOffset(Offset = "0x98")]
		public GameObject RewardContainer;

		// Token: 0x0400E3D7 RID: 58327
		[Token(Token = "0x400E3D7")]
		[FieldOffset(Offset = "0xA0")]
		public UIScrollView RewardScrollView;

		// Token: 0x0400E3D8 RID: 58328
		[Token(Token = "0x400E3D8")]
		[FieldOffset(Offset = "0xA8")]
		public UIGrid RewardGrid;

		// Token: 0x0400E3D9 RID: 58329
		[Token(Token = "0x400E3D9")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel MailTitle;

		// Token: 0x0400E3DA RID: 58330
		[Token(Token = "0x400E3DA")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton ReceiveAllBtn;

		// Token: 0x0400E3DB RID: 58331
		[Token(Token = "0x400E3DB")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton DeleteAllBtn;

		// Token: 0x0400E3DC RID: 58332
		[Token(Token = "0x400E3DC")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton ReceiveBtn;

		// Token: 0x0400E3DD RID: 58333
		[Token(Token = "0x400E3DD")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton DeleteBtn;

		// Token: 0x0400E3DE RID: 58334
		[Token(Token = "0x400E3DE")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton OpenBtn;

		// Token: 0x0400E3DF RID: 58335
		[Token(Token = "0x400E3DF")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton AcceptBtn;

		// Token: 0x0400E3E0 RID: 58336
		[Token(Token = "0x400E3E0")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton RejectBtn;
	}
}
