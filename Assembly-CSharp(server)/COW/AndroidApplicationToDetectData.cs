using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001092 RID: 4242
	[Token(Token = "0x2001092")]
	public class AndroidApplicationToDetectData : CSVBaseData
	{
		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x000140B8 File Offset: 0x000122B8
		// (set) Token: 0x06004152 RID: 16722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077C")]
		public int ID
		{
			[Token(Token = "0x6004151")]
			[Address(RVA = "0x154C814", Offset = "0x154C814", VA = "0x7BBBD4C814")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C6B8", Offset = "0x113C6B8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004152")]
			[Address(RVA = "0x154C81C", Offset = "0x154C81C", VA = "0x7BBBD4C81C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C6C8", Offset = "0x113C6C8")]
			private set
			{
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004154 RID: 16724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077D")]
		public string BundleIdentifier
		{
			[Token(Token = "0x6004153")]
			[Address(RVA = "0x154C824", Offset = "0x154C824", VA = "0x7BBBD4C824")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C6D8", Offset = "0x113C6D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004154")]
			[Address(RVA = "0x154C82C", Offset = "0x154C82C", VA = "0x7BBBD4C82C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C6E8", Offset = "0x113C6E8")]
			private set
			{
			}
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004155")]
		[Address(RVA = "0x154C834", Offset = "0x154C834", VA = "0x7BBBD4C834", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004156")]
		[Address(RVA = "0x154C83C", Offset = "0x154C83C", VA = "0x7BBBD4C83C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004157")]
		[Address(RVA = "0x154C904", Offset = "0x154C904", VA = "0x7BBBD4C904")]
		public AndroidApplicationToDetectData()
		{
		}

		// Token: 0x040050B0 RID: 20656
		[Token(Token = "0x40050B0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EC6C", Offset = "0x112EC6C")]
		private int <ID>k__BackingField;

		// Token: 0x040050B1 RID: 20657
		[Token(Token = "0x40050B1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EC7C", Offset = "0x112EC7C")]
		private string <BundleIdentifier>k__BackingField;
	}
}
