using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002151 RID: 8529
	[Token(Token = "0x2002151")]
	public class UIChatRecruitItemView : UIBaseView
	{
		// Token: 0x0600BDB2 RID: 48562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB2")]
		[Address(RVA = "0x1BE8B28", Offset = "0x1BE8B28", VA = "0x7BBC3E8B28", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDB3 RID: 48563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB3")]
		[Address(RVA = "0x1BE8E00", Offset = "0x1BE8E00", VA = "0x7BBC3E8E00")]
		public UIChatRecruitItemView()
		{
		}

		// Token: 0x0400C4D6 RID: 50390
		[Token(Token = "0x400C4D6")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BG;

		// Token: 0x0400C4D7 RID: 50391
		[Token(Token = "0x400C4D7")]
		[FieldOffset(Offset = "0x28")]
		public Transform ProfileContainer;

		// Token: 0x0400C4D8 RID: 50392
		[Token(Token = "0x400C4D8")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Mode;

		// Token: 0x0400C4D9 RID: 50393
		[Token(Token = "0x400C4D9")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Map;

		// Token: 0x0400C4DA RID: 50394
		[Token(Token = "0x400C4DA")]
		[FieldOffset(Offset = "0x40")]
		public UILabel GroupMode;

		// Token: 0x0400C4DB RID: 50395
		[Token(Token = "0x400C4DB")]
		[FieldOffset(Offset = "0x48")]
		public UISprite LadderIcon;

		// Token: 0x0400C4DC RID: 50396
		[Token(Token = "0x400C4DC")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Tag1;

		// Token: 0x0400C4DD RID: 50397
		[Token(Token = "0x400C4DD")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Tag2;

		// Token: 0x0400C4DE RID: 50398
		[Token(Token = "0x400C4DE")]
		[FieldOffset(Offset = "0x60")]
		public UIButton JoinGroupBtn;

		// Token: 0x0400C4DF RID: 50399
		[Token(Token = "0x400C4DF")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ClanSourceIcon;
	}
}
