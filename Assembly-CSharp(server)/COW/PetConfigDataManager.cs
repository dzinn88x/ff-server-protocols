using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CF8 RID: 7416
	[Token(Token = "0x2001CF8")]
	public class PetConfigDataManager : SingletonModule<PetConfigDataManager>
	{
		// Token: 0x0600A1A9 RID: 41385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A9")]
		[Address(RVA = "0x204E5EC", Offset = "0x204E5EC", VA = "0x7BBC84E5EC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1AA")]
		[Address(RVA = "0x204E670", Offset = "0x204E670", VA = "0x7BBC84E670", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1AB")]
		[Address(RVA = "0x204E6D8", Offset = "0x204E6D8", VA = "0x7BBC84E6D8")]
		public List<PetSkillInfoData> GetPetSkillDataByPetID(uint pet_id)
		{
			return null;
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1AC")]
		[Address(RVA = "0x204EA50", Offset = "0x204EA50", VA = "0x7BBC84EA50")]
		public PetOpenTimeData GetOpenTimeData(uint petID, string region)
		{
			return null;
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1AD")]
		[Address(RVA = "0x204EB70", Offset = "0x204EB70", VA = "0x7BBC84EB70")]
		public List<PetSkillInfoData> GetSkillInfoDataList(uint pet_id)
		{
			return null;
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1AE")]
		[Address(RVA = "0x204EB74", Offset = "0x204EB74", VA = "0x7BBC84EB74")]
		public PetSkillInfoData GetSkillInfoData(uint skillID)
		{
			return null;
		}

		// Token: 0x0600A1AF RID: 41391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1AF")]
		[Address(RVA = "0x204EBF4", Offset = "0x204EBF4", VA = "0x7BBC84EBF4")]
		public PetSkillLevelData GetCurrentSkillLevelData(uint skillID, uint level)
		{
			return null;
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1B0")]
		[Address(RVA = "0x204EDCC", Offset = "0x204EDCC", VA = "0x7BBC84EDCC")]
		public List<PetSkillLevelData> GetSkillLevelDataListBySkillID(uint skill_id)
		{
			return null;
		}

		// Token: 0x0600A1B1 RID: 41393 RVA: 0x0002A708 File Offset: 0x00028908
		[Token(Token = "0x600A1B1")]
		[Address(RVA = "0x204F0BC", Offset = "0x204F0BC", VA = "0x7BBC84F0BC")]
		public int GetMinLevelOfSkill(uint skillID)
		{
			return 0;
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x0002A720 File Offset: 0x00028920
		[Token(Token = "0x600A1B2")]
		[Address(RVA = "0x204F220", Offset = "0x204F220", VA = "0x7BBC84F220")]
		public int GetMaxLevelOfSkill(uint skillID)
		{
			return 0;
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1B3")]
		[Address(RVA = "0x204F384", Offset = "0x204F384", VA = "0x7BBC84F384")]
		public List<PetSkillLevelData> GetAllSkillLevelDataListByPetID(uint pet_id)
		{
			return null;
		}

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1B4")]
		[Address(RVA = "0x204F780", Offset = "0x204F780", VA = "0x7BBC84F780")]
		public PetSkillLevelData GetSkillLevelData(uint skillID, uint skillLevel)
		{
			return null;
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1B5")]
		[Address(RVA = "0x204F9B8", Offset = "0x204F9B8", VA = "0x7BBC84F9B8")]
		public List<PetActionData> GetPetActionDataByPetID(uint pet_id)
		{
			return null;
		}

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1B6")]
		[Address(RVA = "0x204FC40", Offset = "0x204FC40", VA = "0x7BBC84FC40")]
		public List<PetSkinData> GetPetSkinDataByPetID(uint pet_id)
		{
			return null;
		}

		// Token: 0x0600A1B7 RID: 41399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1B7")]
		[Address(RVA = "0x204FEC8", Offset = "0x204FEC8", VA = "0x7BBC84FEC8")]
		public List<PetActionData> GetNewUnlockPetActionDataByLvUp(uint pet_id, uint level_old, uint level_new)
		{
			return null;
		}

		// Token: 0x0600A1B8 RID: 41400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1B8")]
		[Address(RVA = "0x205006C", Offset = "0x205006C", VA = "0x7BBC85006C")]
		public List<PetSkinData> GetNewUnlockPetSkinDataByLvUp(uint pet_id, uint level_old, uint level_new)
		{
			return null;
		}

		// Token: 0x0600A1B9 RID: 41401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1B9")]
		[Address(RVA = "0x2050210", Offset = "0x2050210", VA = "0x7BBC850210")]
		public List<PetSkillInfoData> GetNewUnlockPetSkillDataByLvUp(uint pet_id, uint level_old, uint level_new)
		{
			return null;
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x0002A738 File Offset: 0x00028938
		[Token(Token = "0x600A1BA")]
		[Address(RVA = "0x205045C", Offset = "0x205045C", VA = "0x7BBC85045C")]
		public uint GetPetDefaultSkinID(uint pet_id)
		{
			return 0U;
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x0002A750 File Offset: 0x00028950
		[Token(Token = "0x600A1BB")]
		[Address(RVA = "0x205057C", Offset = "0x205057C", VA = "0x7BBC85057C")]
		public ResourceID GetPetLobbyBasicActionResByID(uint pet_id)
		{
			return default(ResourceID);
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x0002A768 File Offset: 0x00028968
		[Token(Token = "0x600A1BC")]
		[Address(RVA = "0x2050664", Offset = "0x2050664", VA = "0x7BBC850664")]
		public ResourceID GetPetExtraActionResByID(uint pet_id)
		{
			return default(ResourceID);
		}

		// Token: 0x0600A1BD RID: 41405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1BD")]
		[Address(RVA = "0x205074C", Offset = "0x205074C", VA = "0x7BBC85074C")]
		public PetConfigDataManager()
		{
		}

		// Token: 0x0400A81E RID: 43038
		[Token(Token = "0x400A81E")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, List<PetSkillInfoData>> m_skillInfo_list;

		// Token: 0x0400A81F RID: 43039
		[Token(Token = "0x400A81F")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, PetSkillInfoData> m_skillMap;

		// Token: 0x02001CF9 RID: 7417
		[Token(Token = "0x2001CF9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBAA4", Offset = "0x10FBAA4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A1BF RID: 41407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1BF")]
			[Address(RVA = "0x2050870", Offset = "0x2050870", VA = "0x7BBC850870")]
			public <>c()
			{
			}

			// Token: 0x0600A1C0 RID: 41408 RVA: 0x0002A780 File Offset: 0x00028980
			[Token(Token = "0x600A1C0")]
			[Address(RVA = "0x2050878", Offset = "0x2050878", VA = "0x7BBC850878")]
			internal bool <GetPetDefaultSkinID>b__19_0(PetSkinData temp)
			{
				return default(bool);
			}

			// Token: 0x0400A820 RID: 43040
			[Token(Token = "0x400A820")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PetConfigDataManager.<>c <>9;

			// Token: 0x0400A821 RID: 43041
			[Token(Token = "0x400A821")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<PetSkinData> <>9__19_0;
		}
	}
}
