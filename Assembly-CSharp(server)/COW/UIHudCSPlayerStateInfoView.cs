using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025B8 RID: 9656
	[Token(Token = "0x20025B8")]
	public class UIHudCSPlayerStateInfoView : MonoBehaviour
	{
		// Token: 0x0600C6A2 RID: 50850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A2")]
		[Address(RVA = "0x19BFCC8", Offset = "0x19BFCC8", VA = "0x7BBC1BFCC8")]
		public void SetTeammateState(ETeammateState nextState)
		{
		}

		// Token: 0x0600C6A3 RID: 50851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A3")]
		[Address(RVA = "0x19C1F88", Offset = "0x19C1F88", VA = "0x7BBC1C1F88")]
		public void HideTeammateStates()
		{
		}

		// Token: 0x0600C6A4 RID: 50852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A4")]
		[Address(RVA = "0x19C2048", Offset = "0x19C2048", VA = "0x7BBC1C2048")]
		public UIHudCSPlayerStateInfoView()
		{
		}

		// Token: 0x0400F936 RID: 63798
		[Token(Token = "0x400F936")]
		[FieldOffset(Offset = "0x18")]
		public UISprite StateAlive;

		// Token: 0x0400F937 RID: 63799
		[Token(Token = "0x400F937")]
		[FieldOffset(Offset = "0x20")]
		public UISprite StateKnockDown;

		// Token: 0x0400F938 RID: 63800
		[Token(Token = "0x400F938")]
		[FieldOffset(Offset = "0x28")]
		public UISprite StateDead;
	}
}
