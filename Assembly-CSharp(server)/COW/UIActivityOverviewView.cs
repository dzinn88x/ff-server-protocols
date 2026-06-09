using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020E4 RID: 8420
	[Token(Token = "0x20020E4")]
	internal class UIActivityOverviewView : UIBaseView
	{
		// Token: 0x0600BCD9 RID: 48345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD9")]
		[Address(RVA = "0x1958268", Offset = "0x1958268", VA = "0x7BBC158268", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCDA RID: 48346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCDA")]
		[Address(RVA = "0x1958358", Offset = "0x1958358", VA = "0x7BBC158358")]
		public UIActivityOverviewView()
		{
		}

		// Token: 0x0400BF29 RID: 48937
		[Token(Token = "0x400BF29")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid Container;

		// Token: 0x0400BF2A RID: 48938
		[Token(Token = "0x400BF2A")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture BGCDN;
	}
}
