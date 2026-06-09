using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001CAC RID: 7340
	[Token(Token = "0x2001CAC")]
	public class AvatarProfileDataOverrided
	{
		// Token: 0x0600A031 RID: 41009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A031")]
		[Address(RVA = "0x1565540", Offset = "0x1565540", VA = "0x7BBBD65540")]
		public AvatarProfileDataOverrided()
		{
		}

		// Token: 0x0400A705 RID: 42757
		[Token(Token = "0x400A705")]
		[FieldOffset(Offset = "0x10")]
		public string ProfileTitle;

		// Token: 0x0400A706 RID: 42758
		[Token(Token = "0x400A706")]
		[FieldOffset(Offset = "0x18")]
		public string ProfileContent;

		// Token: 0x0400A707 RID: 42759
		[Token(Token = "0x400A707")]
		[FieldOffset(Offset = "0x20")]
		public string Occupation;

		// Token: 0x0400A708 RID: 42760
		[Token(Token = "0x400A708")]
		[FieldOffset(Offset = "0x28")]
		public string Age;

		// Token: 0x0400A709 RID: 42761
		[Token(Token = "0x400A709")]
		[FieldOffset(Offset = "0x30")]
		public string Birthday;

		// Token: 0x0400A70A RID: 42762
		[Token(Token = "0x400A70A")]
		[FieldOffset(Offset = "0x38")]
		public string Hobby;

		// Token: 0x0400A70B RID: 42763
		[Token(Token = "0x400A70B")]
		[FieldOffset(Offset = "0x40")]
		public string Relationship1;

		// Token: 0x0400A70C RID: 42764
		[Token(Token = "0x400A70C")]
		[FieldOffset(Offset = "0x48")]
		public string Relationship2;

		// Token: 0x0400A70D RID: 42765
		[Token(Token = "0x400A70D")]
		[FieldOffset(Offset = "0x50")]
		public string Relationship3;

		// Token: 0x0400A70E RID: 42766
		[Token(Token = "0x400A70E")]
		[FieldOffset(Offset = "0x58")]
		public ResourceID RelationshipID1;

		// Token: 0x0400A70F RID: 42767
		[Token(Token = "0x400A70F")]
		[FieldOffset(Offset = "0x5C")]
		public ResourceID RelationshipID2;

		// Token: 0x0400A710 RID: 42768
		[Token(Token = "0x400A710")]
		[FieldOffset(Offset = "0x60")]
		public ResourceID RelationshipID3;

		// Token: 0x0400A711 RID: 42769
		[Token(Token = "0x400A711")]
		[FieldOffset(Offset = "0x64")]
		public uint pID;

		// Token: 0x0400A712 RID: 42770
		[Token(Token = "0x400A712")]
		[FieldOffset(Offset = "0x68")]
		public uint ID;

		// Token: 0x0400A713 RID: 42771
		[Token(Token = "0x400A713")]
		[FieldOffset(Offset = "0x6C")]
		public uint Level;

		// Token: 0x0400A714 RID: 42772
		[Token(Token = "0x400A714")]
		[FieldOffset(Offset = "0x70")]
		public uint UnlockLevel;

		// Token: 0x0400A715 RID: 42773
		[Token(Token = "0x400A715")]
		[FieldOffset(Offset = "0x74")]
		public uint RewardId;

		// Token: 0x0400A716 RID: 42774
		[Token(Token = "0x400A716")]
		[FieldOffset(Offset = "0x78")]
		public uint RewardTime;

		// Token: 0x0400A717 RID: 42775
		[Token(Token = "0x400A717")]
		[FieldOffset(Offset = "0x7C")]
		public uint DebrisID;

		// Token: 0x0400A718 RID: 42776
		[Token(Token = "0x400A718")]
		[FieldOffset(Offset = "0x80")]
		public uint DebrisCount;

		// Token: 0x0400A719 RID: 42777
		[Token(Token = "0x400A719")]
		[FieldOffset(Offset = "0x84")]
		public uint CoinValue;

		// Token: 0x0400A71A RID: 42778
		[Token(Token = "0x400A71A")]
		[FieldOffset(Offset = "0x88")]
		public uint GemValue;

		// Token: 0x0400A71B RID: 42779
		[Token(Token = "0x400A71B")]
		[FieldOffset(Offset = "0x8C")]
		public uint ItemID;

		// Token: 0x0400A71C RID: 42780
		[Token(Token = "0x400A71C")]
		[FieldOffset(Offset = "0x90")]
		public uint ItemCnt;

		// Token: 0x0400A71D RID: 42781
		[Token(Token = "0x400A71D")]
		[FieldOffset(Offset = "0x94")]
		public EInventory.AwardType RewardType;
	}
}
