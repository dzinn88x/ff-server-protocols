using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C04 RID: 7172
	[Token(Token = "0x2001C04")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB57C", Offset = "0x10FB57C")]
	public class UIHUDWereWolvesEndShowTime : UIBaseController
	{
		// Token: 0x06009C00 RID: 39936 RVA: 0x00028F50 File Offset: 0x00027150
		[Token(Token = "0x6009C00")]
		[Address(RVA = "0x1D56D10", Offset = "0x1D56D10", VA = "0x7BBC556D10")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009C01 RID: 39937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C01")]
		[Address(RVA = "0x1D56D60", Offset = "0x1D56D60", VA = "0x7BBC556D60", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009C02 RID: 39938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C02")]
		[Address(RVA = "0x1D574E8", Offset = "0x1D574E8", VA = "0x7BBC5574E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009C03 RID: 39939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C03")]
		[Address(RVA = "0x1D570CC", Offset = "0x1D570CC", VA = "0x7BBC5570CC")]
		private void RefreshGameOverFlag(params object[] param)
		{
		}

		// Token: 0x06009C04 RID: 39940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C04")]
		[Address(RVA = "0x1D575B4", Offset = "0x1D575B4", VA = "0x7BBC5575B4")]
		public UIHUDWereWolvesEndShowTime()
		{
		}

		// Token: 0x0400A212 RID: 41490
		[Token(Token = "0x400A212")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDWereWolvesEndShowTimeView m_View;

		// Token: 0x0400A213 RID: 41491
		[Token(Token = "0x400A213")]
		[FieldOffset(Offset = "0x60")]
		private bool m_IsWolf;

		// Token: 0x0400A214 RID: 41492
		[Token(Token = "0x400A214")]
		[FieldOffset(Offset = "0x61")]
		private bool m_IsRefreshOver;
	}
}
