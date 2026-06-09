using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200109D RID: 4253
	[Token(Token = "0x200109D")]
	public class AvatarHDRecipeData : CSVBaseData
	{
		// Token: 0x060041A6 RID: 16806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A6")]
		[Address(RVA = "0x1561F74", Offset = "0x1561F74", VA = "0x7BBBD61F74", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A7")]
		[Address(RVA = "0x1561F7C", Offset = "0x1561F7C", VA = "0x7BBBD61F7C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A8")]
		[Address(RVA = "0x1562034", Offset = "0x1562034", VA = "0x7BBBD62034")]
		public AvatarHDRecipeData()
		{
		}

		// Token: 0x040050FD RID: 20733
		[Token(Token = "0x40050FD")]
		[FieldOffset(Offset = "0x10")]
		public string defaultRecipe;

		// Token: 0x040050FE RID: 20734
		[Token(Token = "0x40050FE")]
		[FieldOffset(Offset = "0x18")]
		public string HDRecipe;
	}
}
