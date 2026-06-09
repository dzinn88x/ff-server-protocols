using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200113E RID: 4414
	[Token(Token = "0x200113E")]
	public class MailData : CSVBaseData
	{
		// Token: 0x060044EE RID: 17646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EE")]
		[Address(RVA = "0x1A55C0C", Offset = "0x1A55C0C", VA = "0x7BBC255C0C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044EF")]
		[Address(RVA = "0x1A55CC4", Offset = "0x1A55CC4", VA = "0x7BBC255CC4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F0")]
		[Address(RVA = "0x1A55CD0", Offset = "0x1A55CD0", VA = "0x7BBC255CD0")]
		public MailData()
		{
		}

		// Token: 0x04005510 RID: 21776
		[Token(Token = "0x4005510")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x04005511 RID: 21777
		[Token(Token = "0x4005511")]
		[FieldOffset(Offset = "0x14")]
		public int MaxMailNum;

		// Token: 0x04005512 RID: 21778
		[Token(Token = "0x4005512")]
		[FieldOffset(Offset = "0x18")]
		public int ExpireDays;
	}
}
