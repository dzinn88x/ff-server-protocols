using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001863 RID: 6243
	[Token(Token = "0x2001863")]
	public class UIHud2TeamsTimeScoreController : UIBaseController
	{
		// Token: 0x06007B06 RID: 31494 RVA: 0x00021DB0 File Offset: 0x0001FFB0
		[Token(Token = "0x6007B06")]
		[Address(RVA = "0x1D60A2C", Offset = "0x1D60A2C", VA = "0x7BBC560A2C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B07 RID: 31495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B07")]
		[Address(RVA = "0x1D60A7C", Offset = "0x1D60A7C", VA = "0x7BBC560A7C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007B08 RID: 31496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B08")]
		[Address(RVA = "0x1D60E6C", Offset = "0x1D60E6C", VA = "0x7BBC560E6C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007B09 RID: 31497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B09")]
		[Address(RVA = "0x1D61034", Offset = "0x1D61034", VA = "0x7BBC561034")]
		private void OnBtnLeaderboardClick()
		{
		}

		// Token: 0x06007B0A RID: 31498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0A")]
		[Address(RVA = "0x1D61114", Offset = "0x1D61114", VA = "0x7BBC561114")]
		private void OnTDMPhaseChange(params object[] data)
		{
		}

		// Token: 0x06007B0B RID: 31499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0B")]
		[Address(RVA = "0x1D61200", Offset = "0x1D61200", VA = "0x7BBC561200")]
		private void OnPhaseTimeChange(params object[] data)
		{
		}

		// Token: 0x06007B0C RID: 31500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0C")]
		[Address(RVA = "0x1D61238", Offset = "0x1D61238", VA = "0x7BBC561238")]
		private void Update()
		{
		}

		// Token: 0x06007B0D RID: 31501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0D")]
		[Address(RVA = "0x1D61268", Offset = "0x1D61268", VA = "0x7BBC561268")]
		private void OnTeamScoreChange(params object[] data)
		{
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0E")]
		[Address(RVA = "0x1D61324", Offset = "0x1D61324", VA = "0x7BBC561324")]
		private void UpdateTeamScore(int teamIndex, int score)
		{
		}

		// Token: 0x06007B0F RID: 31503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0F")]
		[Address(RVA = "0x1D6139C", Offset = "0x1D6139C", VA = "0x7BBC56139C")]
		private void OnADSBonusTeamScoreStart(params object[] data)
		{
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B10")]
		[Address(RVA = "0x1D61574", Offset = "0x1D61574", VA = "0x7BBC561574")]
		public UIHud2TeamsTimeScoreController()
		{
		}

		// Token: 0x06007B11 RID: 31505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B11")]
		[Address(RVA = "0x1D6157C", Offset = "0x1D6157C", VA = "0x7BBC56157C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114262C", Offset = "0x114262C")]
		private void <OnADSBonusTeamScoreStart>b__11_0()
		{
		}

		// Token: 0x04008F92 RID: 36754
		[Token(Token = "0x4008F92")]
		[FieldOffset(Offset = "0x58")]
		private UIHud2TeamsTimeScoreView m_View;

		// Token: 0x04008F93 RID: 36755
		[Token(Token = "0x4008F93")]
		[FieldOffset(Offset = "0x60")]
		private UITimeLabelHelper m_TimeHelper;
	}
}
