using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C62 RID: 7266
	[Token(Token = "0x2001C62")]
	internal class BaseProfileView : MonoBehaviour
	{
		// Token: 0x06009E57 RID: 40535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E57")]
		[Address(RVA = "0x21D6098", Offset = "0x21D6098", VA = "0x7BBC9D6098")]
		public void SetUIData(BaseProfileInfo data)
		{
		}

		// Token: 0x06009E58 RID: 40536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E58")]
		[Address(RVA = "0x21D6524", Offset = "0x21D6524", VA = "0x7BBC9D6524")]
		public BaseProfileView()
		{
		}

		// Token: 0x0400A492 RID: 42130
		[Token(Token = "0x400A492")]
		[FieldOffset(Offset = "0x18")]
		public UILabel UI_Nickname;

		// Token: 0x0400A493 RID: 42131
		[Token(Token = "0x400A493")]
		[FieldOffset(Offset = "0x20")]
		public UILabel UI_ExternalName;

		// Token: 0x0400A494 RID: 42132
		[Token(Token = "0x400A494")]
		[FieldOffset(Offset = "0x28")]
		public UILabel UI_OnlineState;

		// Token: 0x0400A495 RID: 42133
		[Token(Token = "0x400A495")]
		[FieldOffset(Offset = "0x30")]
		public UILabel UI_Level;

		// Token: 0x0400A496 RID: 42134
		[Token(Token = "0x400A496")]
		[FieldOffset(Offset = "0x38")]
		public UISprite UI_PlatformIcon;

		// Token: 0x0400A497 RID: 42135
		[Token(Token = "0x400A497")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTexture UI_HeadIcon;

		// Token: 0x0400A498 RID: 42136
		[Token(Token = "0x400A498")]
		[FieldOffset(Offset = "0x48")]
		public UISprite UI_Gender;

		// Token: 0x0400A499 RID: 42137
		[Token(Token = "0x400A499")]
		[FieldOffset(Offset = "0x50")]
		public Color Online_Color;

		// Token: 0x0400A49A RID: 42138
		[Token(Token = "0x400A49A")]
		[FieldOffset(Offset = "0x60")]
		public Color Offline_Color;
	}
}
