using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002389 RID: 9097
	[Token(Token = "0x2002389")]
	public class UIHudTrainingTokenView : UIBaseView
	{
		// Token: 0x0600C222 RID: 49698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C222")]
		[Address(RVA = "0x15E8C6C", Offset = "0x15E8C6C", VA = "0x7BBBDE8C6C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C223 RID: 49699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C223")]
		[Address(RVA = "0x15E8E08", Offset = "0x15E8E08", VA = "0x7BBBDE8E08")]
		public UIHudTrainingTokenView()
		{
		}

		// Token: 0x0400DCEF RID: 56559
		[Token(Token = "0x400DCEF")]
		[FieldOffset(Offset = "0x20")]
		public UISprite UIHudTrainingToken;

		// Token: 0x0400DCF0 RID: 56560
		[Token(Token = "0x400DCF0")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Btn;

		// Token: 0x0400DCF1 RID: 56561
		[Token(Token = "0x400DCF1")]
		[FieldOffset(Offset = "0x30")]
		public UILabel DescLabel;

		// Token: 0x0400DCF2 RID: 56562
		[Token(Token = "0x400DCF2")]
		[FieldOffset(Offset = "0x38")]
		public UILabel CntLabel;

		// Token: 0x0400DCF3 RID: 56563
		[Token(Token = "0x400DCF3")]
		[FieldOffset(Offset = "0x40")]
		public UILabel CntAddLabel;
	}
}
