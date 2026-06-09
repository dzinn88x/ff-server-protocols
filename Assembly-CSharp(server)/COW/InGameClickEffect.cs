using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C23 RID: 7203
	[Token(Token = "0x2001C23")]
	internal class InGameClickEffect : MonoSingleton<InGameClickEffect>
	{
		// Token: 0x06009CC5 RID: 40133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CC5")]
		[Address(RVA = "0x185A39C", Offset = "0x185A39C", VA = "0x7BBC05A39C")]
		private void Start()
		{
		}

		// Token: 0x06009CC6 RID: 40134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CC6")]
		[Address(RVA = "0x185A3A0", Offset = "0x185A3A0", VA = "0x7BBC05A3A0")]
		private new void OnDestroy()
		{
		}

		// Token: 0x06009CC7 RID: 40135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CC7")]
		[Address(RVA = "0x185A4C8", Offset = "0x185A4C8", VA = "0x7BBC05A4C8", Slot = "5")]
		public override void Init()
		{
		}

		// Token: 0x06009CC8 RID: 40136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CC8")]
		[Address(RVA = "0x185A594", Offset = "0x185A594", VA = "0x7BBC05A594")]
		public void Show()
		{
		}

		// Token: 0x06009CC9 RID: 40137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CC9")]
		[Address(RVA = "0x185A64C", Offset = "0x185A64C", VA = "0x7BBC05A64C")]
		public void Hide()
		{
		}

		// Token: 0x06009CCA RID: 40138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CCA")]
		[Address(RVA = "0x185A704", Offset = "0x185A704", VA = "0x7BBC05A704")]
		public void RegisterUICameraCustomInput()
		{
		}

		// Token: 0x06009CCB RID: 40139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CCB")]
		[Address(RVA = "0x185A3A4", Offset = "0x185A3A4", VA = "0x7BBC05A3A4")]
		public void UnRegisterUICameraCustomInput()
		{
		}

		// Token: 0x06009CCC RID: 40140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CCC")]
		[Address(RVA = "0x185A834", Offset = "0x185A834", VA = "0x7BBC05A834")]
		private void OnUICameraCustomInput()
		{
		}

		// Token: 0x06009CCD RID: 40141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CCD")]
		[Address(RVA = "0x185AAFC", Offset = "0x185AAFC", VA = "0x7BBC05AAFC")]
		public InGameClickEffect()
		{
		}

		// Token: 0x0400A2AF RID: 41647
		[Token(Token = "0x400A2AF")]
		[FieldOffset(Offset = "0x18")]
		public Animator m_ClickEffect;

		// Token: 0x0400A2B0 RID: 41648
		[Token(Token = "0x400A2B0")]
		[FieldOffset(Offset = "0x20")]
		private bool m_Registered;
	}
}
