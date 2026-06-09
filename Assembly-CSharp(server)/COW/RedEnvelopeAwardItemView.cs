using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025A8 RID: 9640
	[Token(Token = "0x20025A8")]
	internal class RedEnvelopeAwardItemView : MonoBehaviour
	{
		// Token: 0x0600C663 RID: 50787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C663")]
		[Address(RVA = "0x1752654", Offset = "0x1752654", VA = "0x7BBBF52654")]
		public void SetItemData(RedEnvelopeAwardDisplayInfo awardInfo)
		{
		}

		// Token: 0x0600C664 RID: 50788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C664")]
		[Address(RVA = "0x17529B0", Offset = "0x17529B0", VA = "0x7BBBF529B0")]
		public RedEnvelopeAwardItemView()
		{
		}

		// Token: 0x0400F8F2 RID: 63730
		[Token(Token = "0x400F8F2")]
		[FieldOffset(Offset = "0x18")]
		public UILabel m_ReceiverLabel;

		// Token: 0x0400F8F3 RID: 63731
		[Token(Token = "0x400F8F3")]
		[FieldOffset(Offset = "0x20")]
		public GameObject m_CoinIcon;

		// Token: 0x0400F8F4 RID: 63732
		[Token(Token = "0x400F8F4")]
		[FieldOffset(Offset = "0x28")]
		public GameObject m_GemIcon;

		// Token: 0x0400F8F5 RID: 63733
		[Token(Token = "0x400F8F5")]
		[FieldOffset(Offset = "0x30")]
		public UILabel m_CountLabel;

		// Token: 0x0400F8F6 RID: 63734
		[Token(Token = "0x400F8F6")]
		[FieldOffset(Offset = "0x38")]
		public UILabel m_ItemCountLabel;

		// Token: 0x0400F8F7 RID: 63735
		[Token(Token = "0x400F8F7")]
		[FieldOffset(Offset = "0x40")]
		public GameObject m_LuckyIcon;
	}
}
