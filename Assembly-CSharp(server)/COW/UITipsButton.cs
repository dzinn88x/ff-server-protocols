using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C76 RID: 7286
	[Token(Token = "0x2001C76")]
	public class UITipsButton : MonoBehaviour, ITipsDelegate
	{
		// Token: 0x06009EEF RID: 40687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EEF")]
		[Address(RVA = "0x1F54254", Offset = "0x1F54254", VA = "0x7BBC754254")]
		private void Awake()
		{
		}

		// Token: 0x06009EF0 RID: 40688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF0")]
		[Address(RVA = "0x1F54350", Offset = "0x1F54350", VA = "0x7BBC754350")]
		public void SetTipsType(ETipsType type)
		{
		}

		// Token: 0x06009EF1 RID: 40689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF1")]
		[Address(RVA = "0x1F54798", Offset = "0x1F54798", VA = "0x7BBC754798", Slot = "4")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06009EF2 RID: 40690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF2")]
		[Address(RVA = "0x1F54564", Offset = "0x1F54564", VA = "0x7BBC754564")]
		private void SetTipNumber(int num)
		{
		}

		// Token: 0x06009EF3 RID: 40691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF3")]
		[Address(RVA = "0x1F547B0", Offset = "0x1F547B0", VA = "0x7BBC7547B0")]
		private void ClearTipsWhenClick()
		{
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF4")]
		[Address(RVA = "0x1F5483C", Offset = "0x1F5483C", VA = "0x7BBC75483C")]
		private void OnDestroy()
		{
		}

		// Token: 0x06009EF5 RID: 40693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF5")]
		[Address(RVA = "0x1F548D4", Offset = "0x1F548D4", VA = "0x7BBC7548D4")]
		public UITipsButton()
		{
		}

		// Token: 0x0400A5E2 RID: 42466
		[Token(Token = "0x400A5E2")]
		[FieldOffset(Offset = "0x18")]
		public UIButton m_Button;

		// Token: 0x0400A5E3 RID: 42467
		[Token(Token = "0x400A5E3")]
		[FieldOffset(Offset = "0x20")]
		public string m_TipsType;

		// Token: 0x0400A5E4 RID: 42468
		[Token(Token = "0x400A5E4")]
		[FieldOffset(Offset = "0x28")]
		public GameObject m_TipsObject;

		// Token: 0x0400A5E5 RID: 42469
		[Token(Token = "0x400A5E5")]
		[FieldOffset(Offset = "0x30")]
		public UILabel m_TipsNumLabel;

		// Token: 0x0400A5E6 RID: 42470
		[Token(Token = "0x400A5E6")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public ETipsType m_Type;
	}
}
