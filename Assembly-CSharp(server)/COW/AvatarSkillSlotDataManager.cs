using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020010A3 RID: 4259
	[Token(Token = "0x20010A3")]
	public class AvatarSkillSlotDataManager : SingletonModule<AvatarSkillSlotDataManager>
	{
		// Token: 0x06004243 RID: 16963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004243")]
		[Address(RVA = "0x21C1EC0", Offset = "0x21C1EC0", VA = "0x7BBC9C1EC0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004244")]
		[Address(RVA = "0x21C2380", Offset = "0x21C2380", VA = "0x7BBC9C2380", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004245")]
		[Address(RVA = "0x21C23E8", Offset = "0x21C23E8", VA = "0x7BBC9C23E8")]
		public Dictionary<uint, AvatarSkillSlotData> GetAllSkillSlotData()
		{
			return null;
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004246")]
		[Address(RVA = "0x21C23F0", Offset = "0x21C23F0", VA = "0x7BBC9C23F0")]
		public AvatarSkillSlotData FindAvatarSkillSlotDataById(uint avatarId)
		{
			return null;
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x000145F8 File Offset: 0x000127F8
		[Token(Token = "0x6004247")]
		[Address(RVA = "0x21C2478", Offset = "0x21C2478", VA = "0x7BBC9C2478")]
		public int GetUnLockSkillCost(uint avatarID, int slotIndex, EInventory.CurrencyType currencyType)
		{
			return 0;
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004248")]
		[Address(RVA = "0x21C24BC", Offset = "0x21C24BC", VA = "0x7BBC9C24BC")]
		public AvatarSkillSlotDataManager()
		{
		}

		// Token: 0x04005150 RID: 20816
		[Token(Token = "0x4005150")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, AvatarSkillSlotData> m_AvailableAvatarSkillSlotData;
	}
}
