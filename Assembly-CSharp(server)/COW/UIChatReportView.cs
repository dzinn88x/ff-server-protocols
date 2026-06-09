using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002152 RID: 8530
	[Token(Token = "0x2002152")]
	public class UIChatReportView : UIBaseView
	{
		// Token: 0x0600BDB4 RID: 48564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB4")]
		[Address(RVA = "0x1BE9A08", Offset = "0x1BE9A08", VA = "0x7BBC3E9A08", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDB5 RID: 48565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB5")]
		[Address(RVA = "0x1BE9DC0", Offset = "0x1BE9DC0", VA = "0x7BBC3E9DC0")]
		public UIChatReportView()
		{
		}

		// Token: 0x0400C4E0 RID: 50400
		[Token(Token = "0x400C4E0")]
		[FieldOffset(Offset = "0x20")]
		public UICenterTargetHelper ProfileCenterPoint;

		// Token: 0x0400C4E1 RID: 50401
		[Token(Token = "0x400C4E1")]
		[FieldOffset(Offset = "0x28")]
		public UISprite HeadIcon;

		// Token: 0x0400C4E2 RID: 50402
		[Token(Token = "0x400C4E2")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Name;

		// Token: 0x0400C4E3 RID: 50403
		[Token(Token = "0x400C4E3")]
		[FieldOffset(Offset = "0x38")]
		public UILabel PlayerID;

		// Token: 0x0400C4E4 RID: 50404
		[Token(Token = "0x400C4E4")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButtonGroup ReportReason;

		// Token: 0x0400C4E5 RID: 50405
		[Token(Token = "0x400C4E5")]
		[FieldOffset(Offset = "0x48")]
		public UIToggleButton Racial;

		// Token: 0x0400C4E6 RID: 50406
		[Token(Token = "0x400C4E6")]
		[FieldOffset(Offset = "0x50")]
		public UIToggleButton Policy;

		// Token: 0x0400C4E7 RID: 50407
		[Token(Token = "0x400C4E7")]
		[FieldOffset(Offset = "0x58")]
		public UIToggleButton Cheat;

		// Token: 0x0400C4E8 RID: 50408
		[Token(Token = "0x400C4E8")]
		[FieldOffset(Offset = "0x60")]
		public UIToggleButton AD;

		// Token: 0x0400C4E9 RID: 50409
		[Token(Token = "0x400C4E9")]
		[FieldOffset(Offset = "0x68")]
		public UIToggleButton Other;

		// Token: 0x0400C4EA RID: 50410
		[Token(Token = "0x400C4EA")]
		[FieldOffset(Offset = "0x70")]
		public UILabel ReportedChat;

		// Token: 0x0400C4EB RID: 50411
		[Token(Token = "0x400C4EB")]
		[FieldOffset(Offset = "0x78")]
		public UIButton CancelBtn;

		// Token: 0x0400C4EC RID: 50412
		[Token(Token = "0x400C4EC")]
		[FieldOffset(Offset = "0x80")]
		public UIButton ReportBtn;

		// Token: 0x0400C4ED RID: 50413
		[Token(Token = "0x400C4ED")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ReportDisable;
	}
}
