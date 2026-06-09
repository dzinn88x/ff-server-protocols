using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002387 RID: 9095
	[Token(Token = "0x2002387")]
	public class UIHudTrainingEsportInfoView : UIBaseView
	{
		// Token: 0x0600C21E RID: 49694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C21E")]
		[Address(RVA = "0x15E8034", Offset = "0x15E8034", VA = "0x7BBBDE8034", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C21F RID: 49695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C21F")]
		[Address(RVA = "0x15E8234", Offset = "0x15E8234", VA = "0x7BBBDE8234")]
		public UIHudTrainingEsportInfoView()
		{
		}

		// Token: 0x0400DCBE RID: 56510
		[Token(Token = "0x400DCBE")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CloseBtn;

		// Token: 0x0400DCBF RID: 56511
		[Token(Token = "0x400DCBF")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TitleLabel;

		// Token: 0x0400DCC0 RID: 56512
		[Token(Token = "0x400DCC0")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TitleLabel2;

		// Token: 0x0400DCC1 RID: 56513
		[Token(Token = "0x400DCC1")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ClanLabel;

		// Token: 0x0400DCC2 RID: 56514
		[Token(Token = "0x400DCC2")]
		[FieldOffset(Offset = "0x40")]
		public UILabel DescLabel;

		// Token: 0x0400DCC3 RID: 56515
		[Token(Token = "0x400DCC3")]
		[FieldOffset(Offset = "0x48")]
		public UITexture TeamPic;

		// Token: 0x0400DCC4 RID: 56516
		[Token(Token = "0x400DCC4")]
		[FieldOffset(Offset = "0x50")]
		public UISprite TeamLogo;
	}
}
