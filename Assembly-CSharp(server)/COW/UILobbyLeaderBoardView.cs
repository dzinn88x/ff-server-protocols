using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023FC RID: 9212
	[Token(Token = "0x20023FC")]
	internal class UILobbyLeaderBoardView : UIBaseView
	{
		// Token: 0x0600C308 RID: 49928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C308")]
		[Address(RVA = "0x144066C", Offset = "0x144066C", VA = "0x7BBBC4066C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C309 RID: 49929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C309")]
		[Address(RVA = "0x144075C", Offset = "0x144075C", VA = "0x7BBBC4075C")]
		public UILobbyLeaderBoardView()
		{
		}

		// Token: 0x0400E226 RID: 57894
		[Token(Token = "0x400E226")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btnMore;

		// Token: 0x0400E227 RID: 57895
		[Token(Token = "0x400E227")]
		[FieldOffset(Offset = "0x28")]
		public UICustomizedWrapContent WrapContent;
	}
}
