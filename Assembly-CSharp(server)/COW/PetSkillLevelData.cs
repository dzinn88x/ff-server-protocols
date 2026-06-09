using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001165 RID: 4453
	[Token(Token = "0x2001165")]
	public class PetSkillLevelData : CSVBaseData
	{
		// Token: 0x0600455B RID: 17755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455B")]
		[Address(RVA = "0x2051E64", Offset = "0x2051E64", VA = "0x7BBC851E64", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455C")]
		[Address(RVA = "0x204F040", Offset = "0x204F040", VA = "0x7BBC84F040")]
		public static string GenerateKey(int skillID, int SkillLevel)
		{
			return null;
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455D")]
		[Address(RVA = "0x2051ED8", Offset = "0x2051ED8", VA = "0x7BBC851ED8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455E")]
		[Address(RVA = "0x20521DC", Offset = "0x20521DC", VA = "0x7BBC8521DC")]
		private string AttachColor(string sourceStr)
		{
			return null;
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455F")]
		[Address(RVA = "0x205225C", Offset = "0x205225C", VA = "0x7BBC85225C")]
		public PetSkillLevelData()
		{
		}

		// Token: 0x04005635 RID: 22069
		[Token(Token = "0x4005635")]
		[FieldOffset(Offset = "0x10")]
		public int SkillID;

		// Token: 0x04005636 RID: 22070
		[Token(Token = "0x4005636")]
		[FieldOffset(Offset = "0x14")]
		public int SkillLevel;

		// Token: 0x04005637 RID: 22071
		[Token(Token = "0x4005637")]
		[FieldOffset(Offset = "0x18")]
		public int UnlockPetLevel;

		// Token: 0x04005638 RID: 22072
		[Token(Token = "0x4005638")]
		[FieldOffset(Offset = "0x1C")]
		public int SkillType;

		// Token: 0x04005639 RID: 22073
		[Token(Token = "0x4005639")]
		[FieldOffset(Offset = "0x20")]
		public string SkillDesc;

		// Token: 0x0400563A RID: 22074
		[Token(Token = "0x400563A")]
		[FieldOffset(Offset = "0x28")]
		public float SkillParameter1;

		// Token: 0x0400563B RID: 22075
		[Token(Token = "0x400563B")]
		[FieldOffset(Offset = "0x2C")]
		public float SkillParameter2;

		// Token: 0x0400563C RID: 22076
		[Token(Token = "0x400563C")]
		[FieldOffset(Offset = "0x30")]
		public float SkillParameter3;

		// Token: 0x0400563D RID: 22077
		[Token(Token = "0x400563D")]
		[FieldOffset(Offset = "0x38")]
		public string SkillIconStr;

		// Token: 0x0400563E RID: 22078
		[Token(Token = "0x400563E")]
		[FieldOffset(Offset = "0x40")]
		public string SkillParameter1Str;

		// Token: 0x0400563F RID: 22079
		[Token(Token = "0x400563F")]
		[FieldOffset(Offset = "0x48")]
		public string SkillParameter2Str;

		// Token: 0x04005640 RID: 22080
		[Token(Token = "0x4005640")]
		[FieldOffset(Offset = "0x50")]
		public string SkillParameter3Str;

		// Token: 0x04005641 RID: 22081
		[Token(Token = "0x4005641")]
		[FieldOffset(Offset = "0x58")]
		public ResourceID SkillIconHud;
	}
}
