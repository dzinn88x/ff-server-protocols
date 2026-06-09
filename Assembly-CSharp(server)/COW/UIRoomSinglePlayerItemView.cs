using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024EB RID: 9451
	[Token(Token = "0x20024EB")]
	public class UIRoomSinglePlayerItemView : UIBaseView
	{
		// Token: 0x0600C4E6 RID: 50406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4E6")]
		[Address(RVA = "0x1A23DEC", Offset = "0x1A23DEC", VA = "0x7BBC223DEC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4E7 RID: 50407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4E7")]
		[Address(RVA = "0x1A23F0C", Offset = "0x1A23F0C", VA = "0x7BBC223F0C")]
		public UIRoomSinglePlayerItemView()
		{
		}

		// Token: 0x0400F070 RID: 61552
		[Token(Token = "0x400F070")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Selected;

		// Token: 0x0400F071 RID: 61553
		[Token(Token = "0x400F071")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Id;

		// Token: 0x0400F072 RID: 61554
		[Token(Token = "0x400F072")]
		[FieldOffset(Offset = "0x30")]
		public GameObject PlayerGo;
	}
}
