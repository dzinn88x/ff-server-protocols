using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200193D RID: 6461
	[Token(Token = "0x200193D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5D2C", Offset = "0x10F5D2C")]
	internal class UIHudQuickUsePacemakerController : UIBaseController
	{
		// Token: 0x060082FA RID: 33530 RVA: 0x00023940 File Offset: 0x00021B40
		[Token(Token = "0x60082FA")]
		[Address(RVA = "0x17E41AC", Offset = "0x17E41AC", VA = "0x7BBBFE41AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060082FB RID: 33531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082FB")]
		[Address(RVA = "0x17E41FC", Offset = "0x17E41FC", VA = "0x7BBBFE41FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060082FC RID: 33532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082FC")]
		[Address(RVA = "0x17E44B8", Offset = "0x17E44B8", VA = "0x7BBBFE44B8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060082FD RID: 33533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082FD")]
		[Address(RVA = "0x17E46CC", Offset = "0x17E46CC", VA = "0x7BBBFE46CC")]
		private void OnPlayerStatsKnockDownChange(object[] param)
		{
		}

		// Token: 0x060082FE RID: 33534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082FE")]
		[Address(RVA = "0x17E49A8", Offset = "0x17E49A8", VA = "0x7BBBFE49A8")]
		private void OnShow(object[] param)
		{
		}

		// Token: 0x060082FF RID: 33535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082FF")]
		[Address(RVA = "0x17E4A40", Offset = "0x17E4A40", VA = "0x7BBBFE4A40")]
		private void OnPlayerDead(object[] param)
		{
		}

		// Token: 0x06008300 RID: 33536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008300")]
		[Address(RVA = "0x17E4858", Offset = "0x17E4858", VA = "0x7BBBFE4858")]
		private void RefreshActiveState(bool show)
		{
		}

		// Token: 0x06008301 RID: 33537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008301")]
		[Address(RVA = "0x17E4A50", Offset = "0x17E4A50", VA = "0x7BBBFE4A50")]
		private void OnBtnClick()
		{
		}

		// Token: 0x06008302 RID: 33538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008302")]
		[Address(RVA = "0x17E4BB0", Offset = "0x17E4BB0", VA = "0x7BBBFE4BB0")]
		public UIHudQuickUsePacemakerController()
		{
		}

		// Token: 0x04009415 RID: 37909
		[Token(Token = "0x4009415")]
		[FieldOffset(Offset = "0x58")]
		private UIHudQuickUsePacemakerView m_View;
	}
}
