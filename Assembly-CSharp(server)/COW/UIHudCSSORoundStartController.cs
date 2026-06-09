using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014D0 RID: 5328
	[Token(Token = "0x20014D0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDA44", Offset = "0x10EDA44")]
	internal class UIHudCSSORoundStartController : UIBaseController
	{
		// Token: 0x06005AF5 RID: 23285 RVA: 0x0001AA60 File Offset: 0x00018C60
		[Token(Token = "0x6005AF5")]
		[Address(RVA = "0x19CB5B4", Offset = "0x19CB5B4", VA = "0x7BBC1CB5B4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF6")]
		[Address(RVA = "0x19CB604", Offset = "0x19CB604", VA = "0x7BBC1CB604", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF7")]
		[Address(RVA = "0x19CB72C", Offset = "0x19CB72C", VA = "0x7BBC1CB72C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF8")]
		[Address(RVA = "0x19CB734", Offset = "0x19CB734", VA = "0x7BBC1CB734", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF9")]
		[Address(RVA = "0x19CB9E4", Offset = "0x19CB9E4", VA = "0x7BBC1CB9E4")]
		private void SetCurrRound()
		{
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFA")]
		[Address(RVA = "0x19CBB74", Offset = "0x19CBB74", VA = "0x7BBC1CBB74")]
		private void SetGameZoneInfo()
		{
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFB")]
		[Address(RVA = "0x19CBDBC", Offset = "0x19CBDBC", VA = "0x7BBC1CBDBC")]
		private void SetTeamInfo()
		{
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFC")]
		[Address(RVA = "0x19CC1DC", Offset = "0x19CC1DC", VA = "0x7BBC1CC1DC")]
		private void SetPlayerNum()
		{
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFD")]
		[Address(RVA = "0x19CC3C8", Offset = "0x19CC3C8", VA = "0x7BBC1CC3C8")]
		public UIHudCSSORoundStartController()
		{
		}

		// Token: 0x04007DB1 RID: 32177
		[Token(Token = "0x4007DB1")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCSSORoundStartView m_View;

		// Token: 0x04007DB2 RID: 32178
		[Token(Token = "0x4007DB2")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04007DB3 RID: 32179
		[Token(Token = "0x4007DB3")]
		[FieldOffset(Offset = "0x68")]
		private BmPqYDk m_Game;

		// Token: 0x04007DB4 RID: 32180
		[Token(Token = "0x4007DB4")]
		[FieldOffset(Offset = "0x70")]
		private byte m_MyTeamID;

		// Token: 0x04007DB5 RID: 32181
		[Token(Token = "0x4007DB5")]
		[FieldOffset(Offset = "0x71")]
		private byte m_CurrRoundOppoTeamID;
	}
}
