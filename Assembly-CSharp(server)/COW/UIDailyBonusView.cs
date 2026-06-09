using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002193 RID: 8595
	[Token(Token = "0x2002193")]
	internal class UIDailyBonusView : UIBaseView
	{
		// Token: 0x0600BE36 RID: 48694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE36")]
		[Address(RVA = "0x1BACE04", Offset = "0x1BACE04", VA = "0x7BBC3ACE04", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE37 RID: 48695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE37")]
		[Address(RVA = "0x1BACF88", Offset = "0x1BACF88", VA = "0x7BBC3ACF88")]
		public UIDailyBonusView()
		{
		}

		// Token: 0x0400C88F RID: 51343
		[Token(Token = "0x400C88F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton TipsBtn;

		// Token: 0x0400C890 RID: 51344
		[Token(Token = "0x400C890")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ExpBonus;

		// Token: 0x0400C891 RID: 51345
		[Token(Token = "0x400C891")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GoldBonus;

		// Token: 0x0400C892 RID: 51346
		[Token(Token = "0x400C892")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ExpBonusAchieved;

		// Token: 0x0400C893 RID: 51347
		[Token(Token = "0x400C893")]
		[FieldOffset(Offset = "0x40")]
		public GameObject GoldBonusAchieved;
	}
}
