using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200133F RID: 4927
	[Token(Token = "0x200133F")]
	public class AvatarWardrobeDataManager : SingletonModule<AvatarWardrobeDataManager>
	{
		// Token: 0x06004E1E RID: 19998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1E")]
		[Address(RVA = "0x21C5478", Offset = "0x21C5478", VA = "0x7BBC9C5478", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1F")]
		[Address(RVA = "0x21C559C", Offset = "0x21C559C", VA = "0x7BBC9C559C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x00017CA0 File Offset: 0x00015EA0
		[Token(Token = "0x6004E20")]
		[Address(RVA = "0x21C6188", Offset = "0x21C6188", VA = "0x7BBC9C6188")]
		public uint FindHairByLevel(uint id, int level)
		{
			return 0U;
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E21")]
		[Address(RVA = "0x21C6024", Offset = "0x21C6024", VA = "0x7BBC9C6024")]
		private void AddRecipeMapping(string key, AvatarRecipeMappingData wData, ref Dictionary<string, List<AvatarRecipeMappingData>> map)
		{
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E22")]
		[Address(RVA = "0x21C6298", Offset = "0x21C6298", VA = "0x7BBC9C6298")]
		public Dictionary<uint, AvatarWardrobeData> FindAllAvatarWardrobeData()
		{
			return null;
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x00017CB8 File Offset: 0x00015EB8
		[Token(Token = "0x6004E23")]
		[Address(RVA = "0x21C62A0", Offset = "0x21C62A0", VA = "0x7BBC9C62A0")]
		public bool IsClothItemLegend(uint clothId)
		{
			return default(bool);
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x00017CD0 File Offset: 0x00015ED0
		[Token(Token = "0x6004E24")]
		[Address(RVA = "0x21C6360", Offset = "0x21C6360", VA = "0x7BBC9C6360")]
		public bool IsClothItemLegend(AvatarWardrobeData data)
		{
			return default(bool);
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x00017CE8 File Offset: 0x00015EE8
		[Token(Token = "0x6004E25")]
		[Address(RVA = "0x21C638C", Offset = "0x21C638C", VA = "0x7BBC9C638C")]
		public bool IsSetLegend(uint setId)
		{
			return default(bool);
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x00017D00 File Offset: 0x00015F00
		[Token(Token = "0x6004E26")]
		[Address(RVA = "0x21C6400", Offset = "0x21C6400", VA = "0x7BBC9C6400")]
		public uint GetLegendLevelByClothId(uint clothId)
		{
			return 0U;
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x00017D18 File Offset: 0x00015F18
		[Token(Token = "0x6004E27")]
		[Address(RVA = "0x21C64C0", Offset = "0x21C64C0", VA = "0x7BBC9C64C0")]
		public uint GetLegendTypeByClothId(uint clothId)
		{
			return 0U;
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x00017D30 File Offset: 0x00015F30
		[Token(Token = "0x6004E28")]
		[Address(RVA = "0x21C6438", Offset = "0x21C6438", VA = "0x7BBC9C6438")]
		public uint GetLegendLevelBySet(uint setId)
		{
			return 0U;
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x00017D48 File Offset: 0x00015F48
		[Token(Token = "0x6004E29")]
		[Address(RVA = "0x21C64F8", Offset = "0x21C64F8", VA = "0x7BBC9C64F8")]
		public uint GetLegendTypeBySet(uint setId)
		{
			return 0U;
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2A")]
		[Address(RVA = "0x21C6580", Offset = "0x21C6580", VA = "0x7BBC9C6580")]
		public LegendClothData GetLegendClothLockLevel(uint legendId, out int unlockLevelMax)
		{
			return null;
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2B")]
		[Address(RVA = "0x21C697C", Offset = "0x21C697C", VA = "0x7BBC9C697C")]
		public List<LegendClothData> GetSortedLegendClothDataByLegendId(uint legendId)
		{
			return null;
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2C")]
		[Address(RVA = "0x21C6C60", Offset = "0x21C6C60", VA = "0x7BBC9C6C60")]
		public List<AvatarWardrobeData> GetLegendAvatarWardrobeData(uint legendId, uint level = 1U)
		{
			return null;
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0x21C6DBC", Offset = "0x21C6DBC", VA = "0x7BBC9C6DBC")]
		public AvatarWardrobeData GetLegendAvatarWardrobeData(uint legendId, uint level, UIModelAvatarBase.EWardrobeType wardrobeType)
		{
			return null;
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x00017D60 File Offset: 0x00015F60
		[Token(Token = "0x6004E2E")]
		[Address(RVA = "0x21C6EF8", Offset = "0x21C6EF8", VA = "0x7BBC9C6EF8")]
		public ResourceID GetTeamEffectRes(uint clothId, bool isFemale)
		{
			return default(ResourceID);
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2F")]
		[Address(RVA = "0x21C62D8", Offset = "0x21C62D8", VA = "0x7BBC9C62D8")]
		public AvatarWardrobeData FindAvatarWardrobeDataById(uint InId)
		{
			return null;
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E30")]
		[Address(RVA = "0x21C6F98", Offset = "0x21C6F98", VA = "0x7BBC9C6F98")]
		public List<AvatarWardrobeData> FindAvatarWardrobeListByType(uint wType)
		{
			return null;
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E31")]
		[Address(RVA = "0x21C7020", Offset = "0x21C7020", VA = "0x7BBC9C7020")]
		public List<AvatarRecipeMappingData> FindRecipeMappingForTarget(string recipe)
		{
			return null;
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E32")]
		[Address(RVA = "0x21C70A0", Offset = "0x21C70A0", VA = "0x7BBC9C70A0")]
		public List<AvatarRecipeMappingData> FindRecipeMappingForCondition(string recipe)
		{
			return null;
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E33")]
		[Address(RVA = "0x21C7120", Offset = "0x21C7120", VA = "0x7BBC9C7120")]
		public ClothEffectData FindClothEffectDataByQuality(uint quality)
		{
			return null;
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x00017D78 File Offset: 0x00015F78
		[Token(Token = "0x6004E34")]
		[Address(RVA = "0x21C71A8", Offset = "0x21C71A8", VA = "0x7BBC9C71A8")]
		public bool ShowClothEffect(AvatarWardrobeDataManager.EPlayerIdentity pId)
		{
			return default(bool);
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E35")]
		[Address(RVA = "0x21C6BE0", Offset = "0x21C6BE0", VA = "0x7BBC9C6BE0")]
		public List<AvatarWardrobeData> GetWardrobeSet(uint setID)
		{
			return null;
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x00017D90 File Offset: 0x00015F90
		[Token(Token = "0x6004E36")]
		[Address(RVA = "0x21C729C", Offset = "0x21C729C", VA = "0x7BBC9C729C")]
		public bool HasAnimationInCloth(uint clothID)
		{
			return default(bool);
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x00017DA8 File Offset: 0x00015FA8
		[Token(Token = "0x6004E37")]
		[Address(RVA = "0x21C72B4", Offset = "0x21C72B4", VA = "0x7BBC9C72B4")]
		public bool HasAnimationInCloth(AvatarWardrobeData wData)
		{
			return default(bool);
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E38")]
		private V FincData<K, V>(Dictionary<K, V> dic, K k) where V : class
		{
			return null;
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E39")]
		[Address(RVA = "0x21C738C", Offset = "0x21C738C", VA = "0x7BBC9C738C")]
		public ClothesUpData FindClothesUpDataByUniqueID(uint id)
		{
			return null;
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3A")]
		[Address(RVA = "0x21C73F0", Offset = "0x21C73F0", VA = "0x7BBC9C73F0")]
		public ClothesUpData FindFirstClothesUpDataByClothesID(uint clothesID)
		{
			return null;
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3B")]
		[Address(RVA = "0x21C73F8", Offset = "0x21C73F8", VA = "0x7BBC9C73F8")]
		public ClothesUpData FindClothesUpDataByClothesAndIndex(uint clothesID, uint index)
		{
			return null;
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3C")]
		[Address(RVA = "0x21C7568", Offset = "0x21C7568", VA = "0x7BBC9C7568")]
		public EpicClothesTextData FindEpicClothesTextData(uint id)
		{
			return null;
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x00017DC0 File Offset: 0x00015FC0
		[Token(Token = "0x6004E3D")]
		[Address(RVA = "0x21C75CC", Offset = "0x21C75CC", VA = "0x7BBC9C75CC")]
		public bool IsEpicClothes(uint id)
		{
			return default(bool);
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3E")]
		[Address(RVA = "0x21C763C", Offset = "0x21C763C", VA = "0x7BBC9C763C")]
		public string GetHDRecipe(string defaultRecipe)
		{
			return null;
		}

		// Token: 0x06004E3F RID: 20031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3F")]
		[Address(RVA = "0x21C76E8", Offset = "0x21C76E8", VA = "0x7BBC9C76E8")]
		public string GetLobbyRecipe(uint dataID, uint avatarId, bool isFemale)
		{
			return null;
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E40")]
		[Address(RVA = "0x21C7728", Offset = "0x21C7728", VA = "0x7BBC9C7728")]
		public string GetLobbyRecipe(AvatarWardrobeData wData, uint avatarId, bool isFemale)
		{
			return null;
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E41")]
		[Address(RVA = "0x21C7ACC", Offset = "0x21C7ACC", VA = "0x7BBC9C7ACC")]
		public AvatarWardrobeDataManager()
		{
		}

		// Token: 0x04007554 RID: 30036
		[Token(Token = "0x4007554")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, AvatarWardrobeData> m_dictIdToWardrobeData;

		// Token: 0x04007555 RID: 30037
		[Token(Token = "0x4007555")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, LegendClothData> m_dictIdToLegendClothData;

		// Token: 0x04007556 RID: 30038
		[Token(Token = "0x4007556")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<uint, List<AvatarWardrobeData>> m_dictTypeToWardrobeData;

		// Token: 0x04007557 RID: 30039
		[Token(Token = "0x4007557")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, ClothesHairUpData> m_dictIdToHairUpData;

		// Token: 0x04007558 RID: 30040
		[Token(Token = "0x4007558")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<uint, ClothEffectData> m_dictIdToClothEffectData;

		// Token: 0x04007559 RID: 30041
		[Token(Token = "0x4007559")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<uint, List<AvatarWardrobeData>> m_dictWardrobeSets;

		// Token: 0x0400755A RID: 30042
		[Token(Token = "0x400755A")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<uint, ClothesUpData> m_dictIdToClothUpData;

		// Token: 0x0400755B RID: 30043
		[Token(Token = "0x400755B")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<uint, EpicClothesTextData> m_dictIdToEpicClothesData;

		// Token: 0x0400755C RID: 30044
		[Token(Token = "0x400755C")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, AvatarHDRecipeData> m_dictHDRecipeData;

		// Token: 0x0400755D RID: 30045
		[Token(Token = "0x400755D")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, List<AvatarRecipeMappingData>> m_dictResipeMappingTargetData;

		// Token: 0x0400755E RID: 30046
		[Token(Token = "0x400755E")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, List<AvatarRecipeMappingData>> m_dictResipeMappingConditionData;

		// Token: 0x02001340 RID: 4928
		[Token(Token = "0x2001340")]
		public enum EPlayerIdentity
		{
			// Token: 0x04007560 RID: 30048
			[Token(Token = "0x4007560")]
			LocalPlayer,
			// Token: 0x04007561 RID: 30049
			[Token(Token = "0x4007561")]
			Teammate,
			// Token: 0x04007562 RID: 30050
			[Token(Token = "0x4007562")]
			Enemy
		}

		// Token: 0x02001341 RID: 4929
		[Token(Token = "0x2001341")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB178", Offset = "0x10EB178")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E43 RID: 20035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E43")]
			[Address(RVA = "0x21C7D40", Offset = "0x21C7D40", VA = "0x7BBC9C7D40")]
			public <>c()
			{
			}

			// Token: 0x06004E44 RID: 20036 RVA: 0x00017DD8 File Offset: 0x00015FD8
			[Token(Token = "0x6004E44")]
			[Address(RVA = "0x21C7D48", Offset = "0x21C7D48", VA = "0x7BBC9C7D48")]
			internal int <GetSortedLegendClothDataByLegendId>b__24_0(LegendClothData a, LegendClothData b)
			{
				return 0;
			}

			// Token: 0x04007563 RID: 30051
			[Token(Token = "0x4007563")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AvatarWardrobeDataManager.<>c <>9;

			// Token: 0x04007564 RID: 30052
			[Token(Token = "0x4007564")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<LegendClothData> <>9__24_0;
		}
	}
}
