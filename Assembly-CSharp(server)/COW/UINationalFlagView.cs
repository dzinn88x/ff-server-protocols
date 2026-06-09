using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002459 RID: 9305
	[Token(Token = "0x2002459")]
	public class UINationalFlagView : UIBaseView
	{
		// Token: 0x0600C3C2 RID: 50114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C2")]
		[Address(RVA = "0x14D7B4C", Offset = "0x14D7B4C", VA = "0x7BBBCD7B4C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3C3 RID: 50115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C3")]
		[Address(RVA = "0x14D7C6C", Offset = "0x14D7C6C", VA = "0x7BBBCD7C6C")]
		public UINationalFlagView()
		{
		}

		// Token: 0x0400E8B4 RID: 59572
		[Token(Token = "0x400E8B4")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Mask;

		// Token: 0x0400E8B5 RID: 59573
		[Token(Token = "0x400E8B5")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Close;

		// Token: 0x0400E8B6 RID: 59574
		[Token(Token = "0x400E8B6")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList EasyList;
	}
}
