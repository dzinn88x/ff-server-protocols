using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020010AE RID: 4270
	[Token(Token = "0x20010AE")]
	public class BanReasonDataManager : SingletonModule<BanReasonDataManager>
	{
		// Token: 0x0600429F RID: 17055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429F")]
		[Address(RVA = "0x21CCB7C", Offset = "0x21CCB7C", VA = "0x7BBC9CCB7C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A0")]
		[Address(RVA = "0x21CCC74", Offset = "0x21CCC74", VA = "0x7BBC9CCC74", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A1")]
		[Address(RVA = "0x21CCCEC", Offset = "0x21CCCEC", VA = "0x7BBC9CCCEC")]
		public string GetBanReasonDesc(EAccount.BanReason reasonId, uint timeStamp)
		{
			return null;
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A2")]
		[Address(RVA = "0x21CCEE8", Offset = "0x21CCEE8", VA = "0x7BBC9CCEE8")]
		public string GetBanReasonUrl(EAccount.BanReason reasonId)
		{
			return null;
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A3")]
		[Address(RVA = "0x21CD118", Offset = "0x21CD118", VA = "0x7BBC9CD118")]
		public string GetDefaultUrl(EAccount.BanReason reasonId)
		{
			return null;
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x000148B0 File Offset: 0x00012AB0
		[Token(Token = "0x60042A4")]
		[Address(RVA = "0x21CCECC", Offset = "0x21CCECC", VA = "0x7BBC9CCECC")]
		private EAccount.BanReason ModifyBanReason(EAccount.BanReason banReason)
		{
			return EAccount.BanReason.BanReason_UNKNOWN;
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A5")]
		[Address(RVA = "0x21CD3A4", Offset = "0x21CD3A4", VA = "0x7BBC9CD3A4")]
		public BanReasonDataManager()
		{
		}

		// Token: 0x040051A8 RID: 20904
		[Token(Token = "0x40051A8")]
		[FieldOffset(Offset = "0x18")]
		public List<BanReasonData> m_BanReasonDataList;

		// Token: 0x040051A9 RID: 20905
		[Token(Token = "0x40051A9")]
		[FieldOffset(Offset = "0x20")]
		public List<BanInfoUrlData> m_BanInfoUrlDataList;

		// Token: 0x020010AF RID: 4271
		[Token(Token = "0x20010AF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EABD4", Offset = "0x10EABD4")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x060042A6 RID: 17062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042A6")]
			[Address(RVA = "0x21CCEC4", Offset = "0x21CCEC4", VA = "0x7BBC9CCEC4")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x060042A7 RID: 17063 RVA: 0x000148C8 File Offset: 0x00012AC8
			[Token(Token = "0x60042A7")]
			[Address(RVA = "0x21CD4B4", Offset = "0x21CD4B4", VA = "0x7BBC9CD4B4")]
			internal bool <GetBanReasonDesc>b__0(BanReasonData x)
			{
				return default(bool);
			}

			// Token: 0x040051AA RID: 20906
			[Token(Token = "0x40051AA")]
			[FieldOffset(Offset = "0x10")]
			public EAccount.BanReason reasonId;

			// Token: 0x040051AB RID: 20907
			[Token(Token = "0x40051AB")]
			[FieldOffset(Offset = "0x14")]
			public bool timeLimited;
		}

		// Token: 0x020010B0 RID: 4272
		[Token(Token = "0x20010B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EABE4", Offset = "0x10EABE4")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x060042A8 RID: 17064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042A8")]
			[Address(RVA = "0x21CD110", Offset = "0x21CD110", VA = "0x7BBC9CD110")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x060042A9 RID: 17065 RVA: 0x000148E0 File Offset: 0x00012AE0
			[Token(Token = "0x60042A9")]
			[Address(RVA = "0x21CD518", Offset = "0x21CD518", VA = "0x7BBC9CD518")]
			internal bool <GetBanReasonUrl>b__0(BanInfoUrlData x)
			{
				return default(bool);
			}

			// Token: 0x040051AC RID: 20908
			[Token(Token = "0x40051AC")]
			[FieldOffset(Offset = "0x10")]
			public EAccount.BanReason reasonId;

			// Token: 0x040051AD RID: 20909
			[Token(Token = "0x40051AD")]
			[FieldOffset(Offset = "0x18")]
			public string Country;
		}

		// Token: 0x020010B1 RID: 4273
		[Token(Token = "0x20010B1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EABF4", Offset = "0x10EABF4")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x060042AA RID: 17066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042AA")]
			[Address(RVA = "0x21CD39C", Offset = "0x21CD39C", VA = "0x7BBC9CD39C")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x060042AB RID: 17067 RVA: 0x000148F8 File Offset: 0x00012AF8
			[Token(Token = "0x60042AB")]
			[Address(RVA = "0x21CD584", Offset = "0x21CD584", VA = "0x7BBC9CD584")]
			internal bool <GetDefaultUrl>b__0(BanInfoUrlData x)
			{
				return default(bool);
			}

			// Token: 0x040051AE RID: 20910
			[Token(Token = "0x40051AE")]
			[FieldOffset(Offset = "0x10")]
			public EAccount.BanReason reasonId;
		}

		// Token: 0x020010B2 RID: 4274
		[Token(Token = "0x20010B2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAC04", Offset = "0x10EAC04")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060042AD RID: 17069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042AD")]
			[Address(RVA = "0x21CD478", Offset = "0x21CD478", VA = "0x7BBC9CD478")]
			public <>c()
			{
			}

			// Token: 0x060042AE RID: 17070 RVA: 0x00014910 File Offset: 0x00012B10
			[Token(Token = "0x60042AE")]
			[Address(RVA = "0x21CD480", Offset = "0x21CD480", VA = "0x7BBC9CD480")]
			internal bool <GetDefaultUrl>b__6_1(BanInfoUrlData x)
			{
				return default(bool);
			}

			// Token: 0x040051AF RID: 20911
			[Token(Token = "0x40051AF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly BanReasonDataManager.<>c <>9;

			// Token: 0x040051B0 RID: 20912
			[Token(Token = "0x40051B0")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<BanInfoUrlData> <>9__6_1;
		}
	}
}
