using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001091 RID: 4241
	[Token(Token = "0x2001091")]
	public class AIClientData : CSVBaseData
	{
		// Token: 0x0600414E RID: 16718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414E")]
		[Address(RVA = "0x1F97C50", Offset = "0x1F97C50", VA = "0x7BBC797C50", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414F")]
		[Address(RVA = "0x1F97C5C", Offset = "0x1F97C5C", VA = "0x7BBC797C5C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004150")]
		[Address(RVA = "0x1F97DD4", Offset = "0x1F97DD4", VA = "0x7BBC797DD4")]
		public AIClientData()
		{
		}

		// Token: 0x040050AB RID: 20651
		[Token(Token = "0x40050AB")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x040050AC RID: 20652
		[Token(Token = "0x40050AC")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID InGameModel;

		// Token: 0x040050AD RID: 20653
		[Token(Token = "0x40050AD")]
		[FieldOffset(Offset = "0x18")]
		public float BaseWalkSpeed;

		// Token: 0x040050AE RID: 20654
		[Token(Token = "0x40050AE")]
		[FieldOffset(Offset = "0x1C")]
		public float BaseRunSpeed;

		// Token: 0x040050AF RID: 20655
		[Token(Token = "0x40050AF")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID[] TransformLevelModels;
	}
}
