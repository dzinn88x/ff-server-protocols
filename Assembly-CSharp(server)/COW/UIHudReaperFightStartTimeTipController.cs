using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001642 RID: 5698
	[Token(Token = "0x2001642")]
	public class UIHudReaperFightStartTimeTipController : UIBaseController
	{
		// Token: 0x060066D2 RID: 26322 RVA: 0x0001D538 File Offset: 0x0001B738
		[Token(Token = "0x60066D2")]
		[Address(RVA = "0x17E9A7C", Offset = "0x17E9A7C", VA = "0x7BBBFE9A7C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D3")]
		[Address(RVA = "0x17E9ACC", Offset = "0x17E9ACC", VA = "0x7BBBFE9ACC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D4")]
		[Address(RVA = "0x17E9B30", Offset = "0x17E9B30", VA = "0x7BBBFE9B30")]
		private void Update()
		{
		}

		// Token: 0x060066D5 RID: 26325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D5")]
		[Address(RVA = "0x17E9F00", Offset = "0x17E9F00", VA = "0x7BBBFE9F00")]
		public UIHudReaperFightStartTimeTipController()
		{
		}

		// Token: 0x0400846D RID: 33901
		[Token(Token = "0x400846D")]
		[FieldOffset(Offset = "0x58")]
		private UIHudReaperFightStartTimeTipView m_View;

		// Token: 0x0400846E RID: 33902
		[Token(Token = "0x400846E")]
		[FieldOffset(Offset = "0x60")]
		private int lastLeftTimeS;
	}
}
