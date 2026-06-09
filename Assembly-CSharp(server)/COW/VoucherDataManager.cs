using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002039 RID: 8249
	[Token(Token = "0x2002039")]
	internal class VoucherDataManager : SingletonModule<VoucherDataManager>
	{
		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x0600B7DB RID: 47067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB5")]
		public List<VoucherData> VoucherDataList
		{
			[Token(Token = "0x600B7DB")]
			[Address(RVA = "0x179B8B4", Offset = "0x179B8B4", VA = "0x7BBBF9B8B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B7DC RID: 47068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7DC")]
		[Address(RVA = "0x179B8BC", Offset = "0x179B8BC", VA = "0x7BBBF9B8BC", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600B7DD RID: 47069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7DD")]
		[Address(RVA = "0x179BA60", Offset = "0x179BA60", VA = "0x7BBBF9BA60", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600B7DE RID: 47070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7DE")]
		[Address(RVA = "0x179BAC8", Offset = "0x179BAC8", VA = "0x7BBBF9BAC8")]
		public VoucherData FindVoucherDataByID(uint id)
		{
			return null;
		}

		// Token: 0x0600B7DF RID: 47071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7DF")]
		[Address(RVA = "0x179BBA0", Offset = "0x179BBA0", VA = "0x7BBBF9BBA0")]
		public VoucherDataManager()
		{
		}

		// Token: 0x0400BA04 RID: 47620
		[Token(Token = "0x400BA04")]
		[FieldOffset(Offset = "0x18")]
		private List<VoucherData> m_VoucherDataList;

		// Token: 0x0200203A RID: 8250
		[Token(Token = "0x200203A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD8B4", Offset = "0x10FD8B4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B7E1 RID: 47073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7E1")]
			[Address(RVA = "0x179BC9C", Offset = "0x179BC9C", VA = "0x7BBBF9BC9C")]
			public <>c()
			{
			}

			// Token: 0x0600B7E2 RID: 47074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B7E2")]
			[Address(RVA = "0x179BCA4", Offset = "0x179BCA4", VA = "0x7BBBF9BCA4")]
			internal VoucherData <OnInit>b__3_0(CSVBaseData data)
			{
				return null;
			}

			// Token: 0x0400BA05 RID: 47621
			[Token(Token = "0x400BA05")]
			[FieldOffset(Offset = "0x0")]
			public static readonly VoucherDataManager.<>c <>9;

			// Token: 0x0400BA06 RID: 47622
			[Token(Token = "0x400BA06")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<CSVBaseData, VoucherData> <>9__3_0;
		}

		// Token: 0x0200203B RID: 8251
		[Token(Token = "0x200203B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD8C4", Offset = "0x10FD8C4")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x0600B7E3 RID: 47075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7E3")]
			[Address(RVA = "0x179BB98", Offset = "0x179BB98", VA = "0x7BBBF9BB98")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x0600B7E4 RID: 47076 RVA: 0x00034950 File Offset: 0x00032B50
			[Token(Token = "0x600B7E4")]
			[Address(RVA = "0x179BD24", Offset = "0x179BD24", VA = "0x7BBBF9BD24")]
			internal bool <FindVoucherDataByID>b__0(VoucherData data)
			{
				return default(bool);
			}

			// Token: 0x0400BA07 RID: 47623
			[Token(Token = "0x400BA07")]
			[FieldOffset(Offset = "0x10")]
			public uint id;
		}
	}
}
