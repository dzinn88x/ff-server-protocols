using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C75 RID: 7285
	[Token(Token = "0x2001C75")]
	public class UIMultiTipsButton : MonoBehaviour, ITipsDelegate
	{
		// Token: 0x06009EE9 RID: 40681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EE9")]
		[Address(RVA = "0x14CC868", Offset = "0x14CC868", VA = "0x7BBBCCC868")]
		private void Awake()
		{
		}

		// Token: 0x06009EEA RID: 40682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EEA")]
		[Address(RVA = "0x14CCDBC", Offset = "0x14CCDBC", VA = "0x7BBBCCCDBC", Slot = "4")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06009EEB RID: 40683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EEB")]
		[Address(RVA = "0x14CCB88", Offset = "0x14CCB88", VA = "0x7BBBCCCB88")]
		private void SetTipNumber(int num)
		{
		}

		// Token: 0x06009EEC RID: 40684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EEC")]
		[Address(RVA = "0x14CCF60", Offset = "0x14CCF60", VA = "0x7BBBCCCF60")]
		private void ClearTipsWhenClick()
		{
		}

		// Token: 0x06009EED RID: 40685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EED")]
		[Address(RVA = "0x14CD220", Offset = "0x14CD220", VA = "0x7BBBCCD220")]
		private void OnDestroy()
		{
		}

		// Token: 0x06009EEE RID: 40686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EEE")]
		[Address(RVA = "0x14CD3B8", Offset = "0x14CD3B8", VA = "0x7BBBCCD3B8")]
		public UIMultiTipsButton()
		{
		}

		// Token: 0x0400A5DB RID: 42459
		[Token(Token = "0x400A5DB")]
		[FieldOffset(Offset = "0x18")]
		public UIButton m_Button;

		// Token: 0x0400A5DC RID: 42460
		[Token(Token = "0x400A5DC")]
		[FieldOffset(Offset = "0x20")]
		public GameObject m_TipsObject;

		// Token: 0x0400A5DD RID: 42461
		[Token(Token = "0x400A5DD")]
		[FieldOffset(Offset = "0x28")]
		public UILabel m_TipsNumLabel;

		// Token: 0x0400A5DE RID: 42462
		[Token(Token = "0x400A5DE")]
		[FieldOffset(Offset = "0x30")]
		public string[] m_TipsTypes;

		// Token: 0x0400A5DF RID: 42463
		[Token(Token = "0x400A5DF")]
		[FieldOffset(Offset = "0x38")]
		private List<ETipsType> m_Types;

		// Token: 0x0400A5E0 RID: 42464
		[Token(Token = "0x400A5E0")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<ETipsType, int> m_TipNums;

		// Token: 0x0400A5E1 RID: 42465
		[Token(Token = "0x400A5E1")]
		[FieldOffset(Offset = "0x48")]
		private bool m_IsClearing;
	}
}
