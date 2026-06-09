using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001140 RID: 4416
	[Token(Token = "0x2001140")]
	public class ManualChallenge : CSVBaseData
	{
		// Token: 0x060044F1 RID: 17649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F1")]
		[Address(RVA = "0x1A55D38", Offset = "0x1A55D38", VA = "0x7BBC255D38", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F2")]
		[Address(RVA = "0x1A55D44", Offset = "0x1A55D44", VA = "0x7BBC255D44", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F3")]
		[Address(RVA = "0x1A55E78", Offset = "0x1A55E78", VA = "0x7BBC255E78")]
		public ManualChallenge()
		{
		}

		// Token: 0x0400551B RID: 21787
		[Token(Token = "0x400551B")]
		[FieldOffset(Offset = "0x10")]
		public uint m_EventID;

		// Token: 0x0400551C RID: 21788
		[Token(Token = "0x400551C")]
		[FieldOffset(Offset = "0x14")]
		public uint m_Type;

		// Token: 0x0400551D RID: 21789
		[Token(Token = "0x400551D")]
		[FieldOffset(Offset = "0x18")]
		public uint m_Param1;

		// Token: 0x0400551E RID: 21790
		[Token(Token = "0x400551E")]
		[FieldOffset(Offset = "0x1C")]
		public uint m_Param2;

		// Token: 0x0400551F RID: 21791
		[Token(Token = "0x400551F")]
		[FieldOffset(Offset = "0x20")]
		public string EventDesc;
	}
}
