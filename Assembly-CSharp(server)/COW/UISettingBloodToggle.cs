using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C66 RID: 7270
	[Token(Token = "0x2001C66")]
	public class UISettingBloodToggle : MonoBehaviour
	{
		// Token: 0x06009E80 RID: 40576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E80")]
		[Address(RVA = "0x1631168", Offset = "0x1631168", VA = "0x7BBBE31168")]
		private void Awake()
		{
		}

		// Token: 0x06009E81 RID: 40577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E81")]
		[Address(RVA = "0x1631204", Offset = "0x1631204", VA = "0x7BBBE31204")]
		private void OnEnable()
		{
		}

		// Token: 0x06009E82 RID: 40578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E82")]
		[Address(RVA = "0x16316E8", Offset = "0x16316E8", VA = "0x7BBBE316E8")]
		private void OnDisable()
		{
		}

		// Token: 0x06009E83 RID: 40579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E83")]
		[Address(RVA = "0x1631824", Offset = "0x1631824", VA = "0x7BBBE31824")]
		private void OnValueChange()
		{
		}

		// Token: 0x06009E84 RID: 40580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E84")]
		[Address(RVA = "0x1631AB8", Offset = "0x1631AB8", VA = "0x7BBBE31AB8")]
		public UISettingBloodToggle()
		{
		}

		// Token: 0x0400A4DC RID: 42204
		[Token(Token = "0x400A4DC")]
		[FieldOffset(Offset = "0x18")]
		public UIToggle redToggle;

		// Token: 0x0400A4DD RID: 42205
		[Token(Token = "0x400A4DD")]
		[FieldOffset(Offset = "0x20")]
		public UIToggle blackToggle;

		// Token: 0x0400A4DE RID: 42206
		[Token(Token = "0x400A4DE")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle nullToggle;

		// Token: 0x0400A4DF RID: 42207
		[Token(Token = "0x400A4DF")]
		[FieldOffset(Offset = "0x30")]
		public Transform redtr;

		// Token: 0x0400A4E0 RID: 42208
		[Token(Token = "0x400A4E0")]
		[FieldOffset(Offset = "0x38")]
		public Transform blacktr;

		// Token: 0x0400A4E1 RID: 42209
		[Token(Token = "0x400A4E1")]
		[FieldOffset(Offset = "0x40")]
		public Transform nulltr;
	}
}
