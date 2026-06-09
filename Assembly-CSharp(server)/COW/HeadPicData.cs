using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010C5 RID: 4293
	[Token(Token = "0x20010C5")]
	public class HeadPicData : CSVBaseData, IGetId
	{
		// Token: 0x060042EB RID: 17131 RVA: 0x000149A0 File Offset: 0x00012BA0
		[Token(Token = "0x60042EB")]
		[Address(RVA = "0x18586B4", Offset = "0x18586B4", VA = "0x7BBC0586B4", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EC")]
		[Address(RVA = "0x18586BC", Offset = "0x18586BC", VA = "0x7BBC0586BC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042ED")]
		[Address(RVA = "0x18586C8", Offset = "0x18586C8", VA = "0x7BBC0586C8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042EE")]
		[Address(RVA = "0x185892C", Offset = "0x185892C", VA = "0x7BBC05892C")]
		public HeadPicData()
		{
		}

		// Token: 0x04005221 RID: 21025
		[Token(Token = "0x4005221")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x04005222 RID: 21026
		[Token(Token = "0x4005222")]
		[FieldOffset(Offset = "0x14")]
		public uint sortId;

		// Token: 0x04005223 RID: 21027
		[Token(Token = "0x4005223")]
		[FieldOffset(Offset = "0x18")]
		public uint avatarID;

		// Token: 0x04005224 RID: 21028
		[Token(Token = "0x4005224")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID iconRes;

		// Token: 0x04005225 RID: 21029
		[Token(Token = "0x4005225")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID effectRes;

		// Token: 0x04005226 RID: 21030
		[Token(Token = "0x4005226")]
		[FieldOffset(Offset = "0x24")]
		public ESourceType sourceTypeKey;
	}
}
