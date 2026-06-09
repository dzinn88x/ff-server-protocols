using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001149 RID: 4425
	[Token(Token = "0x2001149")]
	public class ModePageLiveEffectsData : CSVBaseData
	{
		// Token: 0x0600450F RID: 17679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450F")]
		[Address(RVA = "0x1A5D734", Offset = "0x1A5D734", VA = "0x7BBC25D734", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004510")]
		[Address(RVA = "0x1A5D740", Offset = "0x1A5D740", VA = "0x7BBC25D740", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004511")]
		[Address(RVA = "0x1A5DA24", Offset = "0x1A5DA24", VA = "0x7BBC25DA24")]
		public ModePageLiveEffectsData()
		{
		}

		// Token: 0x04005574 RID: 21876
		[Token(Token = "0x4005574")]
		[FieldOffset(Offset = "0x10")]
		public uint LiveEffectsID;

		// Token: 0x04005575 RID: 21877
		[Token(Token = "0x4005575")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID VFXResourceID;

		// Token: 0x04005576 RID: 21878
		[Token(Token = "0x4005576")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 LocalPosition;
	}
}
