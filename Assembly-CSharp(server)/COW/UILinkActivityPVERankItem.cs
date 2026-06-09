using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001552 RID: 5458
	[Token(Token = "0x2001552")]
	public class UILinkActivityPVERankItem : MonoBehaviour
	{
		// Token: 0x06005E6C RID: 24172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E6C")]
		[Address(RVA = "0x1CC0658", Offset = "0x1CC0658", VA = "0x7BBC4C0658")]
		public void UpdateInfo(string rank, string name, uint epCount)
		{
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E6D")]
		[Address(RVA = "0x1CC0F0C", Offset = "0x1CC0F0C", VA = "0x7BBC4C0F0C")]
		public void Show()
		{
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E6E")]
		[Address(RVA = "0x1CC05E8", Offset = "0x1CC05E8", VA = "0x7BBC4C05E8")]
		public void Hide()
		{
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E6F")]
		[Address(RVA = "0x1CC0F7C", Offset = "0x1CC0F7C", VA = "0x7BBC4C0F7C")]
		public UILinkActivityPVERankItem()
		{
		}

		// Token: 0x04007FBD RID: 32701
		[Token(Token = "0x4007FBD")]
		[FieldOffset(Offset = "0x18")]
		public UILabel m_Rank;

		// Token: 0x04007FBE RID: 32702
		[Token(Token = "0x4007FBE")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_PlayerName;

		// Token: 0x04007FBF RID: 32703
		[Token(Token = "0x4007FBF")]
		[FieldOffset(Offset = "0x28")]
		public UILabel m_EPCount;
	}
}
