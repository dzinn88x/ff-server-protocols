using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023FB RID: 9211
	[Token(Token = "0x20023FB")]
	internal class UILobbyLeaderBoardItemView : UIBaseView
	{
		// Token: 0x0600C306 RID: 49926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C306")]
		[Address(RVA = "0x1440508", Offset = "0x1440508", VA = "0x7BBBC40508", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C307 RID: 49927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C307")]
		[Address(RVA = "0x1440664", Offset = "0x1440664", VA = "0x7BBBC40664")]
		public UILobbyLeaderBoardItemView()
		{
		}

		// Token: 0x0400E222 RID: 57890
		[Token(Token = "0x400E222")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture iconimage;

		// Token: 0x0400E223 RID: 57891
		[Token(Token = "0x400E223")]
		[FieldOffset(Offset = "0x28")]
		public GameObject first;

		// Token: 0x0400E224 RID: 57892
		[Token(Token = "0x400E224")]
		[FieldOffset(Offset = "0x30")]
		public GameObject second;

		// Token: 0x0400E225 RID: 57893
		[Token(Token = "0x400E225")]
		[FieldOffset(Offset = "0x38")]
		public GameObject third;
	}
}
