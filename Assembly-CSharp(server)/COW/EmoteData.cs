using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010D0 RID: 4304
	[Token(Token = "0x20010D0")]
	public class EmoteData : CSVBaseData
	{
		// Token: 0x06004316 RID: 17174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004316")]
		[Address(RVA = "0x1B8580C", Offset = "0x1B8580C", VA = "0x7BBC38580C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004317")]
		[Address(RVA = "0x1B85818", Offset = "0x1B85818", VA = "0x7BBC385818", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004318")]
		[Address(RVA = "0x1B85D70", Offset = "0x1B85D70", VA = "0x7BBC385D70")]
		public EmoteData()
		{
		}

		// Token: 0x0400528E RID: 21134
		[Token(Token = "0x400528E")]
		[FieldOffset(Offset = "0x10")]
		public int[] HideClothEffectSlots;

		// Token: 0x0400528F RID: 21135
		[Token(Token = "0x400528F")]
		[FieldOffset(Offset = "0x18")]
		public uint iID;

		// Token: 0x04005290 RID: 21136
		[Token(Token = "0x4005290")]
		[FieldOffset(Offset = "0x1C")]
		public uint sortId;

		// Token: 0x04005291 RID: 21137
		[Token(Token = "0x4005291")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID animationResIDMale;

		// Token: 0x04005292 RID: 21138
		[Token(Token = "0x4005292")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID animationResIDFemale;

		// Token: 0x04005293 RID: 21139
		[Token(Token = "0x4005293")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID propID;

		// Token: 0x04005294 RID: 21140
		[Token(Token = "0x4005294")]
		[FieldOffset(Offset = "0x2C")]
		public ResourceID propIDLeft;

		// Token: 0x04005295 RID: 21141
		[Token(Token = "0x4005295")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID propIDRight;

		// Token: 0x04005296 RID: 21142
		[Token(Token = "0x4005296")]
		[FieldOffset(Offset = "0x34")]
		public ResourceID propIDHead;

		// Token: 0x04005297 RID: 21143
		[Token(Token = "0x4005297")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID inGameSceneIconResID;

		// Token: 0x04005298 RID: 21144
		[Token(Token = "0x4005298")]
		[FieldOffset(Offset = "0x3C")]
		public ResourceID VFXMaleIngame;

		// Token: 0x04005299 RID: 21145
		[Token(Token = "0x4005299")]
		[FieldOffset(Offset = "0x40")]
		public ResourceID VFXMaleSystem;

		// Token: 0x0400529A RID: 21146
		[Token(Token = "0x400529A")]
		[FieldOffset(Offset = "0x44")]
		public ResourceID VFXFemaleIngame;

		// Token: 0x0400529B RID: 21147
		[Token(Token = "0x400529B")]
		[FieldOffset(Offset = "0x48")]
		public ResourceID VFXFemaleSystem;

		// Token: 0x0400529C RID: 21148
		[Token(Token = "0x400529C")]
		[FieldOffset(Offset = "0x4C")]
		public ResourceID LeadDancerVFX;

		// Token: 0x0400529D RID: 21149
		[Token(Token = "0x400529D")]
		[FieldOffset(Offset = "0x50")]
		public bool IsLeadEmoteIngame;

		// Token: 0x0400529E RID: 21150
		[Token(Token = "0x400529E")]
		[FieldOffset(Offset = "0x51")]
		public ESourceType sourceTypeKey;

		// Token: 0x0400529F RID: 21151
		[Token(Token = "0x400529F")]
		[FieldOffset(Offset = "0x52")]
		public bool IsLeadEmote;

		// Token: 0x040052A0 RID: 21152
		[Token(Token = "0x40052A0")]
		[FieldOffset(Offset = "0x53")]
		public bool is_random;
	}
}
