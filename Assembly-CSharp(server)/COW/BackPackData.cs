using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010C7 RID: 4295
	[Token(Token = "0x20010C7")]
	public class BackPackData : CSVBaseData, IGetId
	{
		// Token: 0x060042F3 RID: 17139 RVA: 0x000149D0 File Offset: 0x00012BD0
		[Token(Token = "0x60042F3")]
		[Address(RVA = "0x21CB6FC", Offset = "0x21CB6FC", VA = "0x7BBC9CB6FC", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F4")]
		[Address(RVA = "0x21CB704", Offset = "0x21CB704", VA = "0x7BBC9CB704", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F5")]
		[Address(RVA = "0x21CB710", Offset = "0x21CB710", VA = "0x7BBC9CB710", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F6")]
		[Address(RVA = "0x21CC65C", Offset = "0x21CC65C", VA = "0x7BBC9CC65C")]
		public string GetCollectionRecipe(bool female, bool useHQ, uint level)
		{
			return null;
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x000149E8 File Offset: 0x00012BE8
		[Token(Token = "0x60042F7")]
		[Address(RVA = "0x21CC744", Offset = "0x21CC744", VA = "0x7BBC9CC744")]
		public ResourceID GetPreviewResourceIDByLevel(ECollectionLevel level)
		{
			return default(ResourceID);
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F8")]
		[Address(RVA = "0x21CC7EC", Offset = "0x21CC7EC", VA = "0x7BBC9CC7EC")]
		public BackPackData()
		{
		}

		// Token: 0x0400522F RID: 21039
		[Token(Token = "0x400522F")]
		[FieldOffset(Offset = "0x10")]
		public string[] maleRecipes;

		// Token: 0x04005230 RID: 21040
		[Token(Token = "0x4005230")]
		[FieldOffset(Offset = "0x18")]
		public string[] maleRecipes_N;

		// Token: 0x04005231 RID: 21041
		[Token(Token = "0x4005231")]
		[FieldOffset(Offset = "0x20")]
		public string[] femaleRecipes;

		// Token: 0x04005232 RID: 21042
		[Token(Token = "0x4005232")]
		[FieldOffset(Offset = "0x28")]
		public string[] femaleRecipes_N;

		// Token: 0x04005233 RID: 21043
		[Token(Token = "0x4005233")]
		[FieldOffset(Offset = "0x30")]
		public uint iID;

		// Token: 0x04005234 RID: 21044
		[Token(Token = "0x4005234")]
		[FieldOffset(Offset = "0x34")]
		public uint sortId;

		// Token: 0x04005235 RID: 21045
		[Token(Token = "0x4005235")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID previewResLV1;

		// Token: 0x04005236 RID: 21046
		[Token(Token = "0x4005236")]
		[FieldOffset(Offset = "0x3C")]
		public ResourceID previewResLV2;

		// Token: 0x04005237 RID: 21047
		[Token(Token = "0x4005237")]
		[FieldOffset(Offset = "0x40")]
		public ResourceID previewResLV3;

		// Token: 0x04005238 RID: 21048
		[Token(Token = "0x4005238")]
		[FieldOffset(Offset = "0x44")]
		public ResourceID FeMaleIngameEffectLV3;

		// Token: 0x04005239 RID: 21049
		[Token(Token = "0x4005239")]
		[FieldOffset(Offset = "0x48")]
		public ResourceID MaleIngameEffectLV3;

		// Token: 0x0400523A RID: 21050
		[Token(Token = "0x400523A")]
		[FieldOffset(Offset = "0x4C")]
		public ResourceID ModleIDM;

		// Token: 0x0400523B RID: 21051
		[Token(Token = "0x400523B")]
		[FieldOffset(Offset = "0x50")]
		public ResourceID ModleIDF;

		// Token: 0x0400523C RID: 21052
		[Token(Token = "0x400523C")]
		[FieldOffset(Offset = "0x54")]
		public ResourceID LowModleIDM;

		// Token: 0x0400523D RID: 21053
		[Token(Token = "0x400523D")]
		[FieldOffset(Offset = "0x58")]
		public ResourceID LowModleIDF;

		// Token: 0x0400523E RID: 21054
		[Token(Token = "0x400523E")]
		[FieldOffset(Offset = "0x5C")]
		public ESourceType sourceTypeKey;

		// Token: 0x0400523F RID: 21055
		[Token(Token = "0x400523F")]
		[FieldOffset(Offset = "0x5D")]
		public bool IsEffectsTrigger;
	}
}
