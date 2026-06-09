using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200118E RID: 4494
	[Token(Token = "0x200118E")]
	public class TaskData : CSVBaseData, IGetId
	{
		// Token: 0x060045F5 RID: 17909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F5")]
		[Address(RVA = "0x1B438E0", Offset = "0x1B438E0", VA = "0x7BBC3438E0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x00015300 File Offset: 0x00013500
		[Token(Token = "0x60045F6")]
		[Address(RVA = "0x1B438EC", Offset = "0x1B438EC", VA = "0x7BBC3438EC", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F7")]
		[Address(RVA = "0x1B438F4", Offset = "0x1B438F4", VA = "0x7BBC3438F4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F8")]
		[Address(RVA = "0x1B43BB8", Offset = "0x1B43BB8", VA = "0x7BBC343BB8")]
		public TaskData()
		{
		}

		// Token: 0x0400570A RID: 22282
		[Token(Token = "0x400570A")]
		[FieldOffset(Offset = "0x10")]
		public uint Id;

		// Token: 0x0400570B RID: 22283
		[Token(Token = "0x400570B")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID Icon;

		// Token: 0x0400570C RID: 22284
		[Token(Token = "0x400570C")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x0400570D RID: 22285
		[Token(Token = "0x400570D")]
		[FieldOffset(Offset = "0x20")]
		public string Desc;

		// Token: 0x0400570E RID: 22286
		[Token(Token = "0x400570E")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID Prefab;

		// Token: 0x0400570F RID: 22287
		[Token(Token = "0x400570F")]
		[FieldOffset(Offset = "0x2C")]
		public bool CanDoForbid;

		// Token: 0x04005710 RID: 22288
		[Token(Token = "0x4005710")]
		[FieldOffset(Offset = "0x30")]
		public string CivilAlert;

		// Token: 0x04005711 RID: 22289
		[Token(Token = "0x4005711")]
		[FieldOffset(Offset = "0x38")]
		public string WolfAlert;

		// Token: 0x04005712 RID: 22290
		[Token(Token = "0x4005712")]
		[FieldOffset(Offset = "0x40")]
		public int TaskGroup;
	}
}
