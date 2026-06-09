using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002256 RID: 8790
	[Token(Token = "0x2002256")]
	internal class UIHistoryTeammateView : UIBaseView
	{
		// Token: 0x0600BFBD RID: 49085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFBD")]
		[Address(RVA = "0x1D6092C", Offset = "0x1D6092C", VA = "0x7BBC56092C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFBE RID: 49086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFBE")]
		[Address(RVA = "0x1D60A1C", Offset = "0x1D60A1C", VA = "0x7BBC560A1C")]
		public UIHistoryTeammateView()
		{
		}

		// Token: 0x0400D31B RID: 54043
		[Token(Token = "0x400D31B")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Kill;

		// Token: 0x0400D31C RID: 54044
		[Token(Token = "0x400D31C")]
		[FieldOffset(Offset = "0x28")]
		public UIButton AddFriend;
	}
}
