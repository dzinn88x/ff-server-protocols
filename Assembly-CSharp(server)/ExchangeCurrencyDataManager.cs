using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

// Token: 0x0200013C RID: 316
[Token(Token = "0x200013C")]
public class ExchangeCurrencyDataManager : SingletonModule<ExchangeCurrencyDataManager>
{
	// Token: 0x060005ED RID: 1517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x23FA760", Offset = "0x23FA760", VA = "0x7BBCBFA760", Slot = "6")]
	protected override void OnInit()
	{
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x23FA764", Offset = "0x23FA764", VA = "0x7BBCBFA764")]
	public void ProcessData(CSGetExchangeCurrencyAllDescRes res)
	{
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x23FA8F0", Offset = "0x23FA8F0", VA = "0x7BBCBFA8F0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x23FA950", Offset = "0x23FA950", VA = "0x7BBCBFA950")]
	public ExchangeCurrencyDesc GetExchangeCurrency(uint id)
	{
		return null;
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x23FA9D0", Offset = "0x23FA9D0", VA = "0x7BBCBFA9D0")]
	public void SetExchangeWebsiteData(CSGetExchangeWebsiteRes res)
	{
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x23FAB44", Offset = "0x23FAB44", VA = "0x7BBCBFAB44")]
	public ExchangeCurrencyDataManager()
	{
	}

	// Token: 0x0400051B RID: 1307
	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, ExchangeCurrencyDesc> m_ExchangeCurrencyDict;

	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	public enum EExchangeCurrencyType
	{
		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		NONE,
		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		ACTIVITYEXCHANGE,
		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		MALLEXCHANGE,
		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		WEBSITE
	}

	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	public enum EExchangeCurrencySubType
	{
		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		NONE,
		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		Rank = 5,
		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		Crystal,
		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		Clan = 16
	}
}
