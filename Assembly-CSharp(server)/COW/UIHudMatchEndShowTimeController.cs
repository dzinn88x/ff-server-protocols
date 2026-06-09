using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001906 RID: 6406
	[Token(Token = "0x2001906")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F56E4", Offset = "0x10F56E4")]
	internal class UIHudMatchEndShowTimeController : UIHudMatchEndShowTimeControllerBase
	{
		// Token: 0x060080B5 RID: 32949 RVA: 0x000231C0 File Offset: 0x000213C0
		[Token(Token = "0x60080B5")]
		[Address(RVA = "0x15BE534", Offset = "0x15BE534", VA = "0x7BBBDBE534")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B6")]
		[Address(RVA = "0x15BE584", Offset = "0x15BE584", VA = "0x7BBBDBE584", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060080B7 RID: 32951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B7")]
		[Address(RVA = "0x15BEE80", Offset = "0x15BEE80", VA = "0x7BBBDBEE80", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060080B8 RID: 32952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B8")]
		[Address(RVA = "0x15BEF4C", Offset = "0x15BEF4C", VA = "0x7BBBDBEF4C")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x060080B9 RID: 32953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B9")]
		[Address(RVA = "0x15BE914", Offset = "0x15BE914", VA = "0x7BBBDBE914")]
		private void FillMatchResultInfo(bool win)
		{
		}

		// Token: 0x060080BA RID: 32954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080BA")]
		[Address(RVA = "0x15BEB4C", Offset = "0x15BEB4C", VA = "0x7BBBDBEB4C")]
		private void FillTeamScoreInfo(bool isTeamA, int leftScore, int rightScore)
		{
		}

		// Token: 0x060080BB RID: 32955 RVA: 0x000231D8 File Offset: 0x000213D8
		[Token(Token = "0x60080BB")]
		[Address(RVA = "0x15BF044", Offset = "0x15BF044", VA = "0x7BBBDBF044")]
		private bool NeedShowDefeatedGameMode()
		{
			return default(bool);
		}

		// Token: 0x060080BC RID: 32956 RVA: 0x000231F0 File Offset: 0x000213F0
		[Token(Token = "0x60080BC")]
		[Address(RVA = "0x15BF1B0", Offset = "0x15BF1B0", VA = "0x7BBBDBF1B0")]
		private bool NeedShowScoreGameMode()
		{
			return default(bool);
		}

		// Token: 0x060080BD RID: 32957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080BD")]
		[Address(RVA = "0x15BF31C", Offset = "0x15BF31C", VA = "0x7BBBDBF31C")]
		public UIHudMatchEndShowTimeController()
		{
		}

		// Token: 0x040092C7 RID: 37575
		[Token(Token = "0x40092C7")]
		[FieldOffset(Offset = "0x70")]
		private UIHudMatchEndShowTimeView m_View;
	}
}
