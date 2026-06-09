using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010A0 RID: 4256
	[Token(Token = "0x20010A0")]
	public class AvatarRecipeMappingData : CSVBaseData
	{
		// Token: 0x060041DC RID: 16860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DC")]
		[Address(RVA = "0x21BDD48", Offset = "0x21BDD48", VA = "0x7BBC9BDD48", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041DD")]
		[Address(RVA = "0x21BDD54", Offset = "0x21BDD54", VA = "0x7BBC9BDD54", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041DE")]
		[Address(RVA = "0x21BDE9C", Offset = "0x21BDE9C", VA = "0x7BBC9BDE9C")]
		public AvatarRecipeMappingData()
		{
		}

		// Token: 0x0400511B RID: 20763
		[Token(Token = "0x400511B")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x0400511C RID: 20764
		[Token(Token = "0x400511C")]
		[FieldOffset(Offset = "0x14")]
		public int TargetRecipeSlot;

		// Token: 0x0400511D RID: 20765
		[Token(Token = "0x400511D")]
		[FieldOffset(Offset = "0x18")]
		public string TargetRecipe;

		// Token: 0x0400511E RID: 20766
		[Token(Token = "0x400511E")]
		[FieldOffset(Offset = "0x20")]
		public int ConditionRecipeSlot;

		// Token: 0x0400511F RID: 20767
		[Token(Token = "0x400511F")]
		[FieldOffset(Offset = "0x28")]
		public string ConditionRecipe;

		// Token: 0x04005120 RID: 20768
		[Token(Token = "0x4005120")]
		[FieldOffset(Offset = "0x30")]
		public string ResultRecipe;
	}
}
