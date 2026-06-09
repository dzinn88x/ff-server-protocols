using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CE8 RID: 7400
	[Token(Token = "0x2001CE8")]
	public class NationFlagDataManager : SingletonModule<NationFlagDataManager>
	{
		// Token: 0x0600A170 RID: 41328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A170")]
		[Address(RVA = "0x1A5DE90", Offset = "0x1A5DE90", VA = "0x7BBC25DE90", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A171 RID: 41329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A171")]
		[Address(RVA = "0x1A5DEF0", Offset = "0x1A5DEF0", VA = "0x7BBC25DEF0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A172 RID: 41330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A172")]
		[Address(RVA = "0x1A5E120", Offset = "0x1A5E120", VA = "0x7BBC25E120")]
		public List<NationFlagData> Datas()
		{
			return null;
		}

		// Token: 0x0600A173 RID: 41331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A173")]
		[Address(RVA = "0x1A5E128", Offset = "0x1A5E128", VA = "0x7BBC25E128")]
		public List<NationFlagData> OpenedDatas()
		{
			return null;
		}

		// Token: 0x0600A174 RID: 41332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A174")]
		[Address(RVA = "0x1A5E228", Offset = "0x1A5E228", VA = "0x7BBC25E228")]
		public NationFlagData Get(string countryOrArea)
		{
			return null;
		}

		// Token: 0x0600A175 RID: 41333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A175")]
		[Address(RVA = "0x1A5E340", Offset = "0x1A5E340", VA = "0x7BBC25E340")]
		public NationFlagData GetWithDefault(string countryOrArea)
		{
			return null;
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A176")]
		[Address(RVA = "0x1A5E418", Offset = "0x1A5E418", VA = "0x7BBC25E418")]
		public NationFlagDataManager()
		{
		}

		// Token: 0x0400A7F2 RID: 42994
		[Token(Token = "0x400A7F2")]
		[FieldOffset(Offset = "0x18")]
		private List<NationFlagData> m_datas;

		// Token: 0x0400A7F3 RID: 42995
		[Token(Token = "0x400A7F3")]
		public const string DEFAULT_FLAG = "A_DEFAULT";

		// Token: 0x02001CE9 RID: 7401
		[Token(Token = "0x2001CE9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBA74", Offset = "0x10FBA74")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A178 RID: 41336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A178")]
			[Address(RVA = "0x1A5E514", Offset = "0x1A5E514", VA = "0x7BBC25E514")]
			public <>c()
			{
			}

			// Token: 0x0600A179 RID: 41337 RVA: 0x0002A600 File Offset: 0x00028800
			[Token(Token = "0x600A179")]
			[Address(RVA = "0x1A5E51C", Offset = "0x1A5E51C", VA = "0x7BBC25E51C")]
			internal bool <OnInit>b__3_0(NationFlagData e)
			{
				return default(bool);
			}

			// Token: 0x0600A17A RID: 41338 RVA: 0x0002A618 File Offset: 0x00028818
			[Token(Token = "0x600A17A")]
			[Address(RVA = "0x1A5E550", Offset = "0x1A5E550", VA = "0x7BBC25E550")]
			internal int <OnInit>b__3_1(NationFlagData e, NationFlagData o)
			{
				return 0;
			}

			// Token: 0x0600A17B RID: 41339 RVA: 0x0002A630 File Offset: 0x00028830
			[Token(Token = "0x600A17B")]
			[Address(RVA = "0x1A5E678", Offset = "0x1A5E678", VA = "0x7BBC25E678")]
			internal bool <OpenedDatas>b__5_0(NationFlagData e)
			{
				return default(bool);
			}

			// Token: 0x0400A7F4 RID: 42996
			[Token(Token = "0x400A7F4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly NationFlagDataManager.<>c <>9;

			// Token: 0x0400A7F5 RID: 42997
			[Token(Token = "0x400A7F5")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<NationFlagData> <>9__3_0;

			// Token: 0x0400A7F6 RID: 42998
			[Token(Token = "0x400A7F6")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<NationFlagData> <>9__3_1;

			// Token: 0x0400A7F7 RID: 42999
			[Token(Token = "0x400A7F7")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<NationFlagData> <>9__5_0;
		}

		// Token: 0x02001CEA RID: 7402
		[Token(Token = "0x2001CEA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBA84", Offset = "0x10FBA84")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x0600A17C RID: 41340 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A17C")]
			[Address(RVA = "0x1A5E338", Offset = "0x1A5E338", VA = "0x7BBC25E338")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0600A17D RID: 41341 RVA: 0x0002A648 File Offset: 0x00028848
			[Token(Token = "0x600A17D")]
			[Address(RVA = "0x1A5E6A4", Offset = "0x1A5E6A4", VA = "0x7BBC25E6A4")]
			internal bool <Get>b__0(NationFlagData e)
			{
				return default(bool);
			}

			// Token: 0x0400A7F8 RID: 43000
			[Token(Token = "0x400A7F8")]
			[FieldOffset(Offset = "0x10")]
			public string countryOrArea;
		}

		// Token: 0x02001CEB RID: 7403
		[Token(Token = "0x2001CEB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBA94", Offset = "0x10FBA94")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x0600A17E RID: 41342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A17E")]
			[Address(RVA = "0x1A5E410", Offset = "0x1A5E410", VA = "0x7BBC25E410")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x0600A17F RID: 41343 RVA: 0x0002A660 File Offset: 0x00028860
			[Token(Token = "0x600A17F")]
			[Address(RVA = "0x1A5E6DC", Offset = "0x1A5E6DC", VA = "0x7BBC25E6DC")]
			internal bool <GetWithDefault>b__0(NationFlagData e)
			{
				return default(bool);
			}

			// Token: 0x0400A7F9 RID: 43001
			[Token(Token = "0x400A7F9")]
			[FieldOffset(Offset = "0x10")]
			public string countryOrArea;
		}
	}
}
