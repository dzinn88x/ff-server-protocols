using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002150 RID: 8528
	[Token(Token = "0x2002150")]
	public class UIChatRecruitContainerView : UIBaseView
	{
		// Token: 0x0600BDB0 RID: 48560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB0")]
		[Address(RVA = "0x1BE7A34", Offset = "0x1BE7A34", VA = "0x7BBC3E7A34", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDB1 RID: 48561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB1")]
		[Address(RVA = "0x1BE7E14", Offset = "0x1BE7E14", VA = "0x7BBC3E7E14")]
		public UIChatRecruitContainerView()
		{
		}

		// Token: 0x0400C4C7 RID: 50375
		[Token(Token = "0x400C4C7")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Widget;

		// Token: 0x0400C4C8 RID: 50376
		[Token(Token = "0x400C4C8")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ContentNode;

		// Token: 0x0400C4C9 RID: 50377
		[Token(Token = "0x400C4C9")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView MessageList;

		// Token: 0x0400C4CA RID: 50378
		[Token(Token = "0x400C4CA")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList MessageEasyList;

		// Token: 0x0400C4CB RID: 50379
		[Token(Token = "0x400C4CB")]
		[FieldOffset(Offset = "0x40")]
		public GameObject EmptyNode;

		// Token: 0x0400C4CC RID: 50380
		[Token(Token = "0x400C4CC")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NoMessageHint;

		// Token: 0x0400C4CD RID: 50381
		[Token(Token = "0x400C4CD")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NoGroupNode;

		// Token: 0x0400C4CE RID: 50382
		[Token(Token = "0x400C4CE")]
		[FieldOffset(Offset = "0x58")]
		public UIButton RecruitBtnNoGroup;

		// Token: 0x0400C4CF RID: 50383
		[Token(Token = "0x400C4CF")]
		[FieldOffset(Offset = "0x60")]
		public GameObject InGroupNode;

		// Token: 0x0400C4D0 RID: 50384
		[Token(Token = "0x400C4D0")]
		[FieldOffset(Offset = "0x68")]
		public UIButton RecruitBtnInGroup;

		// Token: 0x0400C4D1 RID: 50385
		[Token(Token = "0x400C4D1")]
		[FieldOffset(Offset = "0x70")]
		public UISprite GroupModeIcon;

		// Token: 0x0400C4D2 RID: 50386
		[Token(Token = "0x400C4D2")]
		[FieldOffset(Offset = "0x78")]
		public UILabel GameMode;

		// Token: 0x0400C4D3 RID: 50387
		[Token(Token = "0x400C4D3")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Map;

		// Token: 0x0400C4D4 RID: 50388
		[Token(Token = "0x400C4D4")]
		[FieldOffset(Offset = "0x88")]
		public UISprite LadderIcon;

		// Token: 0x0400C4D5 RID: 50389
		[Token(Token = "0x400C4D5")]
		[FieldOffset(Offset = "0x90")]
		public UIButton LeaveGroupBtn;
	}
}
