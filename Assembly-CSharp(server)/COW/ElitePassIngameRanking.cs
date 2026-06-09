using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014EA RID: 5354
	[Token(Token = "0x20014EA")]
	public class ElitePassIngameRanking : MonoBehaviour
	{
		// Token: 0x06005B96 RID: 23446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B96")]
		[Address(RVA = "0x1B84984", Offset = "0x1B84984", VA = "0x7BBC384984")]
		public void SetData(string name, string count, uint id, uint pinId = 0U, bool isCelebrity = false, bool useSpriteText = false)
		{
		}

		// Token: 0x06005B97 RID: 23447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B97")]
		[Address(RVA = "0x1B84E38", Offset = "0x1B84E38", VA = "0x7BBC384E38")]
		public ElitePassIngameRanking()
		{
		}

		// Token: 0x04007E12 RID: 32274
		[Token(Token = "0x4007E12")]
		[FieldOffset(Offset = "0x18")]
		public UILabel m_Nickname;

		// Token: 0x04007E13 RID: 32275
		[Token(Token = "0x4007E13")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_BadgeCount;

		// Token: 0x04007E14 RID: 32276
		[Token(Token = "0x4007E14")]
		[FieldOffset(Offset = "0x28")]
		public UISprite m_IconSprite;

		// Token: 0x04007E15 RID: 32277
		[Token(Token = "0x4007E15")]
		[FieldOffset(Offset = "0x30")]
		public UISprite m_PinIcon;

		// Token: 0x04007E16 RID: 32278
		[Token(Token = "0x4007E16")]
		[FieldOffset(Offset = "0x38")]
		public GameObject m_CelebrityEffect;
	}
}
