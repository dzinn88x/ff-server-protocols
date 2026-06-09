using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002129 RID: 8489
	[Token(Token = "0x2002129")]
	public class UIChampionshipChannelItemView : UIBaseView
	{
		// Token: 0x0600BD62 RID: 48482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD62")]
		[Address(RVA = "0x1C2757C", Offset = "0x1C2757C", VA = "0x7BBC42757C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD63 RID: 48483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD63")]
		[Address(RVA = "0x1C2766C", Offset = "0x1C2766C", VA = "0x7BBC42766C")]
		public UIChampionshipChannelItemView()
		{
		}

		// Token: 0x0400C319 RID: 49945
		[Token(Token = "0x400C319")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Item;

		// Token: 0x0400C31A RID: 49946
		[Token(Token = "0x400C31A")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Channel;
	}
}
