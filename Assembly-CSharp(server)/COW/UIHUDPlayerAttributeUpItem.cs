using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200192F RID: 6447
	[Token(Token = "0x200192F")]
	public class UIHUDPlayerAttributeUpItem : MonoBehaviour
	{
		// Token: 0x0600826A RID: 33386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600826A")]
		[Address(RVA = "0x16BCFA4", Offset = "0x16BCFA4", VA = "0x7BBBEBCFA4")]
		public void ShowMsg(string msg)
		{
		}

		// Token: 0x0600826B RID: 33387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600826B")]
		[Address(RVA = "0x16BD2CC", Offset = "0x16BD2CC", VA = "0x7BBBEBD2CC")]
		public UIHUDPlayerAttributeUpItem()
		{
		}

		// Token: 0x040093AD RID: 37805
		[Token(Token = "0x40093AD")]
		[FieldOffset(Offset = "0x18")]
		public float ItemDeltaY;

		// Token: 0x040093AE RID: 37806
		[Token(Token = "0x40093AE")]
		[FieldOffset(Offset = "0x20")]
		public UILabel ShowLabel;

		// Token: 0x040093AF RID: 37807
		[Token(Token = "0x40093AF")]
		[FieldOffset(Offset = "0x28")]
		public float m_TweenDuration;
	}
}
