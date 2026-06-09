using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002194 RID: 8596
	[Token(Token = "0x2002194")]
	public class UIDailyFirstWinView : UIBaseView
	{
		// Token: 0x0600BE38 RID: 48696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE38")]
		[Address(RVA = "0x1BAD7E8", Offset = "0x1BAD7E8", VA = "0x7BBC3AD7E8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE39 RID: 48697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE39")]
		[Address(RVA = "0x1BAD9D0", Offset = "0x1BAD9D0", VA = "0x7BBC3AD9D0")]
		public UIDailyFirstWinView()
		{
		}

		// Token: 0x0400C894 RID: 51348
		[Token(Token = "0x400C894")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnDone;

		// Token: 0x0400C895 RID: 51349
		[Token(Token = "0x400C895")]
		[FieldOffset(Offset = "0x28")]
		public GameObject DoingContainer;

		// Token: 0x0400C896 RID: 51350
		[Token(Token = "0x400C896")]
		[FieldOffset(Offset = "0x30")]
		public UILabel DoingLabel;

		// Token: 0x0400C897 RID: 51351
		[Token(Token = "0x400C897")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnDailyTip;

		// Token: 0x0400C898 RID: 51352
		[Token(Token = "0x400C898")]
		[FieldOffset(Offset = "0x40")]
		public GameObject DoneContainer;

		// Token: 0x0400C899 RID: 51353
		[Token(Token = "0x400C899")]
		[FieldOffset(Offset = "0x48")]
		public UILabel DoneLabel;
	}
}
