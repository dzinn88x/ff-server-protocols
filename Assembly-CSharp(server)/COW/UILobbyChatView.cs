using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023F5 RID: 9205
	[Token(Token = "0x20023F5")]
	public class UILobbyChatView : UIBaseView
	{
		// Token: 0x0600C2FA RID: 49914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2FA")]
		[Address(RVA = "0x152C344", Offset = "0x152C344", VA = "0x7BBBD2C344", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2FB RID: 49915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2FB")]
		[Address(RVA = "0x152C524", Offset = "0x152C524", VA = "0x7BBBD2C524")]
		public UILobbyChatView()
		{
		}

		// Token: 0x0400E15E RID: 57694
		[Token(Token = "0x400E15E")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ChatBtn;

		// Token: 0x0400E15F RID: 57695
		[Token(Token = "0x400E15F")]
		[FieldOffset(Offset = "0x28")]
		public UIButton RecruitBtn;

		// Token: 0x0400E160 RID: 57696
		[Token(Token = "0x400E160")]
		[FieldOffset(Offset = "0x30")]
		public UIButton FastSendGiftBtn;

		// Token: 0x0400E161 RID: 57697
		[Token(Token = "0x400E161")]
		[FieldOffset(Offset = "0x38")]
		public GameObject LatestMessage;

		// Token: 0x0400E162 RID: 57698
		[Token(Token = "0x400E162")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LatestMessageLabel;

		// Token: 0x0400E163 RID: 57699
		[Token(Token = "0x400E163")]
		[FieldOffset(Offset = "0x48")]
		public UIButton ChatMessageBtn;
	}
}
