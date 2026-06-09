using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001166 RID: 4454
	[Token(Token = "0x2001166")]
	public class PetSkinData : CSVBaseData
	{
		// Token: 0x06004560 RID: 17760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004560")]
		[Address(RVA = "0x20522F4", Offset = "0x20522F4", VA = "0x7BBC8522F4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004561")]
		[Address(RVA = "0x2052300", Offset = "0x2052300", VA = "0x7BBC852300", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004562")]
		[Address(RVA = "0x2052604", Offset = "0x2052604", VA = "0x7BBC852604")]
		public PetSkinData()
		{
		}

		// Token: 0x04005642 RID: 22082
		[Token(Token = "0x4005642")]
		[FieldOffset(Offset = "0x10")]
		public uint SkinID;

		// Token: 0x04005643 RID: 22083
		[Token(Token = "0x4005643")]
		[FieldOffset(Offset = "0x14")]
		public int PetID;

		// Token: 0x04005644 RID: 22084
		[Token(Token = "0x4005644")]
		[FieldOffset(Offset = "0x18")]
		public int PetLevel;

		// Token: 0x04005645 RID: 22085
		[Token(Token = "0x4005645")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID UISkinPrefab;

		// Token: 0x04005646 RID: 22086
		[Token(Token = "0x4005646")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID IngameSkinPrefab;

		// Token: 0x04005647 RID: 22087
		[Token(Token = "0x4005647")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID IngameSkinPrefab3P;

		// Token: 0x04005648 RID: 22088
		[Token(Token = "0x4005648")]
		[FieldOffset(Offset = "0x28")]
		public bool OverrideShowHideEffect;

		// Token: 0x04005649 RID: 22089
		[Token(Token = "0x4005649")]
		[FieldOffset(Offset = "0x2C")]
		public ResourceID ShowHideEffect;
	}
}
