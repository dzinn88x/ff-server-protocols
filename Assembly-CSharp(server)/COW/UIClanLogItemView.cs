using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C77 RID: 7287
	[Token(Token = "0x2001C77")]
	public class UIClanLogItemView : MonoBehaviour
	{
		// Token: 0x06009EF6 RID: 40694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF6")]
		[Address(RVA = "0x1CFDD84", Offset = "0x1CFDD84", VA = "0x7BBC4FDD84")]
		public void SetData(string content, string time)
		{
		}

		// Token: 0x06009EF7 RID: 40695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF7")]
		[Address(RVA = "0x1CFDD2C", Offset = "0x1CFDD2C", VA = "0x7BBC4FDD2C")]
		public void Clear()
		{
		}

		// Token: 0x06009EF8 RID: 40696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF8")]
		[Address(RVA = "0x1CFDE84", Offset = "0x1CFDE84", VA = "0x7BBC4FDE84")]
		public UIClanLogItemView()
		{
		}

		// Token: 0x0400A5E7 RID: 42471
		[Token(Token = "0x400A5E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UILabel m_ContentLabel;

		// Token: 0x0400A5E8 RID: 42472
		[Token(Token = "0x400A5E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UILabel m_TimeLabel;
	}
}
