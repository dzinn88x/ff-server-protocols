using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001158 RID: 4440
	[Token(Token = "0x2001158")]
	public class PetActionData : CSVBaseData
	{
		// Token: 0x0600453F RID: 17727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453F")]
		[Address(RVA = "0x204E21C", Offset = "0x204E21C", VA = "0x7BBC84E21C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004540")]
		[Address(RVA = "0x204E228", Offset = "0x204E228", VA = "0x7BBC84E228", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004541")]
		[Address(RVA = "0x204E4A8", Offset = "0x204E4A8", VA = "0x7BBC84E4A8")]
		public PetActionData()
		{
		}

		// Token: 0x040055F0 RID: 22000
		[Token(Token = "0x40055F0")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x040055F1 RID: 22001
		[Token(Token = "0x40055F1")]
		[FieldOffset(Offset = "0x14")]
		public int Type;

		// Token: 0x040055F2 RID: 22002
		[Token(Token = "0x40055F2")]
		[FieldOffset(Offset = "0x18")]
		public float Time;

		// Token: 0x040055F3 RID: 22003
		[Token(Token = "0x40055F3")]
		[FieldOffset(Offset = "0x1C")]
		public int PetID;

		// Token: 0x040055F4 RID: 22004
		[Token(Token = "0x40055F4")]
		[FieldOffset(Offset = "0x20")]
		public int PetLevel;

		// Token: 0x040055F5 RID: 22005
		[Token(Token = "0x40055F5")]
		[FieldOffset(Offset = "0x28")]
		public string ResourceName;

		// Token: 0x040055F6 RID: 22006
		[Token(Token = "0x40055F6")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID ActionSound;

		// Token: 0x040055F7 RID: 22007
		[Token(Token = "0x40055F7")]
		[FieldOffset(Offset = "0x34")]
		public ResourceID ActionMoodSound;

		// Token: 0x040055F8 RID: 22008
		[Token(Token = "0x40055F8")]
		[FieldOffset(Offset = "0x38")]
		public bool IsActive;

		// Token: 0x040055F9 RID: 22009
		[Token(Token = "0x40055F9")]
		[FieldOffset(Offset = "0x3C")]
		public ResourceID AnimResource;

		// Token: 0x040055FA RID: 22010
		[Token(Token = "0x40055FA")]
		[FieldOffset(Offset = "0x40")]
		public ResourceID ActionVFX;
	}
}
