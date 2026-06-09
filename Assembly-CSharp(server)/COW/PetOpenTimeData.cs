using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001162 RID: 4450
	[Token(Token = "0x2001162")]
	public class PetOpenTimeData : CSVBaseData
	{
		// Token: 0x06004551 RID: 17745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004551")]
		[Address(RVA = "0x20516B4", Offset = "0x20516B4", VA = "0x7BBC8516B4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004552")]
		[Address(RVA = "0x204EB00", Offset = "0x204EB00", VA = "0x7BBC84EB00")]
		public static string GenerateKey(uint petID, string region)
		{
			return null;
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004553")]
		[Address(RVA = "0x2051714", Offset = "0x2051714", VA = "0x7BBC851714", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004554")]
		[Address(RVA = "0x205182C", Offset = "0x205182C", VA = "0x7BBC85182C")]
		public PetOpenTimeData()
		{
		}

		// Token: 0x0400562A RID: 22058
		[Token(Token = "0x400562A")]
		[FieldOffset(Offset = "0x10")]
		public DateTime OpenTime;

		// Token: 0x0400562B RID: 22059
		[Token(Token = "0x400562B")]
		[FieldOffset(Offset = "0x18")]
		public string Region;

		// Token: 0x0400562C RID: 22060
		[Token(Token = "0x400562C")]
		[FieldOffset(Offset = "0x20")]
		public uint PetID;
	}
}
