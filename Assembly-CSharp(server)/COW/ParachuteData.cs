using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010C8 RID: 4296
	[Token(Token = "0x20010C8")]
	public class ParachuteData : CSVBaseData, IGetId
	{
		// Token: 0x060042F9 RID: 17145 RVA: 0x00014A00 File Offset: 0x00012C00
		[Token(Token = "0x60042F9")]
		[Address(RVA = "0x203DA38", Offset = "0x203DA38", VA = "0x7BBC83DA38", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FA")]
		[Address(RVA = "0x203DA40", Offset = "0x203DA40", VA = "0x7BBC83DA40", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042FB")]
		[Address(RVA = "0x203DA4C", Offset = "0x203DA4C", VA = "0x7BBC83DA4C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042FC")]
		[Address(RVA = "0x203DCF8", Offset = "0x203DCF8", VA = "0x7BBC83DCF8")]
		public ParachuteData()
		{
		}

		// Token: 0x04005240 RID: 21056
		[Token(Token = "0x4005240")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x04005241 RID: 21057
		[Token(Token = "0x4005241")]
		[FieldOffset(Offset = "0x14")]
		public uint sortId;

		// Token: 0x04005242 RID: 21058
		[Token(Token = "0x4005242")]
		[FieldOffset(Offset = "0x18")]
		public ResourceID previewRes;

		// Token: 0x04005243 RID: 21059
		[Token(Token = "0x4005243")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID inGameRes;

		// Token: 0x04005244 RID: 21060
		[Token(Token = "0x4005244")]
		[FieldOffset(Offset = "0x20")]
		public ESourceType sourceTypeKey;
	}
}
