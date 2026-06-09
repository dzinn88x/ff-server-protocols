using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B8A RID: 7050
	[Token(Token = "0x2001B8A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA4BC", Offset = "0x10FA4BC")]
	public class UISPHudConsoleController : UIBaseController
	{
		// Token: 0x06009807 RID: 38919 RVA: 0x000280B0 File Offset: 0x000262B0
		[Token(Token = "0x6009807")]
		[Address(RVA = "0x1EE6948", Offset = "0x1EE6948", VA = "0x7BBC6E6948")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009808 RID: 38920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009808")]
		[Address(RVA = "0x1EE6998", Offset = "0x1EE6998", VA = "0x7BBC6E6998", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009809 RID: 38921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009809")]
		[Address(RVA = "0x1EE6AF8", Offset = "0x1EE6AF8", VA = "0x7BBC6E6AF8", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600980A RID: 38922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600980A")]
		[Address(RVA = "0x1EE6BC4", Offset = "0x1EE6BC4", VA = "0x7BBC6E6BC4")]
		private void OnConsoleProcess(params object[] data)
		{
		}

		// Token: 0x0600980B RID: 38923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600980B")]
		[Address(RVA = "0x1EE6E08", Offset = "0x1EE6E08", VA = "0x7BBC6E6E08")]
		public UISPHudConsoleController()
		{
		}

		// Token: 0x0400A00E RID: 40974
		[Token(Token = "0x400A00E")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudConsoleView m_View;
	}
}
