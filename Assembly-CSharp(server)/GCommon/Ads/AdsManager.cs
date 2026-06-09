using System;
using Il2CppDummyDll;

namespace GCommon.Ads
{
	// Token: 0x0200106F RID: 4207
	[Token(Token = "0x200106F")]
	public class AdsManager
	{
		// Token: 0x06004049 RID: 16457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004049")]
		[Address(RVA = "0x25D7294", Offset = "0x25D7294", VA = "0x7BBCDD7294")]
		private AdsManager()
		{
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700075C")]
		public static AdsManager I
		{
			[Token(Token = "0x600404A")]
			[Address(RVA = "0x25D729C", Offset = "0x25D729C", VA = "0x7BBCDD729C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404B")]
		[Address(RVA = "0x25D731C", Offset = "0x25D731C", VA = "0x7BBCDD731C")]
		public BaseRewardedVideoAds GetRewardedVideoAds()
		{
			return null;
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600404C")]
		[Address(RVA = "0x25D73A0", Offset = "0x25D73A0", VA = "0x7BBCDD73A0")]
		public void SetLogCallbacks(Action<string> log, Action<string> logError)
		{
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600404D")]
		[Address(RVA = "0x25D73A8", Offset = "0x25D73A8", VA = "0x7BBCDD73A8")]
		internal void Log(string content)
		{
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600404E")]
		[Address(RVA = "0x25D74AC", Offset = "0x25D74AC", VA = "0x7BBCDD74AC")]
		internal void LogError(string content)
		{
		}

		// Token: 0x04004FEC RID: 20460
		[Token(Token = "0x4004FEC")]
		[FieldOffset(Offset = "0x0")]
		private static AdsManager _I;

		// Token: 0x04004FED RID: 20461
		[Token(Token = "0x4004FED")]
		[FieldOffset(Offset = "0x10")]
		private Action<string> _Log;

		// Token: 0x04004FEE RID: 20462
		[Token(Token = "0x4004FEE")]
		[FieldOffset(Offset = "0x18")]
		private Action<string> _LogError;

		// Token: 0x02001070 RID: 4208
		[Token(Token = "0x2001070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAAB4", Offset = "0x10EAAB4")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x0600404F RID: 16463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600404F")]
			[Address(RVA = "0x25D74A4", Offset = "0x25D74A4", VA = "0x7BBCDD74A4")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06004050 RID: 16464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004050")]
			[Address(RVA = "0x25D75B0", Offset = "0x25D75B0", VA = "0x7BBCDD75B0")]
			internal void <Log>b__0()
			{
			}

			// Token: 0x04004FEF RID: 20463
			[Token(Token = "0x4004FEF")]
			[FieldOffset(Offset = "0x10")]
			public AdsManager <>4__this;

			// Token: 0x04004FF0 RID: 20464
			[Token(Token = "0x4004FF0")]
			[FieldOffset(Offset = "0x18")]
			public string content;
		}

		// Token: 0x02001071 RID: 4209
		[Token(Token = "0x2001071")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAAC4", Offset = "0x10EAAC4")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06004051 RID: 16465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004051")]
			[Address(RVA = "0x25D75A8", Offset = "0x25D75A8", VA = "0x7BBCDD75A8")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06004052 RID: 16466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004052")]
			[Address(RVA = "0x25D7628", Offset = "0x25D7628", VA = "0x7BBCDD7628")]
			internal void <LogError>b__0()
			{
			}

			// Token: 0x04004FF1 RID: 20465
			[Token(Token = "0x4004FF1")]
			[FieldOffset(Offset = "0x10")]
			public AdsManager <>4__this;

			// Token: 0x04004FF2 RID: 20466
			[Token(Token = "0x4004FF2")]
			[FieldOffset(Offset = "0x18")]
			public string content;
		}
	}
}
