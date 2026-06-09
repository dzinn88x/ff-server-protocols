using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010C6 RID: 4294
	[Token(Token = "0x20010C6")]
	public class LootBoxData : CSVBaseData, IGetId
	{
		// Token: 0x060042EF RID: 17135 RVA: 0x000149B8 File Offset: 0x00012BB8
		[Token(Token = "0x60042EF")]
		[Address(RVA = "0x1A5546C", Offset = "0x1A5546C", VA = "0x7BBC25546C", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F0")]
		[Address(RVA = "0x1A55474", Offset = "0x1A55474", VA = "0x7BBC255474", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F1")]
		[Address(RVA = "0x1A55480", Offset = "0x1A55480", VA = "0x7BBC255480", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F2")]
		[Address(RVA = "0x1A55840", Offset = "0x1A55840", VA = "0x7BBC255840")]
		public LootBoxData()
		{
		}

		// Token: 0x04005227 RID: 21031
		[Token(Token = "0x4005227")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x04005228 RID: 21032
		[Token(Token = "0x4005228")]
		[FieldOffset(Offset = "0x14")]
		public uint sortId;

		// Token: 0x04005229 RID: 21033
		[Token(Token = "0x4005229")]
		[FieldOffset(Offset = "0x18")]
		public ResourceID briefRes;

		// Token: 0x0400522A RID: 21034
		[Token(Token = "0x400522A")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID previewRes;

		// Token: 0x0400522B RID: 21035
		[Token(Token = "0x400522B")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID inGameRes;

		// Token: 0x0400522C RID: 21036
		[Token(Token = "0x400522C")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID inGameTexture;

		// Token: 0x0400522D RID: 21037
		[Token(Token = "0x400522D")]
		[FieldOffset(Offset = "0x28")]
		public ESourceType sourceTypeKey;

		// Token: 0x0400522E RID: 21038
		[Token(Token = "0x400522E")]
		[FieldOffset(Offset = "0x29")]
		public bool IsWithEffect;
	}
}
