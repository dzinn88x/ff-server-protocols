using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002311 RID: 8977
	[Token(Token = "0x2002311")]
	internal class UIHudMatchResultInfoItemView : UIBaseView
	{
		// Token: 0x0600C132 RID: 49458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C132")]
		[Address(RVA = "0x17A82C8", Offset = "0x17A82C8", VA = "0x7BBBFA82C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C133 RID: 49459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C133")]
		[Address(RVA = "0x17A8844", Offset = "0x17A8844", VA = "0x7BBBFA8844")]
		public UIHudMatchResultInfoItemView()
		{
		}

		// Token: 0x0400D8F2 RID: 55538
		[Token(Token = "0x400D8F2")]
		[FieldOffset(Offset = "0x20")]
		public UIButton AddFriendBtn;

		// Token: 0x0400D8F3 RID: 55539
		[Token(Token = "0x400D8F3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject briefProfile;

		// Token: 0x0400D8F4 RID: 55540
		[Token(Token = "0x400D8F4")]
		[FieldOffset(Offset = "0x30")]
		public UILabel KillCount;

		// Token: 0x0400D8F5 RID: 55541
		[Token(Token = "0x400D8F5")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GoldIcon;

		// Token: 0x0400D8F6 RID: 55542
		[Token(Token = "0x400D8F6")]
		[FieldOffset(Offset = "0x40")]
		public UILabel GoldRewardCount;

		// Token: 0x0400D8F7 RID: 55543
		[Token(Token = "0x400D8F7")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ExpIcon;

		// Token: 0x0400D8F8 RID: 55544
		[Token(Token = "0x400D8F8")]
		[FieldOffset(Offset = "0x50")]
		public UILabel m_ExpCount;

		// Token: 0x0400D8F9 RID: 55545
		[Token(Token = "0x400D8F9")]
		[FieldOffset(Offset = "0x58")]
		public UISprite PetExpIcon;

		// Token: 0x0400D8FA RID: 55546
		[Token(Token = "0x400D8FA")]
		[FieldOffset(Offset = "0x60")]
		public UILabel m_PetExpCount;

		// Token: 0x0400D8FB RID: 55547
		[Token(Token = "0x400D8FB")]
		[FieldOffset(Offset = "0x68")]
		public GameObject CurrentStarsContainer;

		// Token: 0x0400D8FC RID: 55548
		[Token(Token = "0x400D8FC")]
		[FieldOffset(Offset = "0x70")]
		public UILabel CurrentStarsNumber;

		// Token: 0x0400D8FD RID: 55549
		[Token(Token = "0x400D8FD")]
		[FieldOffset(Offset = "0x78")]
		public UISprite ShareGoldBonus;

		// Token: 0x0400D8FE RID: 55550
		[Token(Token = "0x400D8FE")]
		[FieldOffset(Offset = "0x80")]
		public UIButton GoldTipsBtn;

		// Token: 0x0400D8FF RID: 55551
		[Token(Token = "0x400D8FF")]
		[FieldOffset(Offset = "0x88")]
		public UISprite ShareExpBonus;

		// Token: 0x0400D900 RID: 55552
		[Token(Token = "0x400D900")]
		[FieldOffset(Offset = "0x90")]
		public UIButton ExpTipsBtn;

		// Token: 0x0400D901 RID: 55553
		[Token(Token = "0x400D901")]
		[FieldOffset(Offset = "0x98")]
		public UIButton BtnDetail;

		// Token: 0x0400D902 RID: 55554
		[Token(Token = "0x400D902")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel ScoreLabel;

		// Token: 0x0400D903 RID: 55555
		[Token(Token = "0x400D903")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel ChipLabel;

		// Token: 0x0400D904 RID: 55556
		[Token(Token = "0x400D904")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject EndLine;

		// Token: 0x0400D905 RID: 55557
		[Token(Token = "0x400D905")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject baseProfile;

		// Token: 0x0400D906 RID: 55558
		[Token(Token = "0x400D906")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel DamageCount;
	}
}
