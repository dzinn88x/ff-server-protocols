using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200229C RID: 8860
	[Token(Token = "0x200229C")]
	public class UIHudControlLeaderboardItemView : UIBaseView
	{
		// Token: 0x0600C049 RID: 49225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C049")]
		[Address(RVA = "0x1A934E4", Offset = "0x1A934E4", VA = "0x7BBC2934E4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C04A RID: 49226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C04A")]
		[Address(RVA = "0x1A93738", Offset = "0x1A93738", VA = "0x7BBC293738")]
		public UIHudControlLeaderboardItemView()
		{
		}

		// Token: 0x0400D49B RID: 54427
		[Token(Token = "0x400D49B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BGDefault;

		// Token: 0x0400D49C RID: 54428
		[Token(Token = "0x400D49C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BGLocal;

		// Token: 0x0400D49D RID: 54429
		[Token(Token = "0x400D49D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelName;

		// Token: 0x0400D49E RID: 54430
		[Token(Token = "0x400D49E")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelClan;

		// Token: 0x0400D49F RID: 54431
		[Token(Token = "0x400D49F")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Label_1;

		// Token: 0x0400D4A0 RID: 54432
		[Token(Token = "0x400D4A0")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Label_2;

		// Token: 0x0400D4A1 RID: 54433
		[Token(Token = "0x400D4A1")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Label_3;

		// Token: 0x0400D4A2 RID: 54434
		[Token(Token = "0x400D4A2")]
		[FieldOffset(Offset = "0x58")]
		public UISprite RankSprite;
	}
}
