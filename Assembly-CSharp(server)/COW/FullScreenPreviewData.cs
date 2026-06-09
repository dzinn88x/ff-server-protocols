using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001100 RID: 4352
	[Token(Token = "0x2001100")]
	public class FullScreenPreviewData : CSVBaseData
	{
		// Token: 0x060043FE RID: 17406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043FE")]
		[Address(RVA = "0x1867D80", Offset = "0x1867D80", VA = "0x7BBC067D80", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043FF")]
		[Address(RVA = "0x1867D8C", Offset = "0x1867D8C", VA = "0x7BBC067D8C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004400")]
		[Address(RVA = "0x18680DC", Offset = "0x18680DC", VA = "0x7BBC0680DC")]
		public FullScreenPreviewData()
		{
		}

		// Token: 0x04005400 RID: 21504
		[Token(Token = "0x4005400")]
		[FieldOffset(Offset = "0x10")]
		public uint ItemID;

		// Token: 0x04005401 RID: 21505
		[Token(Token = "0x4005401")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 Position;

		// Token: 0x04005402 RID: 21506
		[Token(Token = "0x4005402")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 Rotation;

		// Token: 0x04005403 RID: 21507
		[Token(Token = "0x4005403")]
		[FieldOffset(Offset = "0x2C")]
		public float GlassPosY;
	}
}
