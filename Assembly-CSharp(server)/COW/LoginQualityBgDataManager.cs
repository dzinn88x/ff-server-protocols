using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001134 RID: 4404
	[Token(Token = "0x2001134")]
	public class LoginQualityBgDataManager : SingletonModule<LoginQualityBgDataManager>
	{
		// Token: 0x060044D0 RID: 17616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D0")]
		[Address(RVA = "0x1A544F0", Offset = "0x1A544F0", VA = "0x7BBC2544F0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D1")]
		[Address(RVA = "0x1A545A4", Offset = "0x1A545A4", VA = "0x7BBC2545A4", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044D2")]
		[Address(RVA = "0x1A545AC", Offset = "0x1A545AC", VA = "0x7BBC2545AC")]
		public LoginQualityBgData GetQualityDataByCountryCode(string CountryCode)
		{
			return null;
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044D3")]
		[Address(RVA = "0x1A54684", Offset = "0x1A54684", VA = "0x7BBC254684")]
		public LoginQualityBgData GetQualityDataById(int LoginId)
		{
			return null;
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D4")]
		[Address(RVA = "0x1A5475C", Offset = "0x1A5475C", VA = "0x7BBC25475C")]
		public LoginQualityBgDataManager()
		{
		}

		// Token: 0x040054F8 RID: 21752
		[Token(Token = "0x40054F8")]
		[FieldOffset(Offset = "0x18")]
		public List<LoginQualityBgData> m_QulityBgList;

		// Token: 0x02001135 RID: 4405
		[Token(Token = "0x2001135")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAC74", Offset = "0x10EAC74")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x060044D5 RID: 17621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60044D5")]
			[Address(RVA = "0x1A5467C", Offset = "0x1A5467C", VA = "0x7BBC25467C")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x060044D6 RID: 17622 RVA: 0x00015108 File Offset: 0x00013308
			[Token(Token = "0x60044D6")]
			[Address(RVA = "0x1A547CC", Offset = "0x1A547CC", VA = "0x7BBC2547CC")]
			internal bool <GetQualityDataByCountryCode>b__0(LoginQualityBgData x)
			{
				return default(bool);
			}

			// Token: 0x040054F9 RID: 21753
			[Token(Token = "0x40054F9")]
			[FieldOffset(Offset = "0x10")]
			public string CountryCode;
		}

		// Token: 0x02001136 RID: 4406
		[Token(Token = "0x2001136")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAC84", Offset = "0x10EAC84")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x060044D7 RID: 17623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60044D7")]
			[Address(RVA = "0x1A54754", Offset = "0x1A54754", VA = "0x7BBC254754")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x060044D8 RID: 17624 RVA: 0x00015120 File Offset: 0x00013320
			[Token(Token = "0x60044D8")]
			[Address(RVA = "0x1A54804", Offset = "0x1A54804", VA = "0x7BBC254804")]
			internal bool <GetQualityDataById>b__0(LoginQualityBgData x)
			{
				return default(bool);
			}

			// Token: 0x040054FA RID: 21754
			[Token(Token = "0x40054FA")]
			[FieldOffset(Offset = "0x10")]
			public int LoginId;
		}
	}
}
