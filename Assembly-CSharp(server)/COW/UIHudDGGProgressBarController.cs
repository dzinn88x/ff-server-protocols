using System;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018A8 RID: 6312
	[Token(Token = "0x20018A8")]
	public class UIHudDGGProgressBarController : UIBaseController
	{
		// Token: 0x06007D5C RID: 32092 RVA: 0x000225F0 File Offset: 0x000207F0
		[Token(Token = "0x6007D5C")]
		[Address(RVA = "0x1AA9788", Offset = "0x1AA9788", VA = "0x7BBC2A9788")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007D5D RID: 32093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D5D")]
		[Address(RVA = "0x1AA97D8", Offset = "0x1AA97D8", VA = "0x7BBC2A97D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007D5E RID: 32094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D5E")]
		[Address(RVA = "0x1AAA2AC", Offset = "0x1AAA2AC", VA = "0x7BBC2AA2AC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007D5F RID: 32095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D5F")]
		[Address(RVA = "0x1AAA66C", Offset = "0x1AAA66C", VA = "0x7BBC2AA66C")]
		private void OnScoreChange(object[] data)
		{
		}

		// Token: 0x06007D60 RID: 32096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D60")]
		[Address(RVA = "0x1AAA938", Offset = "0x1AAA938", VA = "0x7BBC2AA938")]
		private void OnLeadingTeamIDChange(object[] data)
		{
		}

		// Token: 0x06007D61 RID: 32097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D61")]
		[Address(RVA = "0x1AAA9C8", Offset = "0x1AAA9C8", VA = "0x7BBC2AA9C8")]
		private void OnLeadingScoreChange(object[] data)
		{
		}

		// Token: 0x06007D62 RID: 32098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D62")]
		[Address(RVA = "0x1AAAA58", Offset = "0x1AAAA58", VA = "0x7BBC2AAA58")]
		private void On2ndTeamIDChange(object[] data)
		{
		}

		// Token: 0x06007D63 RID: 32099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D63")]
		[Address(RVA = "0x1AAAA5C", Offset = "0x1AAAA5C", VA = "0x7BBC2AAA5C")]
		private void On2ndScoreChange(object[] data)
		{
		}

		// Token: 0x06007D64 RID: 32100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D64")]
		[Address(RVA = "0x1AAAAEC", Offset = "0x1AAAAEC", VA = "0x7BBC2AAAEC")]
		public void OnFirstSecondInfoChange(int firstTeamdID, int firstScore, int secondTeamID, int secondScore)
		{
		}

		// Token: 0x06007D65 RID: 32101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D65")]
		[Address(RVA = "0x1AAAAF8", Offset = "0x1AAAAF8", VA = "0x7BBC2AAAF8")]
		public void OnWinScoreChange(object[] data)
		{
		}

		// Token: 0x06007D66 RID: 32102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D66")]
		[Address(RVA = "0x1AAAB84", Offset = "0x1AAAB84", VA = "0x7BBC2AAB84")]
		private void OnWinTimeChange(object[] data)
		{
		}

		// Token: 0x06007D67 RID: 32103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D67")]
		[Address(RVA = "0x1AAAC10", Offset = "0x1AAAC10", VA = "0x7BBC2AAC10")]
		private void OnShowScoreTutorial(object[] data)
		{
		}

		// Token: 0x06007D68 RID: 32104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D68")]
		[Address(RVA = "0x1AAAD04", Offset = "0x1AAAD04", VA = "0x7BBC2AAD04")]
		public void OnMatchEndTimeChange(object[] data)
		{
		}

		// Token: 0x06007D69 RID: 32105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D69")]
		[Address(RVA = "0x1AAAD90", Offset = "0x1AAAD90", VA = "0x7BBC2AAD90")]
		private void OnStartMatchEndShow(object[] data)
		{
		}

		// Token: 0x06007D6A RID: 32106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D6A")]
		[Address(RVA = "0x1AAA838", Offset = "0x1AAA838", VA = "0x7BBC2AA838")]
		private void UpdateBar()
		{
		}

		// Token: 0x06007D6B RID: 32107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D6B")]
		[Address(RVA = "0x1AA9C8C", Offset = "0x1AA9C8C", VA = "0x7BBC2A9C8C")]
		private void UpdateBarDetail(bool isLocalLeading)
		{
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D6C")]
		[Address(RVA = "0x1AAAD98", Offset = "0x1AAAD98", VA = "0x7BBC2AAD98")]
		private void Update()
		{
		}

		// Token: 0x06007D6D RID: 32109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D6D")]
		[Address(RVA = "0x1AAB094", Offset = "0x1AAB094", VA = "0x7BBC2AB094")]
		public UIHudDGGProgressBarController()
		{
		}

		// Token: 0x06007D6E RID: 32110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D6E")]
		[Address(RVA = "0x1AAB0B0", Offset = "0x1AAB0B0", VA = "0x7BBC2AB0B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142B54", Offset = "0x1142B54")]
		private void <OnShowScoreTutorial>b__23_0()
		{
		}

		// Token: 0x040090F3 RID: 37107
		[Token(Token = "0x40090F3")]
		[FieldOffset(Offset = "0x58")]
		private UIHudDGGProgressBarView m_View;

		// Token: 0x040090F4 RID: 37108
		[Token(Token = "0x40090F4")]
		[FieldOffset(Offset = "0x60")]
		private int m_WinScore;

		// Token: 0x040090F5 RID: 37109
		[Token(Token = "0x40090F5")]
		[FieldOffset(Offset = "0x64")]
		private int m_WinTime;

		// Token: 0x040090F6 RID: 37110
		[Token(Token = "0x40090F6")]
		[FieldOffset(Offset = "0x68")]
		private int m_MatchEndTime;

		// Token: 0x040090F7 RID: 37111
		[Token(Token = "0x40090F7")]
		[FieldOffset(Offset = "0x6C")]
		private int m_CurLeftTime;

		// Token: 0x040090F8 RID: 37112
		[Token(Token = "0x40090F8")]
		[FieldOffset(Offset = "0x70")]
		private StringBuilder m_Timer;

		// Token: 0x040090F9 RID: 37113
		[Token(Token = "0x40090F9")]
		[FieldOffset(Offset = "0x78")]
		private int m_MyScore;

		// Token: 0x040090FA RID: 37114
		[Token(Token = "0x40090FA")]
		[FieldOffset(Offset = "0x7C")]
		private int m_LeadingTeamID;

		// Token: 0x040090FB RID: 37115
		[Token(Token = "0x40090FB")]
		[FieldOffset(Offset = "0x80")]
		private int m_LeadingScore;

		// Token: 0x040090FC RID: 37116
		[Token(Token = "0x40090FC")]
		[FieldOffset(Offset = "0x84")]
		private int m_2ndScore;

		// Token: 0x040090FD RID: 37117
		[Token(Token = "0x40090FD")]
		[FieldOffset(Offset = "0x88")]
		private int m_1stDepth;

		// Token: 0x040090FE RID: 37118
		[Token(Token = "0x40090FE")]
		[FieldOffset(Offset = "0x8C")]
		private int m_2ndDepth;
	}
}
