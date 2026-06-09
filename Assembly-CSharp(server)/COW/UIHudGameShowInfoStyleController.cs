using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018CB RID: 6347
	[Token(Token = "0x20018CB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4DA4", Offset = "0x10F4DA4")]
	public class UIHudGameShowInfoStyleController : UIBaseController
	{
		// Token: 0x06007E68 RID: 32360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E68")]
		[Address(RVA = "0x1C146D4", Offset = "0x1C146D4", VA = "0x7BBC4146D4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E69 RID: 32361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E69")]
		[Address(RVA = "0x1C14264", Offset = "0x1C14264", VA = "0x7BBC414264")]
		public void SetViewData(string introTxt, string introBigTxt, string detailTxt)
		{
		}

		// Token: 0x06007E6A RID: 32362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E6A")]
		[Address(RVA = "0x1C14750", Offset = "0x1C14750", VA = "0x7BBC414750")]
		public UIHudGameShowInfoStyleController()
		{
		}

		// Token: 0x040091C5 RID: 37317
		[Token(Token = "0x40091C5")]
		[FieldOffset(Offset = "0x58")]
		private UIHudGameShowInfoStyleView m_View;

		// Token: 0x040091C6 RID: 37318
		[Token(Token = "0x40091C6")]
		[FieldOffset(Offset = "0x60")]
		private Animation m_Animation;
	}
}
