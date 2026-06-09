using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025B9 RID: 9657
	[Token(Token = "0x20025B9")]
	public class UIHudCSSOTeamInfoView : MonoBehaviour
	{
		// Token: 0x0600C6A5 RID: 50853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A5")]
		[Address(RVA = "0x19C5B1C", Offset = "0x19C5B1C", VA = "0x7BBC1C5B1C")]
		public void SetColor(Color c)
		{
		}

		// Token: 0x0600C6A6 RID: 50854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A6")]
		[Address(RVA = "0x19C5C5C", Offset = "0x19C5C5C", VA = "0x7BBC1C5C5C")]
		public void SetHp(byte hp)
		{
		}

		// Token: 0x0600C6A7 RID: 50855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A7")]
		[Address(RVA = "0x19CAC8C", Offset = "0x19CAC8C", VA = "0x7BBC1CAC8C")]
		public void ShowHpAnim(byte lastRoundHp, byte currHp)
		{
		}

		// Token: 0x0600C6A8 RID: 50856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A8")]
		[Address(RVA = "0x19CC7DC", Offset = "0x19CC7DC", VA = "0x7BBC1CC7DC")]
		public UIHudCSSOTeamInfoView()
		{
		}

		// Token: 0x0400F939 RID: 63801
		[Token(Token = "0x400F939")]
		[FieldOffset(Offset = "0x18")]
		public UISprite[] m_Sprites;

		// Token: 0x0400F93A RID: 63802
		[Token(Token = "0x400F93A")]
		[FieldOffset(Offset = "0x20")]
		public UISprite[] m_Hps;

		// Token: 0x0400F93B RID: 63803
		[Token(Token = "0x400F93B")]
		[FieldOffset(Offset = "0x28")]
		public Animation[] m_HpAnims;

		// Token: 0x0400F93C RID: 63804
		[Token(Token = "0x400F93C")]
		[FieldOffset(Offset = "0x30")]
		public TweenFill[] m_HpTween;
	}
}
