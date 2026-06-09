using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200193F RID: 6463
	[Token(Token = "0x200193F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5D9C", Offset = "0x10F5D9C")]
	internal class UIHudQuitConfirmController : UIBaseController
	{
		// Token: 0x06008313 RID: 33555 RVA: 0x00023988 File Offset: 0x00021B88
		[Token(Token = "0x6008313")]
		[Address(RVA = "0x17E6F04", Offset = "0x17E6F04", VA = "0x7BBBFE6F04")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008314 RID: 33556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008314")]
		[Address(RVA = "0x17E6F54", Offset = "0x17E6F54", VA = "0x7BBBFE6F54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008315 RID: 33557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008315")]
		[Address(RVA = "0x17E7178", Offset = "0x17E7178", VA = "0x7BBBFE7178", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008316 RID: 33558 RVA: 0x000239A0 File Offset: 0x00021BA0
		[Token(Token = "0x6008316")]
		[Address(RVA = "0x17E72B0", Offset = "0x17E72B0", VA = "0x7BBBFE72B0")]
		private bool OnEscapeClick()
		{
			return default(bool);
		}

		// Token: 0x06008317 RID: 33559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008317")]
		[Address(RVA = "0x17E72F0", Offset = "0x17E72F0", VA = "0x7BBBFE72F0")]
		private void OnBtnCancelClick()
		{
		}

		// Token: 0x06008318 RID: 33560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008318")]
		[Address(RVA = "0x17E72F8", Offset = "0x17E72F8", VA = "0x7BBBFE72F8")]
		private void OnBtnOKClick()
		{
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008319")]
		[Address(RVA = "0x17E76C4", Offset = "0x17E76C4", VA = "0x7BBBFE76C4")]
		public UIHudQuitConfirmController()
		{
		}

		// Token: 0x0400941A RID: 37914
		[Token(Token = "0x400941A")]
		[FieldOffset(Offset = "0x58")]
		private UIHudQuitConfirmView m_View;
	}
}
