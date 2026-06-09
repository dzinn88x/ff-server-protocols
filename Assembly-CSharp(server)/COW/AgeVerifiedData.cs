using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200108F RID: 4239
	[Token(Token = "0x200108F")]
	public class AgeVerifiedData : CsvDataIndexedReading
	{
		// Token: 0x06004148 RID: 16712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004148")]
		[Address(RVA = "0x154B7C0", Offset = "0x154B7C0", VA = "0x7BBBD4B7C0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004149")]
		[Address(RVA = "0x154B7C8", Offset = "0x154B7C8", VA = "0x7BBBD4B7C8", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414A")]
		[Address(RVA = "0x154B920", Offset = "0x154B920", VA = "0x7BBBD4B920", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414B")]
		[Address(RVA = "0x154BB98", Offset = "0x154BB98", VA = "0x7BBBD4BB98")]
		public AgeVerifiedData()
		{
		}

		// Token: 0x040050A7 RID: 20647
		[Token(Token = "0x40050A7")]
		[FieldOffset(Offset = "0x10")]
		public string Country;

		// Token: 0x040050A8 RID: 20648
		[Token(Token = "0x40050A8")]
		[FieldOffset(Offset = "0x18")]
		public uint Platform;

		// Token: 0x040050A9 RID: 20649
		[Token(Token = "0x40050A9")]
		[FieldOffset(Offset = "0x1C")]
		public uint Age;
	}
}
