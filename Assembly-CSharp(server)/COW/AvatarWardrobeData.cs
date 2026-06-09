using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010A8 RID: 4264
	[Token(Token = "0x20010A8")]
	public class AvatarWardrobeData : CsvDataIndexedReading, IComparable<AvatarWardrobeData>, IGetId
	{
		// Token: 0x06004276 RID: 17014 RVA: 0x00014778 File Offset: 0x00012978
		[Token(Token = "0x6004276")]
		[Address(RVA = "0x21C304C", Offset = "0x21C304C", VA = "0x7BBC9C304C", Slot = "10")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004277")]
		[Address(RVA = "0x21C3054", Offset = "0x21C3054", VA = "0x7BBC9C3054", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004278")]
		[Address(RVA = "0x21C3060", Offset = "0x21C3060", VA = "0x7BBC9C3060", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004279")]
		[Address(RVA = "0x21C389C", Offset = "0x21C389C", VA = "0x7BBC9C389C", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427A")]
		[Address(RVA = "0x21C49C4", Offset = "0x21C49C4", VA = "0x7BBC9C49C4")]
		public static void ClearAvatarSpecialData()
		{
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427B")]
		[Address(RVA = "0x21C4A38", Offset = "0x21C4A38", VA = "0x7BBC9C4A38")]
		public void AddAvatarSpecialData(ClothesSpecialData c)
		{
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600427C")]
		[Address(RVA = "0x21C4B64", Offset = "0x21C4B64", VA = "0x7BBC9C4B64")]
		private ClothesSpecialData GetAvatarData(uint avatarID)
		{
			return null;
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600427D RID: 17021 RVA: 0x00014790 File Offset: 0x00012990
		[Token(Token = "0x170007DF")]
		public bool IsHeadAdditiveSlot
		{
			[Token(Token = "0x600427D")]
			[Address(RVA = "0x21C4CE8", Offset = "0x21C4CE8", VA = "0x7BBC9C4CE8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x000147A8 File Offset: 0x000129A8
		[Token(Token = "0x600427E")]
		[Address(RVA = "0x21C4CF8", Offset = "0x21C4CF8", VA = "0x7BBC9C4CF8")]
		public bool HasLobbyRecipeForAvatar(uint avatarID, bool female)
		{
			return default(bool);
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600427F")]
		[Address(RVA = "0x21C4D84", Offset = "0x21C4D84", VA = "0x7BBC9C4D84")]
		public string GetLobbyRecipeForAvatar(uint avatarID, bool female)
		{
			return null;
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004280")]
		[Address(RVA = "0x21C4E68", Offset = "0x21C4E68", VA = "0x7BBC9C4E68")]
		public string GetGameRecipeForAvatar(uint avatarID, bool female)
		{
			return null;
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004281")]
		[Address(RVA = "0x21C4D98", Offset = "0x21C4D98", VA = "0x7BBC9C4D98")]
		private string GetRecipeForAvatar(bool lobby, uint avatarID, bool female)
		{
			return null;
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004282")]
		[Address(RVA = "0x21C4E7C", Offset = "0x21C4E7C", VA = "0x7BBC9C4E7C")]
		private string GetRecipeForAvatarRaw(bool lobby, uint avatarID, bool female)
		{
			return null;
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004283")]
		[Address(RVA = "0x21C4EA4", Offset = "0x21C4EA4", VA = "0x7BBC9C4EA4")]
		public string GetArbitraryLobbyRecipe()
		{
			return null;
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x000147C0 File Offset: 0x000129C0
		[Token(Token = "0x6004284")]
		[Address(RVA = "0x21C5064", Offset = "0x21C5064", VA = "0x7BBC9C5064", Slot = "9")]
		public int CompareTo(AvatarWardrobeData other)
		{
			return 0;
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06004285 RID: 17029 RVA: 0x000147D8 File Offset: 0x000129D8
		// (set) Token: 0x06004286 RID: 17030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E0")]
		public bool HideBackpack
		{
			[Token(Token = "0x6004285")]
			[Address(RVA = "0x21C51C8", Offset = "0x21C51C8", VA = "0x7BBC9C51C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004286")]
			[Address(RVA = "0x21C526C", Offset = "0x21C526C", VA = "0x7BBC9C526C")]
			set
			{
			}
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x000147F0 File Offset: 0x000129F0
		[Token(Token = "0x6004287")]
		[Address(RVA = "0x21C5378", Offset = "0x21C5378", VA = "0x7BBC9C5378")]
		public ResourceID GetEffectResID(bool is1P, bool isFemale)
		{
			return default(ResourceID);
		}

		// Token: 0x06004288 RID: 17032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004288")]
		[Address(RVA = "0x21C53A0", Offset = "0x21C53A0", VA = "0x7BBC9C53A0")]
		public AvatarWardrobeData()
		{
		}

		// Token: 0x04005175 RID: 20853
		[Token(Token = "0x4005175")]
		[FieldOffset(Offset = "0x10")]
		public string recipeStrInLobby;

		// Token: 0x04005176 RID: 20854
		[Token(Token = "0x4005176")]
		[FieldOffset(Offset = "0x18")]
		public string recipeStrInGame;

		// Token: 0x04005177 RID: 20855
		[Token(Token = "0x4005177")]
		[FieldOffset(Offset = "0x20")]
		public string recipeStrInLobby_F;

		// Token: 0x04005178 RID: 20856
		[Token(Token = "0x4005178")]
		[FieldOffset(Offset = "0x28")]
		public string recipeStrInGame_F;

		// Token: 0x04005179 RID: 20857
		[Token(Token = "0x4005179")]
		[FieldOffset(Offset = "0x30")]
		public uint iID;

		// Token: 0x0400517A RID: 20858
		[Token(Token = "0x400517A")]
		[FieldOffset(Offset = "0x34")]
		public uint avatarID;

		// Token: 0x0400517B RID: 20859
		[Token(Token = "0x400517B")]
		[FieldOffset(Offset = "0x38")]
		public uint setID;

		// Token: 0x0400517C RID: 20860
		[Token(Token = "0x400517C")]
		[FieldOffset(Offset = "0x3C")]
		public ResourceID idleAnimResID;

		// Token: 0x0400517D RID: 20861
		[Token(Token = "0x400517D")]
		[FieldOffset(Offset = "0x40")]
		public ResourceID showPoseAnimResID;

		// Token: 0x0400517E RID: 20862
		[Token(Token = "0x400517E")]
		[FieldOffset(Offset = "0x44")]
		public ResourceID showPoseEffectResID;

		// Token: 0x0400517F RID: 20863
		[Token(Token = "0x400517F")]
		[FieldOffset(Offset = "0x48")]
		public ResourceID DecorPropIDRoot;

		// Token: 0x04005180 RID: 20864
		[Token(Token = "0x4005180")]
		[FieldOffset(Offset = "0x4C")]
		public ResourceID DecorPropIDLeft;

		// Token: 0x04005181 RID: 20865
		[Token(Token = "0x4005181")]
		[FieldOffset(Offset = "0x50")]
		public ResourceID DecorPropIDRight;

		// Token: 0x04005182 RID: 20866
		[Token(Token = "0x4005182")]
		[FieldOffset(Offset = "0x54")]
		public ResourceID EffectID_F;

		// Token: 0x04005183 RID: 20867
		[Token(Token = "0x4005183")]
		[FieldOffset(Offset = "0x58")]
		public ResourceID EffectID_M;

		// Token: 0x04005184 RID: 20868
		[Token(Token = "0x4005184")]
		[FieldOffset(Offset = "0x5C")]
		public ResourceID EffectID_3P_F;

		// Token: 0x04005185 RID: 20869
		[Token(Token = "0x4005185")]
		[FieldOffset(Offset = "0x60")]
		public ResourceID EffectID_3P_M;

		// Token: 0x04005186 RID: 20870
		[Token(Token = "0x4005186")]
		[FieldOffset(Offset = "0x64")]
		public ResourceID TeamEffectMale;

		// Token: 0x04005187 RID: 20871
		[Token(Token = "0x4005187")]
		[FieldOffset(Offset = "0x68")]
		public ResourceID TeamEffectFemale;

		// Token: 0x04005188 RID: 20872
		[Token(Token = "0x4005188")]
		[FieldOffset(Offset = "0x6C")]
		public byte wardrobeType;

		// Token: 0x04005189 RID: 20873
		[Token(Token = "0x4005189")]
		[FieldOffset(Offset = "0x6D")]
		public bool isDefault;

		// Token: 0x0400518A RID: 20874
		[Token(Token = "0x400518A")]
		[FieldOffset(Offset = "0x6E")]
		public bool BackpackSwitch;

		// Token: 0x0400518B RID: 20875
		[Token(Token = "0x400518B")]
		[FieldOffset(Offset = "0x6F")]
		public bool HasSpecialData;

		// Token: 0x0400518C RID: 20876
		[Token(Token = "0x400518C")]
		public const byte HeadAdditiveSlotId = 14;

		// Token: 0x0400518D RID: 20877
		[Token(Token = "0x400518D")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<uint, List<ClothesSpecialData>> avatarSpetialRecipes;
	}
}
