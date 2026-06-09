using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001435 RID: 5173
	[Token(Token = "0x2001435")]
	public class UIAvatarAwakenSwitchItemView : MonoBehaviour
	{
		// Token: 0x060055D7 RID: 21975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D7")]
		[Address(RVA = "0x1B21614", Offset = "0x1B21614", VA = "0x7BBC321614")]
		public void SetView(uint avatarId, ResourceID res)
		{
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D8")]
		[Address(RVA = "0x1B21698", Offset = "0x1B21698", VA = "0x7BBC321698")]
		public void SetHL(bool show)
		{
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x000198F0 File Offset: 0x00017AF0
		[Token(Token = "0x60055D9")]
		[Address(RVA = "0x1B216E8", Offset = "0x1B216E8", VA = "0x7BBC3216E8")]
		public bool GetHLState()
		{
			return default(bool);
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DA")]
		[Address(RVA = "0x1B21730", Offset = "0x1B21730", VA = "0x7BBC321730")]
		public void SetLock(bool _lock)
		{
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DB")]
		[Address(RVA = "0x1B21780", Offset = "0x1B21780", VA = "0x7BBC321780")]
		public UIAvatarAwakenSwitchItemView()
		{
		}

		// Token: 0x04007A98 RID: 31384
		[Token(Token = "0x4007A98")]
		[FieldOffset(Offset = "0x18")]
		public UISprite m_AvatarIcon;

		// Token: 0x04007A99 RID: 31385
		[Token(Token = "0x4007A99")]
		[FieldOffset(Offset = "0x20")]
		public UISprite m_HL;

		// Token: 0x04007A9A RID: 31386
		[Token(Token = "0x4007A9A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject m_Lock;
	}
}
