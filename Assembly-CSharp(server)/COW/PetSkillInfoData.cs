using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001164 RID: 4452
	[Token(Token = "0x2001164")]
	public class PetSkillInfoData : CSVBaseData
	{
		// Token: 0x06004558 RID: 17752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004558")]
		[Address(RVA = "0x2051C8C", Offset = "0x2051C8C", VA = "0x7BBC851C8C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004559")]
		[Address(RVA = "0x2051C98", Offset = "0x2051C98", VA = "0x7BBC851C98", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455A")]
		[Address(RVA = "0x2051DFC", Offset = "0x2051DFC", VA = "0x7BBC851DFC")]
		public PetSkillInfoData()
		{
		}

		// Token: 0x04005630 RID: 22064
		[Token(Token = "0x4005630")]
		[FieldOffset(Offset = "0x10")]
		public int SkillID;

		// Token: 0x04005631 RID: 22065
		[Token(Token = "0x4005631")]
		[FieldOffset(Offset = "0x14")]
		public int SourceType;

		// Token: 0x04005632 RID: 22066
		[Token(Token = "0x4005632")]
		[FieldOffset(Offset = "0x18")]
		public int SourcePetID;

		// Token: 0x04005633 RID: 22067
		[Token(Token = "0x4005633")]
		[FieldOffset(Offset = "0x20")]
		public uint[] PetIDList;

		// Token: 0x04005634 RID: 22068
		[Token(Token = "0x4005634")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID Icon;
	}
}
