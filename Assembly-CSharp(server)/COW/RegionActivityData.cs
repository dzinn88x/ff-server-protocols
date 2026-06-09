using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001278 RID: 4728
	[Token(Token = "0x2001278")]
	public class RegionActivityData : CSVBaseData
	{
		// Token: 0x06004930 RID: 18736 RVA: 0x000162D8 File Offset: 0x000144D8
		[Token(Token = "0x6004930")]
		[Address(RVA = "0x1752E30", Offset = "0x1752E30", VA = "0x7BBBF52E30")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004931")]
		[Address(RVA = "0x1752E38", Offset = "0x1752E38", VA = "0x7BBBF52E38", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004932")]
		[Address(RVA = "0x1752E44", Offset = "0x1752E44", VA = "0x7BBBF52E44", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004933")]
		[Address(RVA = "0x1752FD4", Offset = "0x1752FD4", VA = "0x7BBBF52FD4")]
		public RegionActivityData()
		{
		}

		// Token: 0x0400721A RID: 29210
		[Token(Token = "0x400721A")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x0400721B RID: 29211
		[Token(Token = "0x400721B")]
		[FieldOffset(Offset = "0x18")]
		public string StyleType;

		// Token: 0x0400721C RID: 29212
		[Token(Token = "0x400721C")]
		[FieldOffset(Offset = "0x20")]
		public int activityType;

		// Token: 0x0400721D RID: 29213
		[Token(Token = "0x400721D")]
		[FieldOffset(Offset = "0x24")]
		public int Priority;

		// Token: 0x0400721E RID: 29214
		[Token(Token = "0x400721E")]
		[FieldOffset(Offset = "0x28")]
		public string[] activityParams;
	}
}
