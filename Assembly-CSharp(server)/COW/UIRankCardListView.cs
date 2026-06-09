using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024C0 RID: 9408
	[Token(Token = "0x20024C0")]
	public class UIRankCardListView : UIBaseView
	{
		// Token: 0x0600C490 RID: 50320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C490")]
		[Address(RVA = "0x1E0A424", Offset = "0x1E0A424", VA = "0x7BBC60A424", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C491 RID: 50321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C491")]
		[Address(RVA = "0x1E0A514", Offset = "0x1E0A514", VA = "0x7BBC60A514")]
		public UIRankCardListView()
		{
		}

		// Token: 0x0400EF42 RID: 61250
		[Token(Token = "0x400EF42")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView ScrollView;

		// Token: 0x0400EF43 RID: 61251
		[Token(Token = "0x400EF43")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList EasyList;
	}
}
