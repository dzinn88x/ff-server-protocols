using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200230F RID: 8975
	[Token(Token = "0x200230F")]
	public class UIHudMatchResultBaseRewardView : UIBaseView
	{
		// Token: 0x0600C12E RID: 49454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C12E")]
		[Address(RVA = "0x15CC45C", Offset = "0x15CC45C", VA = "0x7BBBDCC45C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C12F RID: 49455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C12F")]
		[Address(RVA = "0x15CC744", Offset = "0x15CC744", VA = "0x7BBBDCC744")]
		public UIHudMatchResultBaseRewardView()
		{
		}

		// Token: 0x0400D8D7 RID: 55511
		[Token(Token = "0x400D8D7")]
		[FieldOffset(Offset = "0x20")]
		public UITable ItemTable;

		// Token: 0x0400D8D8 RID: 55512
		[Token(Token = "0x400D8D8")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GoldIcon;

		// Token: 0x0400D8D9 RID: 55513
		[Token(Token = "0x400D8D9")]
		[FieldOffset(Offset = "0x30")]
		public UILabel GoldCount;

		// Token: 0x0400D8DA RID: 55514
		[Token(Token = "0x400D8DA")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ExpIcon;

		// Token: 0x0400D8DB RID: 55515
		[Token(Token = "0x400D8DB")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ExpCount;

		// Token: 0x0400D8DC RID: 55516
		[Token(Token = "0x400D8DC")]
		[FieldOffset(Offset = "0x48")]
		public UISprite PetExpIcon;

		// Token: 0x0400D8DD RID: 55517
		[Token(Token = "0x400D8DD")]
		[FieldOffset(Offset = "0x50")]
		public UILabel PetExpCount;

		// Token: 0x0400D8DE RID: 55518
		[Token(Token = "0x400D8DE")]
		[FieldOffset(Offset = "0x58")]
		public UIButton DetailBtn;

		// Token: 0x0400D8DF RID: 55519
		[Token(Token = "0x400D8DF")]
		[FieldOffset(Offset = "0x60")]
		public UIButton DetailMaskBtn;

		// Token: 0x0400D8E0 RID: 55520
		[Token(Token = "0x400D8E0")]
		[FieldOffset(Offset = "0x68")]
		public UIMatchResultDetailView MatchResultDetailWindow;
	}
}
