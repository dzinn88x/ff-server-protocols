using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001648 RID: 5704
	[Token(Token = "0x2001648")]
	public class UIHudReaperPhaseChangeMaskController : UIBaseController
	{
		// Token: 0x060066F1 RID: 26353 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
		[Token(Token = "0x60066F1")]
		[Address(RVA = "0x17EBC40", Offset = "0x17EBC40", VA = "0x7BBBFEBC40")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060066F2 RID: 26354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F2")]
		[Address(RVA = "0x17EBC90", Offset = "0x17EBC90", VA = "0x7BBBFEBC90", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F3")]
		[Address(RVA = "0x17EBD98", Offset = "0x17EBD98", VA = "0x7BBBFEBD98")]
		private void UpdateAlpha(float alpha)
		{
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F4")]
		[Address(RVA = "0x17EBDEC", Offset = "0x17EBDEC", VA = "0x7BBBFEBDEC")]
		private void Update()
		{
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F5")]
		[Address(RVA = "0x17EBFA8", Offset = "0x17EBFA8", VA = "0x7BBBFEBFA8")]
		public UIHudReaperPhaseChangeMaskController()
		{
		}

		// Token: 0x0400847D RID: 33917
		[Token(Token = "0x400847D")]
		[FieldOffset(Offset = "0x58")]
		private UIHudReaperPhaseChangeMaskView m_View;

		// Token: 0x0400847E RID: 33918
		[Token(Token = "0x400847E")]
		[FieldOffset(Offset = "0x60")]
		private FBDoAFN m_Game;
	}
}
