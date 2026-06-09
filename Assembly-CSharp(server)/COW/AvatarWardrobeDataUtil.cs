using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001342 RID: 4930
	[Token(Token = "0x2001342")]
	public static class AvatarWardrobeDataUtil
	{
		// Token: 0x06004E45 RID: 20037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E45")]
		[Address(RVA = "0x21C7D94", Offset = "0x21C7D94", VA = "0x7BBC9C7D94")]
		public static AvatarWardrobeData GetWardrobeData(uint id)
		{
			return null;
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E46")]
		[Address(RVA = "0x21C7E18", Offset = "0x21C7E18", VA = "0x7BBC9C7E18")]
		public static string GetSlot(AvatarWardrobeData wData)
		{
			return null;
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E47")]
		[Address(RVA = "0x21C8088", Offset = "0x21C8088", VA = "0x7BBC9C8088")]
		public static string GetSlot(UIModelAvatarBase.EWardrobeType t)
		{
			return null;
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E48")]
		[Address(RVA = "0x21C8134", Offset = "0x21C8134", VA = "0x7BBC9C8134")]
		public static string GetConflictSlot(string selectSlot, Dictionary<string, AvatarWardrobeData> slots, bool isFemale, uint avatarId)
		{
			return null;
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E49")]
		[Address(RVA = "0x21C83F4", Offset = "0x21C83F4", VA = "0x7BBC9C83F4")]
		public static void RemoveConflictSlot(AvatarWardrobeData wData, List<uint> cs, bool isFemale, uint avatarId, bool considerHidingTarget)
		{
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4A")]
		[Address(RVA = "0x21C8270", Offset = "0x21C8270", VA = "0x7BBC9C8270")]
		private static string GetPotentialConflictSlot(string slot)
		{
			return null;
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x00017DF0 File Offset: 0x00015FF0
		[Token(Token = "0x6004E4B")]
		[Address(RVA = "0x21C82F8", Offset = "0x21C82F8", VA = "0x7BBC9C82F8")]
		public static bool IsConflict(AvatarWardrobeData selectData, AvatarWardrobeData targetData, bool considerHidingTarget, bool isFemale, uint avatarId)
		{
			return default(bool);
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x00017E08 File Offset: 0x00016008
		[Token(Token = "0x6004E4C")]
		[Address(RVA = "0x21C8638", Offset = "0x21C8638", VA = "0x7BBC9C8638")]
		public static bool CheckCanEquipHair(AvatarWardrobeData data)
		{
			return default(bool);
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x00017E20 File Offset: 0x00016020
		[Token(Token = "0x6004E4D")]
		[Address(RVA = "0x21C866C", Offset = "0x21C866C", VA = "0x7BBC9C866C")]
		public static bool CheckCanEquipFace(AvatarWardrobeData data)
		{
			return default(bool);
		}

		// Token: 0x04007565 RID: 30053
		[Token(Token = "0x4007565")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<UIModelAvatarBase.EWardrobeType, string> m_SlotNameDic;
	}
}
