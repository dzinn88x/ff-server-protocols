using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002383 RID: 9091
	[Token(Token = "0x2002383")]
	public class UIHudTokenLeaderboardItemView : UIBaseView
	{
		// Token: 0x0600C216 RID: 49686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C216")]
		[Address(RVA = "0x15E7170", Offset = "0x15E7170", VA = "0x7BBBDE7170", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C217 RID: 49687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C217")]
		[Address(RVA = "0x15E7378", Offset = "0x15E7378", VA = "0x7BBBDE7378")]
		public UIHudTokenLeaderboardItemView()
		{
		}

		// Token: 0x0400DCA1 RID: 56481
		[Token(Token = "0x400DCA1")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BGDefault;

		// Token: 0x0400DCA2 RID: 56482
		[Token(Token = "0x400DCA2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BGLocal;

		// Token: 0x0400DCA3 RID: 56483
		[Token(Token = "0x400DCA3")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelName;

		// Token: 0x0400DCA4 RID: 56484
		[Token(Token = "0x400DCA4")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelClan;

		// Token: 0x0400DCA5 RID: 56485
		[Token(Token = "0x400DCA5")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LabelKill;

		// Token: 0x0400DCA6 RID: 56486
		[Token(Token = "0x400DCA6")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelPick;

		// Token: 0x0400DCA7 RID: 56487
		[Token(Token = "0x400DCA7")]
		[FieldOffset(Offset = "0x50")]
		public UILabel LabelScore;
	}
}
