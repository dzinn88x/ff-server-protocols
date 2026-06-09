using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C6E RID: 7278
	[Token(Token = "0x2001C6E")]
	internal class UIHudSpeedRoyaleTeammateGroup : MonoBehaviour
	{
		// Token: 0x06009EB1 RID: 40625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB1")]
		[Address(RVA = "0x166DD00", Offset = "0x166DD00", VA = "0x7BBBE6DD00")]
		public void InitInfo(Vehicle v)
		{
		}

		// Token: 0x06009EB2 RID: 40626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB2")]
		[Address(RVA = "0x166DD54", Offset = "0x166DD54", VA = "0x7BBBE6DD54")]
		public void OnVehicleHPChanged(Vehicle v)
		{
		}

		// Token: 0x06009EB3 RID: 40627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB3")]
		[Address(RVA = "0x166DF20", Offset = "0x166DF20", VA = "0x7BBBE6DF20")]
		public UIHudSpeedRoyaleTeammateGroup()
		{
		}

		// Token: 0x0400A518 RID: 42264
		[Token(Token = "0x400A518")]
		[FieldOffset(Offset = "0x18")]
		public UIGrid Grid;

		// Token: 0x0400A519 RID: 42265
		[Token(Token = "0x400A519")]
		[FieldOffset(Offset = "0x20")]
		public UISprite VehicleHpSprite;

		// Token: 0x0400A51A RID: 42266
		[Token(Token = "0x400A51A")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<{QAb\u0082~u, UIHudSpeedRoyaleTeammateItem> TeammateItems;
	}
}
